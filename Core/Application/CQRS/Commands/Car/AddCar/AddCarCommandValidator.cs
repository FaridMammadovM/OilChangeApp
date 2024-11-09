using FluentValidation;

namespace Application.CQRS.Commands.Car.AddCar
{
    public class AddCarCommandValidator : AbstractValidator<AddCarCommand>
    {
        public AddCarCommandValidator()
        {
            RuleFor(x => x.Request.Model)
               .NotEmpty()
               .NotNull()
               .WithName("Model hayir");

            RuleFor(x => x.Request.Year)
                .NotNull()
                .GreaterThanOrEqualTo(0)
                 .WithName("Year olmaaaz");

        }
    }
}
