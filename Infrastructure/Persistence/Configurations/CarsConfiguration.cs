using Domain.Entities;

namespace Persistence.Configurations
{
    public sealed class CarsConfiguration : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Model).HasMaxLength(50);
            builder.Property(x => x.Brand).HasMaxLength(50);
            builder.Property(x => x.Motor).HasPrecision(18, 2);
            builder.HasOne(x => x.Colors)
                .WithMany(c => c.Cars)
                .HasForeignKey(x => x.ColorId);
            builder.HasOne(x => x.FuelType)
                .WithMany(f => f.Cars)
                .HasForeignKey(x => x.FuelTypeId);
        }
    }
}