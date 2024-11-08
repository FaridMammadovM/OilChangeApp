using Domain.Entities;

namespace Persistence.Configurations
{
    public class OilTypesConfiguration : IEntityTypeConfiguration<OilTypes>
    {
        public void Configure(EntityTypeBuilder<OilTypes> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
