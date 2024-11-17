using Application.CQRS.Commands.Car.UpdateCar.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Car.UpdateCar
{
    public class UpdateCarCommand : IRequest<Unit>
    {
        public UpdateCarReqDto Request { get; set; }
    }
}
