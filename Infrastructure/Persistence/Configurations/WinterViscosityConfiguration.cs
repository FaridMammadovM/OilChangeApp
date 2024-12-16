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
                new WinterViscosity { Id = 1, Grade = 8, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 2, Grade = 12, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 3, Grade = 16, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 4, Grade = 20, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 5, Grade = 30, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 6, Grade = 40, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 7, Grade = 50, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 8, Grade = 60, IsBrakeFluidChanged = false, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },

                new WinterViscosity { Id = 9, Grade = 3, IsBrakeFluidChanged = true, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 10, Grade = 4, IsBrakeFluidChanged = true, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 11, Grade = 5.1M, IsBrakeFluidChanged = true, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 12, Grade = 6, IsBrakeFluidChanged = true, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new WinterViscosity { Id = 13, Grade = 5, IsBrakeFluidChanged = true, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }

            };

            builder.HasData(winterViscosities);
        }
    }
}
