using Application.Beheviors;
using Application.CQRS.Commands.OilChange.UpdateOilChange.Dtos;
using Application.CQRS.Rules;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.OilChange.UpdateOilChange
{
    public class UpdateOilChangeCommandHandler : IRequestHandler<UpdateOilChangeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OilChangeRules _rules;
        private readonly ICostumMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UpdateOilChangeCommandHandler(IUnitOfWork unitOfWork, OilChangeRules rules, ICostumMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _rules = rules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task<Unit> Handle(UpdateOilChangeCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);
            OilChanges oilChange = await _unitOfWork.GetReadRepository<OilChanges>().GetAsync(c => c.Id == request.Request.Id);

            oilChange = _mapper.Map<OilChanges, UpdateOilChangeReqDto>(request.Request);

            oilChange.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<OilChanges>().UpdateAsync(oilChange);
            await _unitOfWork.SaveAsync();

            if (request.Request.Filters != null)
            {
                foreach (var filterDto in request.Request.Filters)
                {
                    var existingFilter = await _unitOfWork.GetReadRepository<OilChangeFiltersMatrix>().GetAsync(c => c.Id == filterDto.Id);

                    if (existingFilter != null)
                    {
                        existingFilter.FiltersId = filterDto.FilterId;
                        existingFilter.FilterOwn = filterDto.FilterOwn;
                        existingFilter.FilterCode = filterDto.FilterCode;
                        existingFilter.UpdatedBy = userId;

                        await _unitOfWork.GetWriteRepository<OilChangeFiltersMatrix>().UpdateAsync(existingFilter);
                    }
                    else
                    {
                        OilChangeFiltersMatrix newFilter = new OilChangeFiltersMatrix
                        {
                            FiltersId = filterDto.FilterId,
                            FilterOwn = filterDto.FilterOwn,
                            FilterCode = filterDto.FilterCode,
                            OilChangesId = oilChange.Id,
                            InsertedBy = userId
                        };

                        await _unitOfWork.GetWriteRepository<OilChangeFiltersMatrix>().AddAsync(newFilter);
                    }
                }
            }

            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
