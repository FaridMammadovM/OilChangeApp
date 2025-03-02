using FluentValidation;

namespace Application.CQRS.Commands.Customer.UpdateCustomer
{
    public sealed class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

            RuleFor(x => x.Request.Id)
              .NotEmpty()
              .WithMessage("Ad boş ola bilməz.")
              .WithMessage("RequestId boş ola bilməz.");

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


            RuleFor(x => x.Request.Phone)
                .NotEmpty()
                .WithMessage("Telefon nömrəsi boş ola bilməz.")
                .Matches(@"^994(50|51|55|60|70|77|10|99)\d{7}$")
                .WithMessage("Telefon nömrəsi düzgün formatda deyil. Format: 994xxxxxxxxx");

        }
    }
}