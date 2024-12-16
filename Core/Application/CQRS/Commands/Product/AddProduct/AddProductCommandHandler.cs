using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Product.AddProduct
{
    public sealed class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;
        public AddProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            IList<Products> modelList = await _unitOfWork.GetReadRepository<Products>().GetAllAsync(w => w.IsDeleted == false);
            await _rules.CheckName(modelList, request.Request.Name);
            Products product = new Products();
            product.Name = request.Request.Name;
            await _unitOfWork.GetWriteRepository<Products>().AddAsync(product);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}