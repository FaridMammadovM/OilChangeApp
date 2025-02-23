using Application.CQRS.Commands.Customer.UpdateAdmin.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.UpdateAdmin
{
    public class UpdateAdminCommand : IRequest<Unit>
    {
        public UpdateAdminReqDto Request { get; set; }
    }
}
