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
            .Include(c => c.Employees)
            .Include(o => o.OilChangeFilters).ThenInclude(f => f.Filter));
     
            var dto = new GetByIdOilChangesResDto
            {
                Id = oilChange.Id,
                CustomersCarsMatrixId = oilChange.CustomersCarsMatrixId,
                ServiceId = oilChange.ServiceId,
                ServiceName = oilChange.Services?.Name,
                ProductName = oilChange.Products?.Name,
                ChangeDate = oilChange.ChangeDate.ToString("dd.MM.yyyy"),
                KilometersTravelled = oilChange.KilometersTravelled,
                Duration = oilChange.Duration,
                OilVolume = oilChange.OilVolume,
                SAEViscosity = oilChange.SAEViscosity.Grade,
                WinterViscosity = oilChange.WinterViscosity.Grade,
                Price = oilChange.Price,
                EmployeeName = oilChange.Employees != null ? $"{oilChange.Employees.Name} {oilChange.Employees.Surname}" : null,
                BranchName = oilChange.Branchies?.Name,
                Description = oilChange.Description,
                Filters = oilChange.OilChangeFilters?.Select(f => new GetByIdOilChangeFilterDto
                {
                    Id = f.Filter.Id,
                    Name = f.Filter.Name
                }).ToList()

            };
            return dto;
        }
    }
}