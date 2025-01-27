using Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.OilChange.GetAllOilChanges
{
    public sealed class GetAllOilChangesQueryHandler : IRequestHandler<GetAllOilChangesQuery, IList<GetAllOilChangesResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllOilChangesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllOilChangesResDto>> Handle(GetAllOilChangesQuery request, CancellationToken cancellationToken)
        {
            IList<OilChanges> oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>()
              .GetAllAsync(p => p.IsDeleted == false && p.CustomersCarsMatrixId == request.Request.CustomersCarsMatrixId,
            include: query => query.Include(c => c.Services)
            );

            //var oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>().GetAllAsync(
            //p => p.IsDeleted == false && p.CustomersCarsMatrixId == request.Request.CustomersCarsMatrixId,
            //include: query => query.Include(c => c.Services)
            //);

            if (request.Request.ServiceId != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.ServiceId == request.Request.ServiceId).ToList();
            }

            var oilChangesResDtoList = _mapper.Map<GetAllOilChangesResDto, OilChanges>(oilChangesList);

            for (int i = 0; i < oilChangesList.Count; i++)
            {
                oilChangesResDtoList[i].ServiceName = oilChangesList[i].Services.Name;
                oilChangesResDtoList[i].ChangeDate = oilChangesList[i].ChangeDate.ToString("dd.MM.yyyy");
            }

            return oilChangesResDtoList;
        }
    }
}