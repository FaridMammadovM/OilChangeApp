using Application.CQRS.Commands.Product.AddProduct.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Product.AddProduct
{
    public class AddProductCommand : IRequest<Unit>
    {
        public AddProductReqDto Request { get; set; }
        public int CategoryId { get; set; }

    }
}
