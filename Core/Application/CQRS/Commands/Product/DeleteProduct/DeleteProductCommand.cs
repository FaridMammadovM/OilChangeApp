using MediatR;

namespace Application.CQRS.Commands.Product.DeleteProduct
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
