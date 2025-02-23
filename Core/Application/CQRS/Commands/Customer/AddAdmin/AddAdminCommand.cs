using Application.CQRS.Commands.Customer.AddAdmin.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.AddAdmin
{
    public class AddAdminCommand : IRequest<Unit>
    {
        public AddAdminReqDto Request { get; set; }
    }
}
