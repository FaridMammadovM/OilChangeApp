using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class PhonesConfiguration : IEntityTypeConfiguration<Phones>
    {
        public void Configure(EntityTypeBuilder<Phones> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(20);

            builder.HasOne(x => x.Branchies)
                .WithMany(b => b.Phones)
                .HasForeignKey(x => x.BranchId);

            var phones = new[]
            {
                new Phones { Id = 1, Phone = "+994703305788", BranchId = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Əhmədli filialı
                new Phones { Id = 2, Phone = "+994702343134", BranchId = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Yasamal filialı
                new Phones { Id = 3, Phone = "+994707552322", BranchId = 3, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Sumqayıt filialı
                new Phones { Id = 4, Phone = "+994077332322", BranchId = 4, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }   // Bakıxanov filialı
            };

            builder.HasData(phones);

        }
    }
}
