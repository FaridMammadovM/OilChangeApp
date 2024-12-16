using Application.CQRS.Commands.Product.UpdateProduct.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Product.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public UpdateProductReqDto Request { get; set; }
    }
}
