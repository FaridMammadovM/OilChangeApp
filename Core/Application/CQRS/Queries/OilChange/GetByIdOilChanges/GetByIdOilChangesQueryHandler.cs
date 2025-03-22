using Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.OilChange.GetByIdOilChanges
{
    public sealed class GetByIdOilChangesQueryHandler : IRequestHandler<GetByIdOilChangesQuery, GetByIdOilChangesResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetByIdOilChangesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetByIdOilChangesResDto> Handle(GetByIdOilChangesQuery request, CancellationToken cancellationToken)
        {
            var oilChange = await _unitOfWork.GetReadRepository<OilChanges>().GetAsync(
            p => p.IsDeleted == false && p.Id == request.OilChangeId,
            include: query => query.Include(c => c.Services)
            .Include(c => c.Branchies)
            .Include(c => c.WinterViscosity)
            .Include(c => c.SAEViscosity)
            .Include(c => c.Products)
            .Include(c => c.CustomersCarsMatrix)
            .Include(c => c.Employees)
            .Include(o => o.OilChangeFilters).ThenInclude(f => f.Filter));

            if (oilChange == null)
            {
                return null;
            }

            var dto = new GetByIdOilChangesResDto
            {
                Id = oilChange.Id,
                CustomersCarsMatrixId = oilChange.CustomersCarsMatrixId,
                ServiceId = oilChange.ServiceId,
                ServiceName = oilChange.Services?.Name,
                ProductId = oilChange.ProductId,
                ProductName = oilChange.Products?.Name,
                SAEViscosityId = oilChange.SAEViscosityId,
                SAEViscosityName = oilChange.SAEViscosity?.Grade,
                WinterViscosityId = oilChange.WinterViscosityId,
                WinterViscosityName = oilChange.WinterViscosity?.Grade,
                Indicator = oilChange.Indicator,
                ChangeDate = oilChange.ChangeDate.ToString("dd.MM.yyyy"),
                KilometersTravelled = oilChange.KilometersTravelled,
                Duration = oilChange.Duration,
                Volume = oilChange.Volume,
                Price = oilChange.Price,
                EmployeeId = oilChange.EmployeeId,
                EmployeeName = oilChange.Employees != null ? $"{oilChange.Employees.Name} {oilChange.Employees.Surname}" : null,
                BranchId = oilChange.BranchId,
                BranchName = oilChange.Branchies?.Name,
                CarNumber = oilChange.CustomersCarsMatrix.CarNumber,
                Description = oilChange.Description,
                Filters = oilChange.OilChangeFilters?.Select(f => new GetByIdOilChangeFilterDto
                {
                    Id = f.Id,
                    FilterId = f.FiltersId,
                    Name = f.Filter.Name,
                    FilterOwn = f.FilterOwn,
                    FilterCode = f.FilterCode
                }).ToList()

            };

            if (dto.ServiceId == 1)
            {
                dto.GeneralName = oilChange.Indicator;
            }
            else if (dto.ServiceId == 2)
            {
                dto.GeneralName = "SAE: " + oilChange.SAEViscosity.Grade + "W" + (int)oilChange.WinterViscosity.Grade;
            }
            else if (dto.ServiceId == 3)
            {
                if (oilChange.WinterViscosity.Id == 16)
                {
                    dto.GeneralName = "G" + oilChange.WinterViscosity.Grade + "+";
                }
                else
                {
                    dto.GeneralName = "G" + oilChange.WinterViscosity.Grade;
                }
            }
            else if (dto.ServiceId == 4)
            {
                dto.GeneralName = "DOT: " + oilChange.WinterViscosity.Grade;
            }
            else if (dto.ServiceId == 5 || dto.ServiceId == 6 || dto.ServiceId == 7)
            {
                dto.GeneralName = "SAE: " + oilChange.Indicator;
            }

            return dto;
        }
    }
}