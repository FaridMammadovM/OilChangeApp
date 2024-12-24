using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Product.DeleteProduct
{
    public sealed class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            var model = await _unitOfWork.GetReadRepository<Products>().GetAsync(c => c.Id == request.Id && c.IsDeleted == false);
            model.IsDeleted = true;
            model.UpdatedBy = request.Id;
            await _unitOfWork.GetWriteRepository<Products>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
