using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Application.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Customer.AddCustomer
{
    public sealed class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerRules _customerRules;
        private readonly ICostumMapper _mapper;
        private readonly JwtHelper _jwtHelper;
        private readonly int _refreshTokenExpiration;
        public AddCustomerCommandHandler(ICostumMapper mapper, IUnitOfWork unitOfWork,
            CustomerRules customerRules, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _customerRules = customerRules;
            _mapper = mapper;
            _jwtHelper = new JwtHelper(configuration);
            _refreshTokenExpiration = int.Parse(configuration["JwtSettings:RefreshTokenExpiration"]);
        }
        public async Task<Unit> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            IList<Customers> customersList = await _unitOfWork.GetReadRepository<Customers>()
                .GetAllAsync(c => !c.IsDeleted == false);
            IList<CustomersCarsMatrix> customersCarsMatrices = await _unitOfWork
                .GetReadRepository<CustomersCarsMatrix>().GetAllAsync(c => !c.IsDeleted == false);

            await _customerRules.CustomerFindPhone(customersList, request.Request);
            Customers customers = _mapper.Map<Customers, AddCustomerReqDto>(request.Request);
            customers.Password = _jwtHelper.HashPassword(request.Request.Password);

            customers.RefreshToken = _jwtHelper.GenerateRefreshToken();
            customers.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(_refreshTokenExpiration);


            await _unitOfWork.GetWriteRepository<Customers>().AddAsync(customers);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }


    }
}
