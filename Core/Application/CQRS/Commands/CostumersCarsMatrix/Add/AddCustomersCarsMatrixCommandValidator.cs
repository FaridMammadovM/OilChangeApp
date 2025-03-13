using FluentValidation;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Add
{
    public sealed class AddCostumersCarsMatrixCommandValidator : AbstractValidator<AddCostumersCarsMatrixCommand>
    {
        public AddCostumersCarsMatrixCommandValidator()
        {
            RuleFor(x => x.Request.CarNumber)
                .NotEmpty().WithMessage("CarNumber is required.")
                .Matches(@"^\d{2}-[A-Z]{2}-\d{3}$")
                .WithMessage("CarNumber must be in the format '11-XX-111'. Example: '10-HH-001'.");


            RuleFor(x => x.Request.CarId)
                .GreaterThan(0).WithMessage("CarId must be greater than 0.");

            RuleFor(x => x.Request.CustomerId)
                .GreaterThan(0).WithMessage("CustomerId must be greater than 0.");
        }
    }
}