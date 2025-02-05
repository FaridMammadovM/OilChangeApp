using Application.CQRS.Queries.Parametric.GetDOTs.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetDOTs
{
    public sealed class GetDOTsQueryHandler : IRequestHandler<GetDOTsQuery, IList<GetDOTsResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetDOTsQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetDOTsResDto>> Handle(GetDOTsQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<WinterViscosity>().GetAllAsync(m => m.IsDeleted == false && m.ServiceType == 2);
            return _mapper.Map<GetDOTsResDto, WinterViscosity>(model);
        }
    }
}
