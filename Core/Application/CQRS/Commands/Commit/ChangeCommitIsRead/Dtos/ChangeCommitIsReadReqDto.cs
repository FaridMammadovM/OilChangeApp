using MediatR;

namespace Application.CQRS.Commands.Commit.ChangeCommitIsRead.Dtos
{
    public class ChangeCommitIsReadReqDto : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
