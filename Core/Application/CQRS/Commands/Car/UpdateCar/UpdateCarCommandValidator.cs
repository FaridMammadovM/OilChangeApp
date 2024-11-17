using FluentValidation;

namespace Application.CQRS.Commands.Car.UpdateCar
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator()
        {
            RuleFor(x => x.Request.Id)
              .NotEmpty()
              .NotNull()
              .GreaterThanOrEqualTo(0)
              .WithName("Id boş ola bilməz");

            RuleFor(x => x.Request.Model)
               .NotEmpty()
               .NotNull()
               .WithName("Model boş ola bilməz");

            RuleFor(x => x.Request.Brand)
                .NotEmpty()
                .NotNull()
                .WithName("Brand boş ola bilməz");

        }
    }
}
