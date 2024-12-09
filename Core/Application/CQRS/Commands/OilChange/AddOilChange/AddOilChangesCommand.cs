using Application.CQRS.Commands.OilChange.AddOilChange.Dto;
using MediatR;

namespace Application.CQRS.Commands.OilChange.AddOilChange
{
    public class AddOilChangesCommand : IRequest<Unit>
    {
        public AddOilChangesReqDto Request { get; set; }
    }
}
