using MediatR;

namespace Application.CQRS.Commands.Employee.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
