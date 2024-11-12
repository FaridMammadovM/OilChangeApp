using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Customers.AddCustomer
{
    public sealed class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomerRules _customerRules;
        public AddCustomerCommandHandler(IUnitOfWork unitOfWork, CustomerRules customerRules)
        {
            _unitOfWork = unitOfWork;
            _customerRules = customerRules;
        }
        public async Task<Unit> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            //IList<Customers> carList = await _unitOfWork.GetReadRepository<Customers>().GetAllAsync();
            //carRules.CarMustNotBeSame(carList, request.Request.Brand, request.Request.Model);
            Cars cars = new Cars();

            await _unitOfWork.GetWriteRepository<Cars>().AddAsync(cars);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
