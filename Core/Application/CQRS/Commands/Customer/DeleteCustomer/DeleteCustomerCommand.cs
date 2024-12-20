using MediatR;

namespace Application.CQRS.Commands.Customer.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest<Unit>
    {
        public string Phone { get; set; }
    }
}
