using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);

            var products = new[]
        {
                new Products { Id = 1, Name = "Alpine", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 2, Name = "Bardahl", IsDeleted = false, InsertedDate = DateTime.Now      , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 3, Name = "Mitanol", IsDeleted = false, InsertedDate = DateTime.Now      , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 4, Name = "Eni", IsDeleted = false, InsertedDate = DateTime.Now          , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 5, Name = "Ravenol", IsDeleted = false, InsertedDate = DateTime.Now      , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 6, Name = "German Gold", IsDeleted = false, InsertedDate = DateTime.Now  , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 7, Name = "SRS", IsDeleted = false, InsertedDate = DateTime.Now          , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 8, Name = "Ams-Oil", IsDeleted = false, InsertedDate = DateTime.Now      , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 9, Name = "Petro Canada", IsDeleted = false, InsertedDate = DateTime.Now , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 10, Name = "Eurolub", IsDeleted = false, InsertedDate = DateTime.Now     , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 11, Name = "Motul", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 12, Name = "Addinol", IsDeleted = false, InsertedDate = DateTime.Now     , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 13, Name = "Mobil", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 14, Name = "Shell", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 15, Name = "Total", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 16, Name = "Eneos", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 17, Name = "Opet", IsDeleted = false, InsertedDate = DateTime.Now        , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 18, Name = "Meguin", IsDeleted = false, InsertedDate = DateTime.Now      , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 19, Name = "Rowe", IsDeleted = false, InsertedDate = DateTime.Now        , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 20, Name = "Lubex", IsDeleted = false, InsertedDate = DateTime.Now       , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 21, Name = "North Sea", IsDeleted = false, InsertedDate = DateTime.Now   , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 22, Name = "AGAT", IsDeleted = false, InsertedDate = DateTime.Now        , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 23, Name = "Boost Oil", IsDeleted = false, InsertedDate = DateTime.Now   , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 24, Name = "Liqui Moly", IsDeleted = false, InsertedDate = DateTime.Now  , CategoryId = 1, InsertedBy = 1},
                new Products { Id = 25, Name = "Liqui Moly", IsDeleted = false, InsertedDate = DateTime.Now  , CategoryId = 2, InsertedBy = 1},
                new Products { Id = 26, Name = "Opet", IsDeleted = false, InsertedDate = DateTime.Now        , CategoryId = 3, InsertedBy = 1},


            };

            builder.HasData(products);
        }
    }
}
