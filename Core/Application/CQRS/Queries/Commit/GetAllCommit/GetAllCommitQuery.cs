using Application.CQRS.Queries.Commit.GetAllCommit.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Commit.GetAllCommit
{
    public class GetAllCommitQuery : IRequest<IList<GetAllCommitResDto>>
    {
    }
}
