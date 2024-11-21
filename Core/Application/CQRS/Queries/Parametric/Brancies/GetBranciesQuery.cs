using Application.CQRS.Queries.Parametric.Brancies.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.Brancies
{
    public class GetBranciesQuery : IRequest<IList<GetBranchResDto>>
    {
    }
}
