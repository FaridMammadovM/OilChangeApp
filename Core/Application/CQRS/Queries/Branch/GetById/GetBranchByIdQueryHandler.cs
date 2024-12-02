using Application.CQRS.Queries.Branch.Brancies.Dtos;
using Application.CQRS.Queries.Branch.GetById.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.CQRS.Queries.Branch.GetById
{
    public sealed class GetBranchByIdQueryHandler : IRequestHandler<GetBranchByIdQuery, GetBranchByIdResDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetBranchByIdQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetBranchByIdResDto> Handle(GetBranchByIdQuery request, CancellationToken cancellationToken)
        {
            var branchies = await _unitOfWork.GetReadRepository<Branchies>()
            .GetAsync(c => c.Id == request.Id, include: query => query.Include(b => b.Phones));

            if (branchies == null)
            {
                return null;
            }

            var branchDto = _mapper.Map<GetBranchByIdResDto, Branchies>(branchies);

            branchDto.Phones = branchies.Phones?.Select(p => p.Phone).ToList() ?? new List<string>();

            return branchDto;
        }
    }
}