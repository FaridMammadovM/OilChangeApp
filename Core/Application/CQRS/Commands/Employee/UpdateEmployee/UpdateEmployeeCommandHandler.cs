using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Employee.UpdateEmployee
{
    public sealed class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UpdateEmployeeCommandHandler(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);
            var model = await _unitOfWork.GetReadRepository<Employees>().GetAsync(car => car.Id == request.Request.Id && car.IsDeleted == false);
            model.Name = request.Request.Name;
            model.Surname = request.Request.Surname;
            model.UpdatedBy = userId;
            await _unitOfWork.GetWriteRepository<Employees>().UpdateAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}