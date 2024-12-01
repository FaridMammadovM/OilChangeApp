using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class FiltersConfiguration : IEntityTypeConfiguration<Filters>
    {
        public void Configure(EntityTypeBuilder<Filters> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);


            var filters = new[]
           {
                new Filters { Id = 1, Name = "Yağ", IsDeleted = false, InsertedDate = DateTime.Now },
                new Filters { Id = 2, Name = "Hava", IsDeleted = false, InsertedDate = DateTime.Now },
                new Filters { Id = 3, Name = "Yanacaq", IsDeleted = false, InsertedDate = DateTime.Now },
                new Filters { Id = 4, Name = "Salon", IsDeleted = false, InsertedDate = DateTime.Now }
            };

            builder.HasData(filters);
        }
    }
}
