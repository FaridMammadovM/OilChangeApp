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
            try
            {
                int userId = OpenToken.FindId(_httpContextAccessor);
                /// IList<OilChanges> carList = await _unitOfWork.GetReadRepository<OilChanges>().GetAllAsync();
                // await _carRules.CarMustNotBeSame(carList, request.Request.Brand, request.Request.Model);
                OilChanges oilChanges = _mapper.Map<OilChanges, AddOilChangesReqDto>(request.Request);
                oilChanges.InsertedBy = userId;
                await _unitOfWork.GetWriteRepository<OilChanges>().AddAsync(oilChanges);
                await _unitOfWork.SaveAsync();
                return Unit.Value;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
