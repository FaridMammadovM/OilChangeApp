using Domain.Entities;

namespace Persistence.Configurations
{
    public sealed class UsersConfigurtion : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(x => x.Id).IsRequired();
        }
    }
}
