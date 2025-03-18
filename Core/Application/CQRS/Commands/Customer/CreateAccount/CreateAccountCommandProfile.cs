using FluentValidation;

namespace Application.CQRS.Commands.Customer.CreateAccount
{
    public class CreateAccountCommandProfile : AbstractValidator<CreateAccountCommand>
    {
        public CreateAccountCommandProfile()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

            RuleFor(x => x.Request.Name)
                .NotEmpty()
                .WithMessage("Ad boş ola bilməz.")
                .MaximumLength(50)
                .WithMessage("Ad maksimum 50 simvol olmalıdır.");

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


            RuleFor(x => x.Request.Phone)
                .NotEmpty()
                .WithMessage("Telefon nömrəsi boş ola bilməz.")
                .Matches(@"^994(50|51|55|60|70|77|10|99)\d{7}$")
                .WithMessage("Telefon nömrəsi düzgün formatda deyil. Format: 994xxxxxxxxx");

        }
    }
}