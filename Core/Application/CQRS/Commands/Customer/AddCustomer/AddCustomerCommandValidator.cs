using FluentValidation;

namespace Application.CQRS.Commands.Customer.AddCustomer
{
    public class AddCustomerCommandValidator : AbstractValidator<AddCustomerCommand>
    {
        public AddCustomerCommandValidator()
        {
            RuleFor(x => x.Request)
               .NotNull()
               .WithMessage("Request boş ola bilməz.");

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


            RuleFor(x => x.Request.RepeatPassword)
                .Equal(x => x.Request.Password)
                .WithMessage("Şifrələr uyğun deyil.");

            RuleFor(x => x.Request.Phone)
                .NotEmpty()
                .WithMessage("Telefon nömrəsi boş ola bilməz.")
                .Matches(@"^\+994(50|51|55|60|70|77|10|99)\d{7}$")
                .WithMessage("Telefon nömrəsi düzgün formatda deyil. Format: +994xxxxxxxxx");

            RuleFor(x => x.Request.RoleId)
                .Must(roleId => roleId == 1 || roleId == 2)
                .WithMessage("RoleId yalnız 1 və ya 2 ola bilər.");

        }
    }
}
