using Application.CQRS.Queries.Commit.GetCommit.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;

namespace Application.CQRS.Queries.Commit.GetCommit
{
    public sealed class GetCommitQueryHandler : IRequestHandler<GetCommitQuery, IList<GetCommitQueryResDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICostumMapper _mapper;

        public GetCommitQueryHandler(IUnitOfWork unitOfWork, ICostumMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<GetCommitQueryResDto>> Handle(GetCommitQuery request, CancellationToken cancellationToken)
        {
            var cars = await _unitOfWork.GetReadRepository<Commits>().GetAllAsync(c => c.IsDeleted == false && c.CustomerId == request.Request.CustomerId);
            return _mapper.Map<GetCommitQueryResDto, Commits>(cars);
        }
    }
}
