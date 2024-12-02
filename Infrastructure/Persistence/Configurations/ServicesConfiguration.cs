using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ServicesConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);


            var services = new[]
            {
                new Services { Id = 1, Name = "Sürətlər qutusu yağ dəyişmə", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 2, Name = "Mühərrik yağ dəyişmə", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }

            };

            builder.HasData(services);
        }
    }
}
