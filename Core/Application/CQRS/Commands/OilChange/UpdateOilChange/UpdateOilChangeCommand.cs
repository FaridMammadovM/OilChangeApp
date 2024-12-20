using Application.CQRS.Commands.OilChange.UpdateOilChange.Dtos;
using MediatR;

namespace Application.CQRS.Commands.OilChange.UpdateOilChange
{
    public class UpdateOilChangeCommand : IRequest<Unit>
    {
        public UpdateOilChangeReqDto Request { get; set; }

    }
}
