using Application.CQRS.Commands.Employee.UpdateEmployee.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Employee.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public UpdateEmployeeDto Request { get; set; }
    }
}
