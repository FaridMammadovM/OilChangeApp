using Application.CQRS.Queries.Customer.GetCustomerById.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdResDto>
    {
        public string Phone { get; set; }
    }
}
