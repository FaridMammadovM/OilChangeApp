using Application.CQRS.Commands.Commit.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Commit
{
    public class AddCommitCommand : IRequest<Unit>
    {
        public AddCommitReqDto Request { get; set; }
    }
}
