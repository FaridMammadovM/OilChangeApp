using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class BranchiesConfiguration : IEntityTypeConfiguration<Branchies>
    {
        public void Configure(EntityTypeBuilder<Branchies> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(250);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            var branches = new[]
        {
                new Branchies { Id = 1, Name = "Əhmədli filialı", Address = "General Şixlinski küçəsi,264 saylı məktəbin yanı", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 2, Name = "Yasamal filialı", Address = "Şeyx Məhəmməd Xiyabani 51", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 3, Name = "Binəqədi filialı", Address = "Binəqədi şosesi 1. Binəqədi 4yol", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 4, Name = "Bakıxanov filialı", Address = "Yavər Əliyev 68A", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 5, Name = "Xətai filialı", Address = "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 6, Name = "Sumqayıt filialı", Address = "Sumqayıt-çerkasski 78", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 7, Name = "Gəncə filialı", Address = "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 8, Name = "Xaçmaz filialı", Address = "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 9, Name = "Quba filialı", Address = "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", IsDeleted = false, InsertedDate = DateTime.Now }
            };

            builder.HasData(branches);
        }
    }
}
