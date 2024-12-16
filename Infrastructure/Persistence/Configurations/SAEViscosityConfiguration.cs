using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public sealed class SAEViscosityConfiguration : IEntityTypeConfiguration<SAEViscosity>
    {
        public void Configure(EntityTypeBuilder<SAEViscosity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Grade).HasMaxLength(10);

            var saeViscosities = new[]
            {
                new SAEViscosity { Id = 1, Grade = 0, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new SAEViscosity { Id = 2, Grade = 5, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new SAEViscosity { Id = 3, Grade = 10, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                new SAEViscosity { Id = 4, Grade = 20, IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }
            };

            builder.HasData(saeViscosities);
        }
    }
}