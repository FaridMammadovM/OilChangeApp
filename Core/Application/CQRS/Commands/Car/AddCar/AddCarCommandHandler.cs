using Application.Beheviors;
using Application.CQRS.Rules;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Car.AddCar
{
    public sealed class AddCarCommandHandler : IRequestHandler<AddCarCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CarRules _carRules;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddCarCommandHandler(IUnitOfWork unitOfWork, CarRules carRules, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _carRules = carRules;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            IList<Cars> carList = await _unitOfWork.GetReadRepository<Cars>().GetAllAsync(w => w.IsDeleted == false);
            await _carRules.CarMustNotBeSame(carList, request.Request.Brand, request.Request.Model);
            Cars cars = new Cars();
            cars.Brand = request.Request.Brand;
            cars.Model = request.Request.Model;
            await _unitOfWork.GetWriteRepository<Cars>().AddAsync(cars);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
