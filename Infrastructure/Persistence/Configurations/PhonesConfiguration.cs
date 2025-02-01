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
                new Phones { Id = 3, Phone = "+994706843434", BranchId = 3, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Binəqədi filialı
                new Phones { Id = 4, Phone = "+994777332322", BranchId = 4, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },   // Bakıxanov filialı
                new Phones { Id = 5, Phone = "+994706743434", BranchId = 5, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },   // Xetai filialı
                new Phones { Id = 6, Phone = "+994707552322", BranchId = 6, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Sumqayıt filialı
                new Phones { Id = 7, Phone = "+994702153434", BranchId = 7, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Gəncə filialı
                new Phones { Id = 8, Phone = "+994702344334", BranchId = 8, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Xacmaz filialı
                new Phones { Id = 9, Phone = "+994702344334", BranchId = 9, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },  // Quba filialı
            };

            builder.HasData(phones);

        }
    }
}
