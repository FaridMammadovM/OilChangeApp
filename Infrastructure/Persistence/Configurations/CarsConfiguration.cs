using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public sealed class CarsConfiguration : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
