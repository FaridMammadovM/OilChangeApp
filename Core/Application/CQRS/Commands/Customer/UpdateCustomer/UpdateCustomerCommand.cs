using Application.CQRS.Commands.Customer.UpdateCustomer.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<Unit>
    {
        public UpdateCustomerReqDto Request { get; set; }
        public int RoleId { get; set; }

    }
}
