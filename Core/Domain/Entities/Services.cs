using Domain.Common;

namespace Domain.Entities
{
    public sealed class Services : EntityBase
    {
        public string Name { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
