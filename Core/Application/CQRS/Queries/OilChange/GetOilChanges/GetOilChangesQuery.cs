using Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos;
using Application.CQRS.Queries.OilChange.GetOilChanges.Dtos;
using MediatR;

namespace Application.CQRS.Queries.OilChange.GetOilChanges
{
    public class GetOilChangesQuery : IRequest<IList<GetOilChangesResDto>>
    {
        public GetOilChangesReqDto Request { get; set; }

    }
}