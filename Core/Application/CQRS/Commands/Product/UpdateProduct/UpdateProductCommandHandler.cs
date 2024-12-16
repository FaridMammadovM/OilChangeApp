using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Product.UpdateProduct
{
    public sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<Products>().GetAsync(c => c.Id == request.Request.Id && c.IsDeleted == false);
            model.Name = request.Request.Name;

            await _unitOfWork.GetWriteRepository<Products>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
