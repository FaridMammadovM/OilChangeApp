using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class OilTypesConfiguration : IEntityTypeConfiguration<OilTypes>
    {
        public void Configure(EntityTypeBuilder<OilTypes> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);


            var oilTypes = new[]
            {
                new OilTypes { Id = 1, Name = "5-30", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }
            };

            builder.HasData(oilTypes);
        }
    }
}
