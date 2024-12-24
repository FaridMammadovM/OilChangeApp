using Application.Beheviors;
using Application.Interfaces.UnitOfWork;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.CQRS.Commands.Employee.AddEmployee
{
    public sealed class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AddEmployeeCommandHandler(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Unit> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            int userId = OpenToken.FindId(_httpContextAccessor);

            Employees model = new Employees();
            model.Name = request.Request.Name;
            model.Surname = request.Request.Surname;
            model.InsertedBy = userId;
            await _unitOfWork.GetWriteRepository<Employees>().AddAsync(model);
            await _unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}