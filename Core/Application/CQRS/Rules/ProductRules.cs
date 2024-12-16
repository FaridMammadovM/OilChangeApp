using System.ComponentModel.DataAnnotations;
using Application.Bases;
using Domain.Entities;


namespace Application.CQRS.Rules
{
    public sealed class ProductRules : BaseRules
    {
        public Task CheckName(IList<Products> models, string name)
        {
            if (models.Any(x => x.Name == name))
                throw new ValidationException("Məhsul mövcuddur!");
            return Task.CompletedTask;
        }

    }
}
