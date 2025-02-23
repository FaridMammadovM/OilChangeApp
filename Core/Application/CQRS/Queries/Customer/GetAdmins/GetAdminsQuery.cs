using Application.CQRS.Queries.Customer.GetAdmins.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Customer.GetAdmins
{
    public class GetAdminsQuery : IRequest<IList<GetAdminsResDto>>
    {
    }
}
