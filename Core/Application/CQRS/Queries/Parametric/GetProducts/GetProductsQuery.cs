using Application.CQRS.Queries.Parametric.GetProducts.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetProducts
{
    public class GetProductsQuery : IRequest<IList<GetProductsResDto>>
    {
        public int CategoryId { get; set; }
    }
}
