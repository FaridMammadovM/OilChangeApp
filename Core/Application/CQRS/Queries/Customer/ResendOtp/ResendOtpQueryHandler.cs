using Application.CQRS.Queries.Customer.Login;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Queries.Customer.ResendOtp
{
    public sealed class ResendOtpQueryHandler : IRequestHandler<ResendOtpQuery, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public ResendOtpQueryHandler(IUnitOfWork unitOfWork, JwtHelper jwtHelper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _jwtHelper = jwtHelper;
        }

        public async Task<Unit> Handle(ResendOtpQuery request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.GetReadRepository<Customers>()
                .GetAsync(x => x.Phone == request.Request.Phone && x.IsDeleted == false);

            var otpCode = new OtpService().GenerateOtp();

            customer.OtpCode = otpCode;
            customer.OtpExpirationTime = DateTime.UtcNow.AddMinutes(3);

            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(customer);
            await _unitOfWork.SaveAsync();

            AtaTeknolojiSmsService newAta = new AtaTeknolojiSmsService();
            newAta.SmsGonder(customer.Phone, otpCode);
            return Unit.Value;


        }
    }
}
