using Domain.Common;

namespace Domain.Entities
{
    public sealed class SAEViscosity : EntityBase
    {
        public int Grade { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
