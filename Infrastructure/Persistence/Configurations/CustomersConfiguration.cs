using Domain.Entities;

namespace Persistence.Configurations
{
    public class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(20);
        }
    }
}
