using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Car.DeleteCar
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        public DeleteCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
        }
        public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Cars>().GetAsync(car => car.Id == request.CarId && car.IsDeleted == false);
            car.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<Cars>().UpdateAsync(car);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
