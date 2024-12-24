using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Product.AddProduct
{
    public sealed class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            IList<Products> modelList = await _unitOfWork.GetReadRepository<Products>().GetAllAsync(w => w.IsDeleted == false);
            await _rules.CheckName(modelList, request.Request.Name);
            Products product = new Products();
            product.Name = request.Request.Name;
            product.InsertedBy = userId;
            await _unitOfWork.GetWriteRepository<Products>().AddAsync(product);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}