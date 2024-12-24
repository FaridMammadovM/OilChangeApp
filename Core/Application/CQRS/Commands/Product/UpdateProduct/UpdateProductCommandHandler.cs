using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Product.UpdateProduct
{
    public sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _rules;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules rules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            var model = await _unitOfWork.GetReadRepository<Products>().GetAsync(c => c.Id == request.Request.Id && c.IsDeleted == false);
            model.Name = request.Request.Name;
            model.UpdatedBy = userId;

            await _unitOfWork.GetWriteRepository<Products>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
