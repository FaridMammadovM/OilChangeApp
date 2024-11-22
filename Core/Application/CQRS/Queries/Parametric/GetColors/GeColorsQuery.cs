using Application.CQRS.Queries.Parametric.GetColors.Dtos;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetColors
{
    public class GetColorsQuery : IRequest<IList<GetColorsResDto>>
    {
    }
}
