using FluentValidation;

namespace Application.CQRS.Commands.Employee.AddEmployee
{
    public class AddEmployeeCommandValidator : AbstractValidator<AddEmployeeCommand>
    {
        public AddEmployeeCommandValidator()
        {

            RuleFor(x => x.Request.Name)
               .NotEmpty()
               .NotNull()
               .WithName("Name boş ola bilməz");

            RuleFor(x => x.Request.Surname)
                .NotEmpty()
                .NotNull()
                .WithName("Surname boş ola bilməz");

        }
    }
}