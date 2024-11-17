using MediatR;

namespace Application.CQRS.Commands.Car.DeleteCar
{
    public class DeleteCarCommand : IRequest<Unit>
    {
        public int CarId { get; set; }
    }
}
