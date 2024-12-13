using Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto;
using MediatR;

namespace Application.CQRS.Queries.OilChange.GetByIdOilChanges
{
    public class GetByIdOilChangesQuery : IRequest<GetByIdOilChangesResDto>
    {
        public int Id { get; set; }
    }
}
