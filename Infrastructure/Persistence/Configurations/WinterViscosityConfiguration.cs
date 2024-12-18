using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public sealed class WinterViscosityConfiguration : IEntityTypeConfiguration<WinterViscosity>
    {
        public void Configure(EntityTypeBuilder<WinterViscosity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Grade).HasMaxLength(10);

            var winterViscosities = new[]
            {
                //muherrik yag
                new WinterViscosity { Id = 1, Grade = 8,     ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 2, Grade = 12,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 3, Grade = 16,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 4, Grade = 20,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 5, Grade = 30,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 6, Grade = 40,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 7, Grade = 50,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 8, Grade = 60,    ServiceType = 1, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                     
                //eylec mayesi
                new WinterViscosity { Id = 9, Grade = 3,     ServiceType = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 10, Grade = 4,    ServiceType = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 11, Grade = 5.1M, ServiceType = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 12, Grade = 6,    ServiceType = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 13, Grade = 5,    ServiceType = 2, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }

            };

            builder.HasData(winterViscosities);
        }
    }
}
