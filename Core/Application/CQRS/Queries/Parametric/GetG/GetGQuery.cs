using Application.CQRS.Queries.Parametric.GetG.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetG
{
    public class GetGQuery : IRequest<IList<GetGResDto>>
    {
    }
}
