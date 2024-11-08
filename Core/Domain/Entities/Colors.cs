using Domain.Common;

namespace Domain.Entities
{
    public sealed class Colors : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Cars> Cars { get; set; }

    }
}
