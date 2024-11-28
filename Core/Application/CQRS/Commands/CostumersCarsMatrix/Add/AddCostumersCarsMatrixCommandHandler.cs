using Application.CQRS.Commands.Car.AddCar;
using Application.CQRS.Commands.CostumersCarsMatrix.Add.Dtos;
using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Add
{
    public sealed class AddCostumersCarsMatrixCommandHandler : IRequestHandler<AddCostumersCarsMatrixCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CostumersCarsMatrixRules _rules;
        private readonly ICostumMapper _mapper;

        public AddCostumersCarsMatrixCommandHandler(IUnitOfWork unitOfWork, CostumersCarsMatrixRules rules, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(AddCostumersCarsMatrixCommand request, CancellationToken cancellationToken)
        {
            IList<CustomersCarsMatrix> list = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync();
            await _rules.MustNotBeSame(list, request.Request);
            CustomersCarsMatrix model = _mapper.Map<CustomersCarsMatrix, AddCostumersCarsMatrixReqDto>(request.Request);

            await _unitOfWork.GetWriteRepository<CustomersCarsMatrix>().AddAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}