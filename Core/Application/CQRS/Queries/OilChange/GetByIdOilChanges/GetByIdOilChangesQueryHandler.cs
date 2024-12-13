using Application.CQRS.Queries.OilChange.GetAllOilChanges.Dtos;
using Application.CQRS.Queries.OilChange.GetAllOilChanges;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Application.CQRS.Queries.OilChange.GetByIdOilChanges.Dto;
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
            var oilChangesList = await _unitOfWork.GetReadRepository<OilChanges>().GetAsync(
            p => p.IsDeleted == false && p.CustomersCarsMatrixId == request.Id,
            include: query => query.Include(c => c.Services)
            );

            var oilChangesResDtoList = _mapper.Map<GetByIdOilChangesResDto, OilChanges>(oilChangesList);          

            return oilChangesResDtoList;
        }
    }
}