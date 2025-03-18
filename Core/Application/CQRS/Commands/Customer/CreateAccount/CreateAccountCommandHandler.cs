using Application.Beheviors;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Commands.Customer.AddCustomer;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Application.CQRS.Queries.Customer.Login.Dto;
using Application.CQRS.Queries.Customer.Login;
using Application.CQRS.Commands.Customer.CreateAccount.Dtos;

namespace Application.CQRS.Commands.Customer.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, LoginResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerRules _customerRules;
        private readonly ICostumMapper _mapper;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateAccountCommandHandler(ICostumMapper mapper, IUnitOfWork unitOfWork,
            CustomerRules customerRules, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _customerRules = customerRules;
            _mapper = mapper;
            _jwtHelper = new JwtHelper(configuration);
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<LoginResDto> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            int userId = 1;

            IList<Customers> customersList = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => c.IsDeleted == false);

            await _customerRules.CustomerFindPhoneAccount(customersList.Where(c => c.RoleId == 1), request.Request);
            Customers customers = _mapper.Map<Customers, CreateAccountReqDto>(request.Request);
            customers.Password = _jwtHelper.HashPassword(request.Request.Password);
            customers.RefreshToken = _jwtHelper.GenerateRefreshToken();
            customers.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_refreshTokenExpiration);
            customers.InsertedBy = userId;
            customers.IsOtp = false;
            customers.RoleId = 1;       

            var otpCode = new OtpService().GenerateOtp();

            customers.OtpCode = otpCode;
            customers.OtpExpirationTime = DateTime.UtcNow.AddMinutes(3);
            customers.NotificationToken = request.Request.NotificationToken;
            await _unitOfWork.GetWriteRepository<Customers>().AddAsync(customers);
            await _unitOfWork.SaveAsync();

            //await new OtpService().SendOtp(customer.Phone, otpCode);
            AtaTeknolojiSmsService newAta = new AtaTeknolojiSmsService();
            newAta.SmsGonder(customers.Phone, otpCode);

            return new LoginResDto
            {
                RequiresOtp = true,
                Message = "OTP göndərildi. Zəhmət olmasa, təsdiqləyin."
            };
        }
    }
}
