using FluentValidation;

namespace Application.CQRS.Commands.Product.AddProduct
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(x => x.Request.Name)
               .NotEmpty()
               .NotNull()
               .WithName("Name boş ola bilməz");

        }
    }
}