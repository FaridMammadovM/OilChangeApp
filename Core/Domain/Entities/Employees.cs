using Domain.Common;

namespace Domain.Entities
{
    public sealed class Employees : EntityBase, IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
    }
}
