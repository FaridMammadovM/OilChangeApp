using Application.CQRS.Queries.Parametric.GetSAEViscosities.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetSAEViscosities
{
    public sealed class GetSAEViscositiesQueryHandler : IRequestHandler<GetSAEViscositiesQuery, IList<GetSAEViscositiesDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetSAEViscositiesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetSAEViscositiesDto>> Handle(GetSAEViscositiesQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<SAEViscosity>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetSAEViscositiesDto, SAEViscosity>(model);
        }
    }
}

