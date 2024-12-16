using Application.CQRS.Queries.Parametric.WinterViscosities.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.WinterViscosities
{
    public sealed class GetWinterViscositiesQueryHandler : IRequestHandler<GetWinterViscositiesQuery, IList<WinterViscositiesDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetWinterViscositiesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<WinterViscositiesDto>> Handle(GetWinterViscositiesQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<WinterViscosity>().GetAllAsync(m => m.IsDeleted == false && m.IsBrakeFluidChanged == false);
            return _mapper.Map<WinterViscositiesDto, WinterViscosity>(model);
        }
    }
}
