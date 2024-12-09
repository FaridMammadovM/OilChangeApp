using Application.CQRS.Queries.Parametric.GetServices.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetServices
{
    public class GetServicesQuery : IRequest<IList<GetServicesResDto>>
    {
    }
}
