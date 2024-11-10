using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CommitsConfiguration : IEntityTypeConfiguration<Commits>
    {
        public void Configure(EntityTypeBuilder<Commits> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CommitMessage).HasMaxLength(250);
            //builder.HasOne(x => x.Users)
            //    .WithMany()
            //    .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Customers)
                .WithMany(c => c.Commits)
                .HasForeignKey(x => x.CustumerId);
        }
    }
}
