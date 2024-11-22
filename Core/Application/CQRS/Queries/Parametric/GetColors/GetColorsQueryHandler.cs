using Application.CQRS.Queries.Parametric.GetFuelTypes.Dtos;
using Application.CQRS.Queries.Parametric.GetFuelTypes;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Application.CQRS.Queries.Parametric.GetColors.Dtos;

namespace Application.CQRS.Queries.Parametric.GetColors
{
    public sealed class GetColorsQueryHandler : IRequestHandler<GetColorsQuery, IList<GetColorsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetColorsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetColorsResDto>> Handle(GetColorsQuery request, CancellationToken cancellationToken)
        {
            var colors = await _unitOfWork.GetReadRepository<Colors>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetColorsResDto, Colors>(colors);
        }
    }
}