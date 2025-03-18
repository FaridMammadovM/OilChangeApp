using Application.CQRS.Queries.Parametric.GetG.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Parametric.GetG
{
    public class GetGQueryHandler : IRequestHandler<GetGQuery, IList<GetGResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetGQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetGResDto>> Handle(GetGQuery request, CancellationToken cancellationToken)
        {
            var model = await _unitOfWork.GetReadRepository<WinterViscosity>().GetAllAsync(m => m.IsDeleted == false && m.ServiceType == 3);

            var result = _mapper.Map<GetGResDto, WinterViscosity>(model);

            result[0].Grade = "G11";
            result[1].Grade = "G12";
            result[2].Grade = "G12+";
            result[3].Grade = "G13";
            return result;
        }
    }
}
