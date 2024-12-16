using Application.CQRS.Queries.Parametric.GetSAEViscosities.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetSAEViscosities
{
    public class GetSAEViscositiesQuery : IRequest<IList<GetSAEViscositiesDto>>
    {
    }
}
