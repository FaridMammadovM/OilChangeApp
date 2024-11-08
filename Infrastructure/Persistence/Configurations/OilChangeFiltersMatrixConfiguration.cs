using Domain.Entities;

namespace Persistence.Configurations
{
    public class OilChangeFiltersMatrixConfiguration : IEntityTypeConfiguration<OilChangeFiltersMatrix>
    {
        public void Configure(EntityTypeBuilder<OilChangeFiltersMatrix> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.HasOne(x => x.OilChanges)
                .WithMany(o => o.OilChangeFilters)
                .HasForeignKey(x => x.OilChangesId);
            builder.HasOne(x => x.Filter)
                .WithMany(f => f.OilChangeFilters)
                .HasForeignKey(x => x.FiltersId);
        }
    }
}
