using Application.CQRS.Commands.Car.AddCar.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Car.AddCar
{
    public class AddCarCommand : IRequest<Unit>
    {
        public AddCarReqDto Request { get; set; }
    }
}
