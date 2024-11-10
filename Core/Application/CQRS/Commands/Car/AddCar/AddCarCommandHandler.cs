using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Car.AddCar
{
    public sealed class AddCarCommandHandler : IRequestHandler<AddCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        public AddCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
        }
        public async Task<Unit> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            IList<Cars> carList = await _unitOfWork.GetReadRepository<Cars>().GetAllAsync();
            _carRules.CarMustNotBeSame(carList, request.Request.Brand, request.Request.Model);
            Cars cars = new Cars();
            cars.Brand = request.Request.Brand;
            cars.Model = request.Request.Model;
            await _unitOfWork.GetWriteRepository<Cars>().AddAsync(cars);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
