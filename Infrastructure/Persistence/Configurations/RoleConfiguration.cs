using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.RoleName).HasMaxLength(100);

            var roles = new[]
            {
                new Role { Id = 1, RoleName = "Costumer", IsDeleted = false, InsertedDate = DateTime.Now },
                new Role { Id = 2, RoleName = "Branch", IsDeleted = false, InsertedDate = DateTime.Now }
            };

            builder.HasData(roles);
        }
    }
}
