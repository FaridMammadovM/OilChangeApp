using Application.CQRS.Queries.Parametric.GetFilters.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetFilters
{
    public class GetFiltersQuery : IRequest<IList<GetFiltersResDto>>
    {
    }
}
