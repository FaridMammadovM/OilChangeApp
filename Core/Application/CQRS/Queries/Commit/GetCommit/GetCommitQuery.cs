using Application.CQRS.Queries.Car.GetAll.Dtos;
using Application.CQRS.Queries.Commit.GetCommit.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Commit.GetCommit
{
    public class GetCommitQuery : IRequest<IList<GetCommitQueryResDto>>
    {
        public GetCommitQueryReqDto Request { get; set; }
    }
}
