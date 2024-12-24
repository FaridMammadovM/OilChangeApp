using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Car.UpdateCar
{
    public sealed class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UpdateCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            IList<Cars> carList = await _unitOfWork.GetReadRepository<Cars>().GetAllAsync(w => w.IsDeleted == false && w.Id != request.Request.Id);
            await _carRules.CarMustNotBeSame(carList, request.Request.Brand, request.Request.Model);
            var car = await _unitOfWork.GetReadRepository<Cars>().GetAsync(car => car.Id == request.Request.Id && car.IsDeleted == false);
            car.Brand = request.Request.Brand;
            car.Model = request.Request.Model;
            car.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Cars>().UpdateAsync(car);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
