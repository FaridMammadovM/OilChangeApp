using Domain.Common;

namespace Domain.Entities
{
    public class Branchies : EntityBase, IEntityBase
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public ICollection<OilChanges>? OilChanges { get; set; }
    }
}
