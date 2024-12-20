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
            var customersCarsMatrix = await _unitOfWork.GetReadRepository<CustomersCarsMatrix>().GetAllAsync(
        p => p.IsDeleted == false && p.CustomerId == request.CustomerId,
        include: query => query.Include(c => c.OilChanges.Where(o => o.IsDeleted == false))
                                .ThenInclude(o => o.Services)
                                .Include(c => c.Cars));


            var oilChangeDtos = new List<LastOilChangesResDto>();

            foreach (var customerCar in customersCarsMatrix)
            {
                foreach (var oilChange in customerCar.OilChanges)
                {
                    var dto = new LastOilChangesResDto
                    {
                        Id = oilChange.Id,
                        CustomersCarsMatrixId = customerCar.Id,
                        ServiceId = oilChange.ServiceId,
                        ServiceName = oilChange.Services?.Name,
                        ChangeDate = oilChange.ChangeDate.ToString("dd.MM.yyyy"),
                        Model = customerCar.Cars?.Model,
                        Brand = customerCar.Cars?.Brand
                    };

                    oilChangeDtos.Add(dto);
                }
            }

            return oilChangeDtos.OrderByDescending(dto => dto.ChangeDate).Take(5).ToList();
        }
    }
}