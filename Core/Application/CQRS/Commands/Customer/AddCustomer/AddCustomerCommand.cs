using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.AddCustomer
{
    public class AddCustomerCommand : IRequest<Unit>
    {
        public AddCustomerReqDto Request { get; set; }
    }
}
