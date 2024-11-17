using Application.CQRS.Queries.Customer.Login.Dto;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public LoginQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);

        }

        public async Task<LoginResDto> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.Phone == request.Request.Phone && x.IsDeleted == false);

            if (customer == null)
                return null;

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(request.Request.Password, customer.Password);
            if (!isPasswordValid)
                return null;

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            if (customer.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                refreshToken = _jwtHelper.GenerateRefreshToken();
                customer.RefreshToken = refreshToken;
                customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(60);
                await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
                await _unitOfWork.SaveAsync();
            }

            return new LoginResDto
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(_refreshTokenExpiration),
            };
        }
    }
}
