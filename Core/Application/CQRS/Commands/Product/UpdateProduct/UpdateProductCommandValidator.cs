using FluentValidation;

namespace Application.CQRS.Commands.Product.UpdateProduct
{
    public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Request.Id)
              .NotEmpty()
              .NotNull()
              .GreaterThanOrEqualTo(0)
              .WithName("Id boş ola bilməz");


            RuleFor(x => x.Request.Name)
               .NotEmpty()
               .NotNull()
               .WithName("Name boş ola bilməz");

        }
    }
}