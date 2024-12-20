using Application.Beheviors;
using Application.CQRS.Commands.OilChange.AddOilChange.Dto;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.OilChange.AddOilChange
{
    public sealed class AddOilChangesCommandHandler : IRequestHandler<AddOilChangesCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OilChangeRules _rules;
        private readonly ICostumMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AddOilChangesCommandHandler(IUnitOfWork unitOfWork, OilChangeRules rules, ICostumMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task<Unit> Handle(AddOilChangesCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            OilChanges oilChanges = _mapper.Map<OilChanges, AddOilChangesReqDto>(request.Request);

            oilChanges.InsertedBy = userId;
            await _unitOfWork.GetWriteRepository<OilChanges>().AddAsync(oilChanges);
            await _unitOfWork.SaveAsync();

            List<OilChangeFiltersMatrix> filters = new List<OilChangeFiltersMatrix>();


            for (int i = 0; i < request.Request.Filters.Count; i++)
            {
                OilChangeFiltersMatrix oilchange = new OilChangeFiltersMatrix();
                oilchange.FiltersId = request.Request.Filters[i].FiltersId;
                oilchange.FilterOwn = request.Request.Filters[i].FilterOwn;
                oilchange.FilterCode = request.Request.Filters[i].FilterCode;
                oilchange.OilChangesId = oilChanges.Id;
                oilchange.InsertedBy = userId;

                filters.Add(oilchange);
            }

            await _unitOfWork.GetWriteRepository<OilChangeFiltersMatrix>().AddRangeAsync(filters);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
