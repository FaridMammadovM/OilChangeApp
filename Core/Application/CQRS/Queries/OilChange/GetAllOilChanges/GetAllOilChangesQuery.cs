using Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos;
using MediatR;

namespace Application.CQRS.Queries.OilChange.GetAllOilChanges
{
    public class GetAllOilChangesQuery : IRequest<IList<GetAllOilChangesResDto>>
    {
        public int CustomersCarsMatrixId { get; set; }

    }
}
