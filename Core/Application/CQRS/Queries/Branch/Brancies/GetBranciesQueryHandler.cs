using Application.CQRS.Queries.Branch.Brancies.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Branch.Brancies
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
