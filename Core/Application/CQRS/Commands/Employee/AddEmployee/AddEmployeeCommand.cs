using Application.CQRS.Commands.Employee.AddEmployee.Dtos;
using MediatR;

namespace Application.CQRS.Commands.Employee.AddEmployee
{
    public class AddEmployeeCommand : IRequest<Unit>
    {
        public AddEmployeeDto Request { get; set; }
    }
}
