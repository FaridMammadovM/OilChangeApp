using FluentValidation;

namespace Application.CQRS.Commands.CostumersCarsMatrix.Update
{
    public sealed class UpdateCustomersCarsMatrixCommandValidator : AbstractValidator<UpdateCustomersCarsMatrixCommand>
    {
        public UpdateCustomersCarsMatrixCommandValidator()
        {
            RuleFor(x => x.Request.Id)
          .NotEmpty()
          .NotNull()
          .GreaterThanOrEqualTo(0)
          .WithName("Id boş ola bilməz");

            RuleFor(x => x.Request.CarNumber)
                .NotEmpty().WithMessage("CarNumber is required.")
                .Matches(@"^\d{2}-[A-Z]{2}-\d{3}$")
                .WithMessage("CarNumber must be in the format '11-XX-111'. Example: '10-HH-001'.");


            RuleFor(x => x.Request.CarId)
                .GreaterThan(0).WithMessage("CarId must be greater than 0.");

            RuleFor(x => x.Request.CustomerId)
                .GreaterThan(0).WithMessage("CustomerId must be greater than 0.");

            RuleFor(x => x.Request.MotorId)
                .GreaterThan(0).WithMessage("Motor value must be greater than 0.");

            RuleFor(x => x.Request.Year)
                .InclusiveBetween(1886, DateTime.Now.Year)
                .WithMessage($"Year must be between 1886 and {DateTime.Now.Year}.");

            RuleFor(x => x.Request.ColorsId)
                .GreaterThan(0).WithMessage("ColorsId must be greater than 0.")
                .When(x => x.Request.ColorsId.HasValue);

            RuleFor(x => x.Request.FuelTypeId)
                .GreaterThan(0).WithMessage("FuelTypeId must be greater than 0.");
        }
    }
}