using Domain.Common;

namespace Domain.Entities
{
    public sealed class Colors : EntityBase, IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
