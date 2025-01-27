using Application.CQRS.Queries.Commit.GetAllCommit.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Commit.GetAllCommit
{
    public sealed class GetAllCommitQueryHandler : IRequestHandler<GetAllCommitQuery, IList<GetAllCommitResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetAllCommitQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetAllCommitResDto>> Handle(GetAllCommitQuery request, CancellationToken cancellationToken)
        {
            var commitList = await _unitOfWork.GetReadRepository<Commits>().GetAllAsync(c => c.IsDeleted == false);
            var groupedCommits = commitList
       .GroupBy(c => c.CustumerId)
       .Select(group => group.OrderByDescending(c => c.InsertedDate).First())
       .ToList();

            return _mapper.Map<GetAllCommitResDto, Commits>(groupedCommits);
        }
    }
}
