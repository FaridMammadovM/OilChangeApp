using Domain.Common;

namespace Domain.Entities
{
    public sealed class Products : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
