using Application.CQRS.Commands.Commit.ResponseAdmin.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Commit.ResponseAdmin
{
    public class ResponseAdminCommand : IRequest<Unit>
    {
        public ResponseAdminReqDto Request { get; set; }
    }
}