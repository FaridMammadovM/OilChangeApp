using Application.CQRS.Queries.Car.GetByİd.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Car.GetByİd
{
    public class GeByIdCarQueryHandler : IRequestHandler<GeByIdCarQuery, GeByIdCarDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GeByIdCarQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GeByIdCarDto> Handle(GeByIdCarQuery request, CancellationToken cancellationToken)
        {
            var car = await _unitOfWork.GetReadRepository<Cars>().GetAsync(car => car.Id == request.CarId && car.IsDeleted == false);
            return _mapper.Map<GeByIdCarDto, Cars>(car);
        }
    }
}
