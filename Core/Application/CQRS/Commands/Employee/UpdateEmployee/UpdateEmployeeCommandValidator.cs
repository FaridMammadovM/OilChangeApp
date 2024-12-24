using FluentValidation;

namespace Application.CQRS.Commands.Employee.UpdateEmployee
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(x => x.Request.Id)
              .NotEmpty()
              .NotNull()
              .GreaterThanOrEqualTo(0)
              .WithName("Id boş ola bilməz");

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