using Application.CQRS.Queries.Parametric.GetServices.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetServices
{
    public sealed class GetServicesQueryHandler : IRequestHandler<GetServicesQuery, IList<GetServicesResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetServicesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetServicesResDto>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.GetReadRepository<Services>().GetAllAsync(model => model.IsDeleted == false);

            return _mapper.Map<GetServicesResDto, Services>(services);
        }
    }
}
