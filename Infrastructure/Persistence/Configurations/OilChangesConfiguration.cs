using Domain.Entities;

namespace Persistence.Configurations
{
    public class OilChangesConfiguration : IEntityTypeConfiguration<OilChanges>
    {
        public void Configure(EntityTypeBuilder<OilChanges> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Price).HasPrecision(18, 2);
        }
    }
}
