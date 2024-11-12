using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Customer.AddCustomer
{
    public sealed class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerRules _customerRules;
        private readonly ICostumMapper _mapper;
        public AddCustomerCommandHandler(ICostumMapper mapper, IUnitOfWork unitOfWork, CustomerRules customerRules)
        {
            _unitOfWork = unitOfWork;
            _customerRules = customerRules;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            IList<Customers> customersList = await _unitOfWork.GetReadRepository<Customers>().GetAllAsync(c => !c.IsDeleted == false);
            IList<CustomersCarsMatrix> customersCarsMatrices = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync(c => !c.IsDeleted == false);

            await _customerRules.CustomerFindPhone(customersList, request.Request);
            Customers customers = _mapper.Map<Customers, AddCustomerReqDto>(request.Request);
            customers.Password = HashPassword(request.Request.Password);
            await _unitOfWork.GetWriteRepository<Customers>().AddAsync(customers);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
