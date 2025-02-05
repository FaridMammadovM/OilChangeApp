using Application.CQRS.Queries.Parametric.GetDOTs.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetDOTs
{
    public class GetDOTsQuery : IRequest<IList<GetDOTsResDto>>
    {
    }
}
