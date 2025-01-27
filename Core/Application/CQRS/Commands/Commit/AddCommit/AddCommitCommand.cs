using Application.CQRS.Commands.Commit.AddCommit.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Commit.AddCommit
{
    public class AddCommitCommand : IRequest<Unit>
    {
        public AddCommitReqDto Request { get; set; }
    }
}
