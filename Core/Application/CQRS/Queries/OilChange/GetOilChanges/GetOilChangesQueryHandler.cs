using Application.CQRS.Queries.OilChange.GetOilChanges.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.OilChange.GetOilChanges
{
    public sealed class GetOilChangesQueryHandler : IRequestHandler<GetOilChangesQuery, IList<GetOilChangesResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetOilChangesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetOilChangesResDto>> Handle(GetOilChangesQuery request, CancellationToken cancellationToken)
        {

            IList<OilChanges> oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>()
              .GetAllAsync(p => p.IsDeleted == false,
            include: query => query
            .Include(c => c.Services)
            .Include(c => c.Branchies)
            .Include(c => c.CustomersCarsMatrix)
            .ThenInclude(c => c.Customers)
            );


            if (request.Request.ServiceId != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.ServiceId == request.Request.ServiceId).ToList();
            }

            if (request.Request.CarNumber != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.CustomersCarsMatrix.CarNumber == request.Request.CarNumber).ToList();
            }

            if (request.Request.ProductId != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.ProductId == request.Request.ProductId).ToList();
            }

            if (request.Request.BranchId != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.BranchId == request.Request.BranchId).ToList();
            }

            if (request.Request.Name != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.CustomersCarsMatrix.Customers.Name.ToUpper() == request.Request.Name.ToUpper()).ToList();
            }

            if (request.Request.Surname != null && oilChangesList != null)
            {
                oilChangesList = (IList<OilChanges>)oilChangesList.Where(p => p.CustomersCarsMatrix.Customers.Surname.ToUpper() == request.Request.Surname.ToUpper()).ToList();
            }

            var oilChangesResDtoList = _mapper.Map<GetOilChangesResDto, OilChanges>(oilChangesList);

            for (int i = 0; i < oilChangesList.Count; i++)
            {
                oilChangesResDtoList[i].ServiceName = oilChangesList[i].Services.Name;
                oilChangesResDtoList[i].ChangeDate = oilChangesList[i].ChangeDate.ToString("dd.MM.yyyy");
                oilChangesResDtoList[i].CarNumber = oilChangesList[i].CustomersCarsMatrix.CarNumber;
                oilChangesResDtoList[i].BranchName = oilChangesList[i].Branchies.Name;
            }

            return oilChangesResDtoList.OrderByDescending(c => c.Id).ToList();
        }
    }
}