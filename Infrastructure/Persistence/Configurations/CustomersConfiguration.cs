using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.RoleId).IsRequired();
            builder.Property(x => x.OtpCode).IsRequired(false);
            builder.Property(x => x.OtpExpirationTime).IsRequired(false);

            var branches = new[]
    {
                new Customers { Id = 1, Name = "Admin", Surname = "Admins", RoleId = 2, IsOtp = true,
                    Password = "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K",
                    Phone = "", RefreshToken = "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=",
                    Username = "Admins",
                    RefreshTokenExpiryTime = DateTime.Now.AddMonths(2),
                    IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
                 new Customers { Id = 2, Name = "Master Admin", Surname = "Master", RoleId = 2, IsOtp = true,
                    Password = "$2a$11$WtAIsna.lr/I3gy4ELiY2usk/7ap3cwoV9upE8S.GgNLUCiT3t9HK",
                    Phone = "", RefreshToken = "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=",
                    Username = "MasterClass",
                    RefreshTokenExpiryTime = DateTime.Now.AddMonths(2),
                    IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 },
            };

            builder.HasData(branches);

        }
    }
}
