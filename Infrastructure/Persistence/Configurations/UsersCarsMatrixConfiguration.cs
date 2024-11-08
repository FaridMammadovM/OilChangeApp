using Domain.Entities;

namespace Persistence.Configurations
{
    public class UsersCarsMatrixConfiguration : IEntityTypeConfiguration<UsersCarsMatrix>
    {
        public void Configure(EntityTypeBuilder<UsersCarsMatrix> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CarNumber).HasMaxLength(20);
            builder.HasOne(x => x.Cars)
                .WithMany(c => c.UsersCars)
                .HasForeignKey(x => x.CarId);
            builder.HasOne(x => x.Customers)
                .WithMany(c => c.UsersCars)
                .HasForeignKey(x => x.CustumerId);
        }
    }
}

