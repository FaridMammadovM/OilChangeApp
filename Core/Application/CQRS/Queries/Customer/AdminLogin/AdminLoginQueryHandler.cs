using Application.CQRS.Queries.Customer.AdminLogin.Dtos;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.AdminLogin
{
    public class AdminLoginQueryHandler : IRequestHandler<AdminLoginQuery, AdminLoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public AdminLoginQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);

        }

        public async Task<AdminLoginResDto> Handle(AdminLoginQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.Username == request.Request.Username && x.IsDeleted == false);

            if (customer == null)
            {
                throw new ValidationException("Username və ya şifrə yanlışdır");

            }

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(request.Request.Password, customer.Password);
            if (!isPasswordValid)
            {
                throw new ValidationException("Username və ya şifrə yanlışdır");
            }

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            refreshToken = _jwtHelper.GenerateRefreshToken();
            customer.RefreshToken = refreshToken;
            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);

            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();


            return new AdminLoginResDto
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration),
            };
        }
    }
}