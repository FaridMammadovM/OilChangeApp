using Domain.Common;

namespace Domain.Entities
{
    public sealed class Customers : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public ICollection<Commits> Commits { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
        public ICollection<UsersCarsMatrix> UsersCars { get; set; }
        public ICollection<Role> Role { get; set; }
    }
}
