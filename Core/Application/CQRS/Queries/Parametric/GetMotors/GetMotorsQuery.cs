using Application.CQRS.Queries.Parametric.GetMotors.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetMotors
{
    public class GetMotorsQuery : IRequest<IList<GetMotorsResDto>>
    {
    }
}
