using Domain.Entities;

namespace Persistence.Configurations
{
    public class PhonesConfiguration : IEntityTypeConfiguration<Phones>
    {
        public void Configure(EntityTypeBuilder<Phones> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(20);
        }
    }
}
