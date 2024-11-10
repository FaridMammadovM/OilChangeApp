using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public sealed class Role : IdentityRole<Guid>
    {
        public string RoleName { get; set; }
    }
}
