using Application.CQRS.Queries.Customer.Login.Dto;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.CheckToken
{
    public sealed class CheckTokenQueryHandler : IRequestHandler<CheckTokenQuery, LoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public CheckTokenQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);

        }

        public async Task<LoginResDto> Handle(CheckTokenQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.RefreshToken == request.RefreshToken && x.IsDeleted == false);

            if (customer == null)
                return null;


            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();


            return new LoginResDto
            {
                RequiresOtp = false,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(_refreshTokenExpiration),
            };
        }
    }
}
