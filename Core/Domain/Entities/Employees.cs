using Domain.Common;

namespace Domain.Entities
{
    public sealed class Employees : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Description { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
