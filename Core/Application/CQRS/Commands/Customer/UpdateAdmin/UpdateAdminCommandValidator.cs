using FluentValidation;

namespace Application.CQRS.Commands.Customer.UpdateAdmin
{
    public class UpdateAdminCommandValidator : AbstractValidator<UpdateAdminCommand>
    {
        public UpdateAdminCommandValidator()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

            RuleFor(x => x.Request.Id)
              .NotEmpty()
              .WithMessage("Ad boş ola bilməz.")
              .WithMessage("RequestId boş ola bilməz.");

            RuleFor(x => x.Request.Username)
           .NotEmpty()
           .WithMessage("Username boş ola bilməz.")
           .MaximumLength(50)
           .WithMessage("Username maksimum 50 simvol olmalıdır.");

            RuleFor(x => x.Request.Name)
                .NotEmpty()
                .WithMessage("Ad boş ola bilməz.")
                .MaximumLength(50)
                .WithMessage("Ad maksimum 30 simvol olmalıdır.");

            RuleFor(x => x.Request.Surname)
                .NotEmpty()
                .WithMessage("Soyad boş ola bilməz.")
                .MaximumLength(50)
                .WithMessage("Soyad maksimum 30 simvol olmalıdır.");
        }
    }
}