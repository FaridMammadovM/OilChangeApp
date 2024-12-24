using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.Logout
{
    public class LogoutQueryHandler : IRequestHandler<LogoutQuery, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public LogoutQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);

        }

        public async Task<string> Handle(LogoutQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.RefreshToken == request.RefreshToken && x.IsDeleted == false);

            if (customer == null)
                return null;

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            refreshToken = _jwtHelper.GenerateRefreshToken();
            customer.RefreshToken = refreshToken;
            customer.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();


            return "Uğurla tamamlandı";
        }
    }
}

