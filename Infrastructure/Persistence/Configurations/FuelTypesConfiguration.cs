using Domain.Entities;

namespace Persistence.Configurations
{
    public class FuelTypesConfiguration : IEntityTypeConfiguration<FuelTypes>
    {
        public void Configure(EntityTypeBuilder<FuelTypes> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
