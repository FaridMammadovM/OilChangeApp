using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class OilChangesConfiguration : IEntityTypeConfiguration<OilChanges>
    {
        public void Configure(EntityTypeBuilder<OilChanges> builder)
        {
            // Id gereklidir
            builder.Property(x => x.Id).IsRequired();

            // Açıklama alanını sınırlıyoruz
            builder.Property(x => x.Description).HasMaxLength(500);

            // Fiyat alanını decimal olarak tanımlıyoruz
            builder.Property(x => x.Price).HasPrecision(18, 2);

            // Customers ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Customers)
                .WithMany(c => c.OilChanges)  // Bir Customer birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.CustumerId);  // CustumerId foreign key

            // Cars ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Cars)
                .WithMany(c => c.OilChanges)  // Bir Car birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.CarId);  // CarId foreign key

            // Services ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Services)
                .WithMany(s => s.OilChanges)  // Bir Service birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.ServiceId);  // ServiceId foreign key

            // Products ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Products)
                .WithMany(p => p.OilChanges)  // Bir Product birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.ProductId);  // ProductId foreign key

            // OilTypes ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.OilTypes)
                .WithMany(o => o.OilChanges)  // Bir OilType birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.OilTypeId);  // OilTypeId foreign key

            // Employees ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Employees)
                .WithMany(e => e.OilChanges)  // Bir Employee birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.EmployeeId);  // EmployeeId foreign key

            // Branchies ile olan ilişkiyi tanımlıyoruz
            builder.HasOne(x => x.Branchies)
                .WithMany(b => b.OilChanges)  // Bir Branch birden fazla OilChange kaydına sahip olabilir
                .HasForeignKey(x => x.BranchId);  // BranchId foreign key

       
           
        }
    }
}
