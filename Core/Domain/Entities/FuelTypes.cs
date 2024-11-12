using Domain.Common;

namespace Domain.Entities
{
    public sealed class FuelTypes : EntityBase
    {
        public string Name { get; set; }
        public ICollection<CustomersCarsMatrix> UsersCars { get; set; }
    }
}
