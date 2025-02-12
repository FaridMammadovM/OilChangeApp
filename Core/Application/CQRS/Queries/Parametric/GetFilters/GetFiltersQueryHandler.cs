using Application.CQRS.Queries.Parametric.GetFilters.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetFilters
{
    public sealed class GetFiltersQueryHandler : IRequestHandler<GetFiltersQuery, IList<GetFiltersResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetFiltersQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetFiltersResDto>> Handle(GetFiltersQuery request, CancellationToken cancellationToken)
        {
            var filters = await _unitOfWork.GetReadRepository<Filters>().GetAllAsync(c => c.IsDeleted == false);
            return _mapper.Map<GetFiltersResDto, Filters>(filters);
        }
    }
}
