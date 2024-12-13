using Application.CQRS.Commands.Customer.ChangePasswordWithAdmin.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.ChangePasswordWithAdmin
{
    public class ChangePasswordWithAdminCommand : IRequest<Unit>
    {
        public ChangePasswordWithAdminReqDto Request { get; set; }
    }
}
