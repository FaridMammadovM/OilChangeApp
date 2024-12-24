using FluentValidation;

namespace Application.CQRS.Commands.Employee.DeleteEmployee
{
    public class DeleteEmployeeCommandValidator : AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeCommandValidator()
        {
            RuleFor(x => x.Id)
              .NotEmpty()
              .NotNull()
              .GreaterThanOrEqualTo(0)
              .WithName("Id boş ola bilməz");

        }
    }
}