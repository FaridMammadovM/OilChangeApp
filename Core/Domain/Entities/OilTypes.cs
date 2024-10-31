using Domain.Common;

namespace Domain.Entities
{
    public sealed class OilTypes : EntityBase, IEntityBase
    {
        public string Name { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
