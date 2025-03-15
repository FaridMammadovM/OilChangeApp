using Application.CQRS.Queries.OilChange.LastOilChanges.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.OilChange.LastOilChanges
{
    public sealed class LastOilChangesQueryHandler : IRequestHandler<LastOilChangesQuery, IList<LastOilChangesResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public LastOilChangesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<LastOilChangesResDto>> Handle(LastOilChangesQuery request, CancellationToken cancellationToken)
        {
            var customersCarsMatrix = await _unitOfWork.GetReadRepository<Customers>().GetAllAsync(
        p => p.IsDeleted == false && p.Phone == request.Phone,
        include: query => query.Include(c => c.CustomersCars.Where(o => o.IsDeleted == false))
                                .ThenInclude(c => c.OilChanges.Where(o => o.IsDeleted == false))
                                .ThenInclude(o => o.Services)
                                .Include(c => c.CustomersCars).ThenInclude(c => c.Cars));


            var oilChangeDtos = new List<LastOilChangesResDto>();

            oilChangeDtos = customersCarsMatrix
        .SelectMany(customer => customer.CustomersCars.Where(cc => !cc.IsDeleted), (customer, customerCar) => new { customer, customerCar })
        .SelectMany(x => x.customerCar.OilChanges.Where(o => !o.IsDeleted), (x, oilChange) => new LastOilChangesResDto
        {
            Id = oilChange.Id,
            CustomersCarsMatrixId = x.customerCar.Id,
            ServiceId = oilChange.ServiceId,
            ServiceName = oilChange.Services?.Name,
            ChangeDate = oilChange.ChangeDate.ToString("dd.MM.yyyy"),
            Model = x.customerCar.Cars?.Model,
            Brand = x.customerCar.Cars?.Brand,
            CarNumber = x.customerCar.CarNumber,
            ChangeDateAsDateTime = oilChange.ChangeDate
        })
        .OrderByDescending(dto => dto.ChangeDateAsDateTime)
        .Take(5)
        .ToList();

            //foreach (var customerCar in customersCarsMatrix)
            //{
            //    foreach (var oilChange in customerCar.CustomersCars.OilChanges)
            //    {
            //        var dto = new LastOilChangesResDto
            //        {
            //            Id = oilChange.Id,
            //            CustomersCarsMatrixId = customerCar.Id,
            //            ServiceId = oilChange.ServiceId,
            //            ServiceName = oilChange.Services?.Name,
            //            ChangeDate = oilChange.ChangeDate.ToString("dd.MM.yyyy"),
            //            Model = customerCar.Cars?.Model,
            //            Brand = customerCar.Cars?.Brand
            //        };

            //        oilChangeDtos.Add(dto);
            //    }
            //}

            return oilChangeDtos;
        }
    }
}