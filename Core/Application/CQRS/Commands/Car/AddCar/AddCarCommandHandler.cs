using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Car.AddCar
{
    public sealed class AddCarCommandHandler : IRequestHandler<AddCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddCarCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {

            Cars cars = new Cars();
            cars.Brand = request.Request.Brand;
            cars.Model = request.Request.Model;
            cars.Year = request.Request.Year;
            cars.ColorId = request.Request.ColorId;
            cars.FuelTypeId = request.Request.FuelTypeId;
            await _unitOfWork.GetWriteRepository<Cars>().AddAsync(cars);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
