using Domain.Entities;

namespace Persistence.Configurations
{
    public sealed class CarsConfiguration : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Model).HasMaxLength(50);
        }
    }
}
