using Application.CQRS.Queries.Customer.Login.Dto;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.VerifyOtp
{
    public sealed class VerifyOtpQueryHandler : IRequestHandler<VerifyOtpQuery, LoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        private readonly CustomerRules _customerRules;

        public VerifyOtpQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration, CustomerRules customerRules)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);
            _customerRules = customerRules;
        }

        public async Task<LoginResDto> Handle(VerifyOtpQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.Phone == request.Request.Phone && x.IsDeleted == false && x.OtpCode == request.Request.OtpCode);

            if (customer == null)
            {
                return null;
            }

            if (customer.OtpExpirationTime < DateTime.UtcNow)
            {

                return null;
            }

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;


            refreshToken = _jwtHelper.GenerateRefreshToken();
            customer.RefreshToken = refreshToken;
            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            customer.IsOtp = true;
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();


            return new LoginResDto
            {
                RequiresOtp = false,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration),
            };
        }
    }
}