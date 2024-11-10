using Domain.Common;

namespace Domain.Entities
{
    public sealed class Role : EntityBase
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

    }
}
