using Application.CQRS.Queries.Customer.Login.Dto;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Customer.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;

        public LoginQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
        }

        public async Task<LoginResDto> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.Phone == request.Request.Phone && x.IsDeleted == false);

            if (customer == null)
                throw new Exception("Kullanıcı bulunamadı.");

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(request.Request.Password, customer.Password);
            if (!isPasswordValid)
                throw new Exception("Geçersiz parola.");

            var accessToken = _jwtHelper.GenerateAccessToken(customer.Id.ToString());
            var refreshToken = customer.RefreshToken;

            // Refresh token geçerlilik süresini kontrol et, gerekiyorsa yenile
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
                RefreshTokenExpiryTime = DateTime.Now
            };
        }
    }
}
