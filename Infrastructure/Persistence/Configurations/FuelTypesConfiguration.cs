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
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);


            var fuelTypes = new[]
         {
                new FuelTypes { Id = 1, Name = "Benzin", IsDeleted = false, InsertedDate = DateTime.Now },
                new FuelTypes { Id = 2, Name = "Qaz", IsDeleted = false, InsertedDate = DateTime.Now },
                new FuelTypes { Id = 3, Name = "Dizel", IsDeleted = false, InsertedDate = DateTime.Now },
                new FuelTypes { Id = 4, Name = "Elektro", IsDeleted = false, InsertedDate = DateTime.Now },
                new FuelTypes { Id = 5, Name = "Hybrid", IsDeleted = false , InsertedDate = DateTime.Now},
                new FuelTypes { Id = 6, Name = "Plug-in Hybrid", IsDeleted = false, InsertedDate = DateTime.Now }
            };

            builder.HasData(fuelTypes);
        }
    }
}
