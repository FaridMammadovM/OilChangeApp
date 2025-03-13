using Application.CQRS.Queries.Car.GetAll.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Car.GetAll
{
    public sealed class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IList<GetAllCarsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllCarsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllCarsResDto>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _unitOfWork.GetReadRepository<Cars>().GetAllAsync(car => car.IsDeleted == false);

            if (request.Request.BrandOrModel != null && cars != null)
            {
                cars = cars
                  .Where(p => (p.Brand + " " + p.Model).ToLower().Contains(request.Request.BrandOrModel.ToLower()))
                  .ToList();
            }
            var carsList = _mapper.Map<GetAllCarsResDto, Cars>(cars);

            return carsList
      .OrderBy(c => c.Brand)
      .ThenBy(c => c.Model)
      .ToList();
        }
    }
}
