using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ColorsConfiguration : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);

            var colors = new[]
            {
                new Colors { Id = 1, Name = "Ağ", IsDeleted = false },
                new Colors { Id = 2, Name = "Qara", IsDeleted = false },
                new Colors { Id = 3, Name = "Qırmızı", IsDeleted = false },
                new Colors { Id = 4, Name = "Yaşıl", IsDeleted = false },
                new Colors { Id = 5, Name = "Mavi", IsDeleted = false },
                new Colors { Id = 6, Name = "Sarı", IsDeleted = false },
                new Colors { Id = 7, Name = "Narıncı", IsDeleted = false },
                new Colors { Id = 8, Name = "Bənövşəyi", IsDeleted = false },
                new Colors { Id = 9, Name = "Çəhrayı", IsDeleted = false },
                new Colors { Id = 10, Name = "Boz", IsDeleted = false },
                new Colors { Id = 11, Name = "Qəhvəyi", IsDeleted = false },
                new Colors { Id = 12, Name = "Göy", IsDeleted = false },
                new Colors { Id = 13, Name = "Tünd yaşıl", IsDeleted = false },
                new Colors { Id = 14, Name = "Açıq yaşıl", IsDeleted = false },
                new Colors { Id = 15, Name = "Tünd mavi", IsDeleted = false },
                new Colors { Id = 16, Name = "Açıq mavi", IsDeleted = false },
                new Colors { Id = 17, Name = "Tünd qəhvəyi", IsDeleted = false },
                new Colors { Id = 18, Name = "Açıq qəhvəyi", IsDeleted = false },
                new Colors { Id = 19, Name = "Bürünc", IsDeleted = false },
                new Colors { Id = 20, Name = "Gümüşü", IsDeleted = false },
                new Colors { Id = 21, Name = "Qızılı", IsDeleted = false }
            };

            builder.HasData(colors);
        }
    }
}
