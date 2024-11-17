using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Commands.Car.UpdateCar
{
    public sealed class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        public UpdateCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
        }
        public async Task<Unit> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Cars>().GetAsync(car => car.Id == request.Request.Id && car.IsDeleted == false);
            car.Brand = request.Request.Brand;
            car.Model = request.Request.Model;
            await _unitOfWork.GetWriteRepository<Cars>().UpdateAsync(car);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
