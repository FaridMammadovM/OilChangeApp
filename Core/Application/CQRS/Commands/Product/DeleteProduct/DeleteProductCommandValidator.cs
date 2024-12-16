using FluentValidation;

namespace Application.CQRS.Commands.Product.DeleteProduct
{
    public sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(x => x.Id)
          .NotEmpty()
          .NotNull()
          .GreaterThanOrEqualTo(0)
          .WithName("Id boş ola bilməz");

        }
    }
}