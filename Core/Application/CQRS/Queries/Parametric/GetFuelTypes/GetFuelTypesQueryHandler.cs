using Application.CQRS.Queries.Parametric.GetFuelTypes.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetFuelTypes
{
    public sealed class GetFuelTypesQueryHandler : IRequestHandler<GetFuelTypesQuery, IList<GetFuelTypesResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetFuelTypesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetFuelTypesResDto>> Handle(GetFuelTypesQuery request, CancellationToken cancellationToken)
        {
            var fuelTypes = await _unitOfWork.GetReadRepository<FuelTypes>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetFuelTypesResDto, FuelTypes>(fuelTypes);
        }
    }
}

