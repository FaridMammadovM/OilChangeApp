using Application.CQRS.Commands.Customers.AddCustomer.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customers.AddCustomer
{
    public class AddCustomerCommand : IRequest<Unit>
    {
        public AddCustomerReqDto Request { get; set; }
    }
}
