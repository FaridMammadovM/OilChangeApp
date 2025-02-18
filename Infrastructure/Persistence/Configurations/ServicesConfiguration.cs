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
                new Services { Id = 1, Name = "Sürətlər qutusu", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 2, Name = "Mühərrik", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 3, Name = "Antifiriz", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 4, Name = "Əyləc mayesi", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 5, Name = "Arxa körpü", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 6, Name = "Ön körpü", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new Services { Id = 7, Name = "Diferensial (Razdatka)", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }

            };

            builder.HasData(services);
        }
    }
}
