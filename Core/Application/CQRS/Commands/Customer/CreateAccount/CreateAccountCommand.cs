using Application.CQRS.Commands.Customer.AddCustomer.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Customer.CreateAccount
{
    public class CreateAccountCommand : IRequest<Unit>
    {
        public AddCustomerReqDto Request { get; set; }

    }
}

