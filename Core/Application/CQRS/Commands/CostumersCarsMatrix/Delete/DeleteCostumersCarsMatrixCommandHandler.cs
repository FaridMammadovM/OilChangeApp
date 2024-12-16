using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Delete
{
    public class DeleteCostumersCarsMatrixCommandHandler : IRequestHandler<DeleteCostumersCarsMatrixCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CostumersCarsMatrixRules _rules;
        public DeleteCostumersCarsMatrixCommandHandler(IUnitOfWork unitOfWork, CostumersCarsMatrixRules rules)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
        }
        public async Task<Unit> Handle(DeleteCostumersCarsMatrixCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<Customers>().GetAsync(c => c.Id == request.Id && c.IsDeleted == false);
            model.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<Customers>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
