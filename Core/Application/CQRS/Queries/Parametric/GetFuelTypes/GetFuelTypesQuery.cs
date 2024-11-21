using Application.CQRS.Queries.Parametric.GetFuelTypes.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetFuelTypes
{
    public class GetFuelTypesQuery : IRequest<IList<GetFuelTypesResDto>>
    {
    }
}
