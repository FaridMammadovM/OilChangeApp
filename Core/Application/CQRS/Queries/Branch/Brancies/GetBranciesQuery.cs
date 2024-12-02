using Application.CQRS.Queries.Branch.Brancies.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Branch.Brancies
{
    public class GetBranciesQuery : IRequest<IList<GetBranchResDto>>
    {
    }
}
