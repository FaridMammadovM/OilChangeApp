using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Car.DeleteCar
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DeleteCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            var car = await _unitOfWork.GetReadRepository<Cars>().GetAsync(car => car.Id == request.CarId && car.IsDeleted == false);
            car.IsDeleted = true;
            car.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Cars>().UpdateAsync(car);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
