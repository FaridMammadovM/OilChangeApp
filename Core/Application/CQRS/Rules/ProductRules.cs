using Application.Bases;
using Application.CQRS.Exceptions;
using Domain.Entities;


namespace Application.CQRS.Rules
{
    public sealed class ProductRules : BaseRules
    {
        public Task CheckName(IList<Products> models, string name)
        {
            if (models.Any(x => x.Name == name))
                throw new ProductException();
            return Task.CompletedTask;
        }

    }
}
