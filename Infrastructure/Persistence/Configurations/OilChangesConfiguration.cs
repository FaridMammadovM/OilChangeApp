using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class OilChangesConfiguration : IEntityTypeConfiguration<OilChanges>
    {
        public void Configure(EntityTypeBuilder<OilChanges> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(500);

            builder.Property(x => x.Price).HasPrecision(18, 2);

            builder.HasOne(x => x.CustomersCarsMatrix)
                .WithMany(c => c.OilChanges)
                .HasForeignKey(x => x.CustomersCarsMatrix);

            builder.HasOne(x => x.Services)
                .WithMany(s => s.OilChanges)
                .HasForeignKey(x => x.ServiceId);

            builder.HasOne(x => x.Products)
                .WithMany(p => p.OilChanges)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.OilTypes)
                .WithMany(o => o.OilChanges)
                .HasForeignKey(x => x.OilTypeId);

            builder.HasOne(x => x.Employees)
                .WithMany(e => e.OilChanges)
                .HasForeignKey(x => x.EmployeeId);

            builder.HasOne(x => x.Branchies)
              .WithMany(b => b.OilChanges)
              .HasForeignKey(x => x.BranchId);
        }
    }
}
