﻿using Application.CQRS.Queries.Car.GetAll.Dtos;
using Application.CQRS.Queries.Car.GetAll;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Application.CQRS.Queries.Parametric.Brancies.Dtos;

namespace Application.CQRS.Queries.Parametric.Brancies
{
    public sealed class GetBranciesQueryHandler : IRequestHandler<GetBranciesQuery, IList<GetBranchResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetBranciesQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetBranchResDto>> Handle(GetBranciesQuery request, CancellationToken cancellationToken)
        {
            var branchies = await _unitOfWork.GetReadRepository<Branchies>().GetAllAsync(car => car.IsDeleted == false);
            return _mapper.Map<GetBranchResDto, Branchies>(branchies);
        }
    }
}
