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

            if (!customer.IsOtp)
            {
                var otpCode = new OtpService().GenerateOtp();


                customer.OtpCode = otpCode;
                customer.OtpExpirationTime = DateTime.UtcNow.AddMinutes(3);
                customer.NotificationToken = request.Request.NotificationToken;

                await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
                await _unitOfWork.SaveAsync();

                //await new OtpService().SendOtp(customer.Phone, otpCode);
                AtaTeknolojiSmsService newAta = new AtaTeknolojiSmsService();
                newAta.SmsGonder(customer.Phone, otpCode);

                return new LoginResDto
                {
                    RequiresOtp = true,
                    Message = "OTP göndərildi. Zəhmət olmasa, təsdiqləyin."
                };
            }

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            refreshToken = _jwtHelper.GenerateRefreshToken();
            customer.RefreshToken = refreshToken;
            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            if (customer.NotificationToken != null)
            {
                customer.NotificationToken = request.Request.NotificationToken;
            }
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
