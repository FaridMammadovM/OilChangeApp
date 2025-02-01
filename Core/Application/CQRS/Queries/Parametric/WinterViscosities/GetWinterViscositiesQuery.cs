using Application.CQRS.Queries.Parametric.WinterViscosities.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.WinterViscosities
{
    public class GetWinterViscositiesQuery : IRequest<IList<WinterViscositiesDto>>
    {
        public int ServiceType { get; set; }
    }
}
