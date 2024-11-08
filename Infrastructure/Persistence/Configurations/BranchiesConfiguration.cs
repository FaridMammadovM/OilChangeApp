using Domain.Entities;

namespace Persistence.Configurations
{
    public class BranchiesConfiguration : IEntityTypeConfiguration<Branchies>
    {
        public void Configure(EntityTypeBuilder<Branchies> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(250);
        }
    }
}
