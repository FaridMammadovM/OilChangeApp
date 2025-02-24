using Application.CQRS.Queries.Customer.GetAdminById.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetAdminById
{
    public class GetAdminByIdQuery : IRequest<GetAdminByIdResDto>
    {
        public string Username { get; set; }
    }
}