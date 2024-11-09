using Application.Bases;
using Application.CQRS.Exceptions;
using Domain.Entities;

namespace Application.CQRS.Rules
{
    public class CarRules : BaseRules
    {
        public Task CarMustNotBeSame(IList<Cars> cars, string brand, string model, int? year)
        {
            if (cars.Any(x => x.Brand == brand && x.Model == model && x.Year == year)) throw new CarException();
            return Task.CompletedTask;
        }
    }
}
