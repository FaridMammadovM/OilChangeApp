using Domain.Common;

namespace Domain.Entities
{
    public sealed class Products : EntityBase, IEntityBase
    {
        public string Name { get; set; }
        public string YearOfManufacture { get; set; }
        public string ExpirationDate { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
