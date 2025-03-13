using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Commit.ChangeCommitIsRead
{
    public class ChangeCommitIsReadCommandHandler : IRequestHandler<ChangeCommitIsReadCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChangeCommitIsReadCommandHandler(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(ChangeCommitIsReadCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            var model = await _unitOfWork.GetReadRepository<Commits>().GetAsync(m => m.Id == request.Request.Id && m.IsDeleted == false);
            model.IsRead = true;
            model.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Commits>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
