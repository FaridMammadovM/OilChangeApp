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
        public string? RefreshToken { get; set; }
        public bool IsOtp { get; set; } = false;
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<Commits> Commits { get; set; }
        public ICollection<CustomersCarsMatrix> CustomersCars { get; set; }
        public Role Role { get; set; }
    }
}
