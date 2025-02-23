using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Application.CQRS.Commands.Commit.ResponseAdmin
{
    public sealed class ResponseAdminCommandHandler : IRequestHandler<ResponseAdminCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ResponseAdminCommandHandler(IUnitOfWork unitOfWork, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(ResponseAdminCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            Commits commit = new Commits
            {
                CustomerId = request.Request.CustomerId,
                CommitMessage = request.Request.CommitMessage,
                InsertedBy = userId,
                IsRequest = true
            };

            await _unitOfWork.GetWriteRepository<Commits>().AddAsync(commit);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}