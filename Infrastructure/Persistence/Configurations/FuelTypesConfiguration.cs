using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FuelTypesConfiguration : IEntityTypeConfiguration<FuelTypes>
    {
        public void Configure(EntityTypeBuilder<FuelTypes> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);

            var fuelTypes = new[]
         {
                new FuelTypes { Id = 1, Name = "Benzin", IsDeleted = false },
                new FuelTypes { Id = 2, Name = "Qaz", IsDeleted = false },
                new FuelTypes { Id = 3, Name = "Dizel", IsDeleted = false },
                new FuelTypes { Id = 4, Name = "Elektro", IsDeleted = false },
                new FuelTypes { Id = 5, Name = "Hybrid", IsDeleted = false },
                new FuelTypes { Id = 6, Name = "Plug-in Hybrid", IsDeleted = false },
                new FuelTypes { Id = 7, Name = "Hidrogen", IsDeleted = false }
            };

            builder.HasData(fuelTypes);
        }
    }
}
