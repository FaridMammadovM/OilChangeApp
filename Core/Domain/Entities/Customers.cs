using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public sealed class Customers : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<Commits> Commits { get; set; }
        public ICollection<OilChanges> OilChanges { get; set; }
        public ICollection<UsersCarsMatrix> UsersCars { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
