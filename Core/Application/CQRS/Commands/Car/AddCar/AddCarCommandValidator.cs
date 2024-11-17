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
               .WithName("Model boş ola bilməz");

            RuleFor(x => x.Request.Brand)
                .NotEmpty()
                .NotNull()
                .WithName("Brand boş ola bilməz");

        }
    }
}
