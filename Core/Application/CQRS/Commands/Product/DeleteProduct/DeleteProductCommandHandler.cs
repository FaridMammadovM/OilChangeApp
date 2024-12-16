using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Product.DeleteProduct
{
    public sealed class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;
        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<Products>().GetAsync(c => c.Id == request.Id && c.IsDeleted == false);
            model.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<Products>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
