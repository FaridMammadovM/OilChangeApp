using Application.CQRS.Queries.Commit.GetAllCommit.Dtos;
using Application.Interfaces.AutoMapper;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
            var commitList = await _unitOfWork.GetReadRepository<Commits>().GetAllAsync(c => c.IsDeleted == false,
                   include: query => query
            .Include(c => c.Customers)        
            );

            var mappedList = commitList.Select(c => new GetAllCommitResDto
            {
                CommitMessage = c.CommitMessage,
                CustomerId = c.CustomerId,
                Name = c.Customers?.Name,
                Surname = c.Customers?.Surname,
                Phone = c.Customers?.Phone,
                IsRequest = c.IsRequest,
                InsertedDate = c.InsertedDate
            }).OrderByDescending(c => c.InsertedDate).ToList();

            return mappedList;
        }
    }
}
