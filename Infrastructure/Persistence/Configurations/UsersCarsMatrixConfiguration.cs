using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UsersCarsMatrixConfiguration : IEntityTypeConfiguration<CustomersCarsMatrix>
    {
        public void Configure(EntityTypeBuilder<CustomersCarsMatrix> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CarNumber).HasMaxLength(20);
            builder.HasOne(x => x.Cars)
                .WithMany(c => c.UsersCars)
                .HasForeignKey(x => x.CarId);
            builder.HasOne(x => x.Customers)
                .WithMany(c => c.CustomersCars)
                .HasForeignKey(x => x.CustomerId);
            builder.HasOne(c => c.Colors)
                .WithMany(c => c.UsersCars)
                .HasForeignKey(x => x.CarId);

        }
    }
}

