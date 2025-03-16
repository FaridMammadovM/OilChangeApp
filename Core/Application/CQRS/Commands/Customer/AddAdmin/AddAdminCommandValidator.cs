using FluentValidation;

namespace Application.CQRS.Commands.Customer.AddAdmin
{
    public class AddAdminCommandValidator : AbstractValidator<AddAdminCommand>
    {
        public AddAdminCommandValidator()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

            RuleFor(x => x.Request.Name)
                .NotEmpty()
                .WithMessage("Ad boş ola bilməz.")
                .MaximumLength(50)
                .WithMessage("Ad maksimum 50 simvol olmalıdır.");

            RuleFor(x => x.Request.Username)
              .NotEmpty()
              .WithMessage("Username boş ola bilməz.")
              .MaximumLength(50)
              .WithMessage("Username maksimum 50 simvol olmalıdır.");

            RuleFor(x => x.Request.Surname)
                .NotEmpty()
                .WithMessage("Soyad boş ola bilməz.")
                .MaximumLength(50)
                .WithMessage("Soyad maksimum 50 simvol olmalıdır.");

            RuleFor(x => x.Request.Password)
                .NotEmpty()
                .WithMessage("Şifrə boş ola bilməz.")
                .MinimumLength(8)
                .WithMessage("Şifrə ən az 8 simvol olmalıdır.")
                .Matches(@"[A-Z]")
                .WithMessage("Şifrə ən az bir böyük hərf içərməlidir.")
                .Matches(@"[a-z]")
                .WithMessage("Şifrə ən az bir kiçik hərf içərməlidir.")
                .Matches(@"\d")
                .WithMessage("Şifrə ən az bir rəqəm içərməlidir.")
                .Matches(@"[\W_]")
                .WithMessage("Şifrə ən az bir xüsusi simvol içərməlidir.");
        }
    }
}
