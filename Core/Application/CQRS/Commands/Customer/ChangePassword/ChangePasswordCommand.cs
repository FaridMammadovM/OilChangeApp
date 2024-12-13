using Application.CQRS.Commands.Customer.ChangePassword.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.ChangePassword
{
    public class ChangePasswordCommand : IRequest<Unit>
    {
        public ChangePasswordReqDto Request { get; set; }
    }
}
