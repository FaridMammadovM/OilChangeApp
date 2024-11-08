using Domain.Entities;

namespace Persistence.Configurations
{
    public class FiltersConfiguration : IEntityTypeConfiguration<Filters>
    {
        public void Configure(EntityTypeBuilder<Filters> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
