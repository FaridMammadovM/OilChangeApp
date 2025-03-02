using Application.CQRS.Commands.Commit.ChangeCommitIsRead.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Commit.ChangeCommitIsRead
{
    public class ChangeCommitIsReadCommand : IRequest<Unit>
    {
        public ChangeCommitIsReadReqDto Request { get; set; }
    }
}
