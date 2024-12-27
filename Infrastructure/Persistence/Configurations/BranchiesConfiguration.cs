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
                new Branchies { Id = 1, Name = "Əhmədli filialı",  Latitude = 40.37793403859909,  Longitude = 49.9652205,   Address = "General Şixlinski küçəsi,264 saylı məktəbin yanı", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 2, Name = "Yasamal filialı",  Latitude = 40.397900118850174, Longitude = 49.79156341349247,   Address = "Şeyx Məhəmməd Xiyabani 51", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 3, Name = "Binəqədi filialı", Latitude = 40.46270450246867,  Longitude = 49.84103032883584,   Address = "Binəqədi şosesi 1. Binəqədi 4yol", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 4, Name = "Bakıxanov filialı",Latitude = 40.43489056188526,  Longitude = 49.9568945846566,   Address = "Yavər Əliyev 68A", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 5, Name = "Xətai filialı",    Latitude = 40.37769694222968,  Longitude = 49.87201885314902,   Address = "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 6, Name = "Sumqayıt filialı", Latitude = 40.57329552424429, Longitude = 49.668450085584176,   Address = "Sumqayıt-çerkasski 78", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 7, Name = "Gəncə filialı",    Latitude = 40.66696941758239, Longitude = 46.352373390200576,   Address = "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 8, Name = "Xaçmaz filialı",   Latitude = 41.4759657, Longitude = 48.77674875767169,   Address = "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", IsDeleted = false, InsertedDate = DateTime.Now },
                new Branchies { Id = 9, Name = "Quba filialı",     Latitude = 41.363251986092024, Longitude = 48.53640067771017,   Address = "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", IsDeleted = false, InsertedDate = DateTime.Now }
            };

            builder.HasData(branches);
        }
    }
}
