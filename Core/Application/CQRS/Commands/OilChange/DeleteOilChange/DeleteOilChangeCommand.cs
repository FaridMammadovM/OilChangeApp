using MediatR;

namespace Application.CQRS.Commands.OilChange.DeleteOilChange
{
    public class DeleteOilChangeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
