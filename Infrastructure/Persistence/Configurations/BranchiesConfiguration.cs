using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class BranchiesConfiguration : IEntityTypeConfiguration<Branchies>
    {
        public void Configure(EntityTypeBuilder<Branchies> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(250);

            var branches = new[]
        {
                new Branchies { Id = 1, Name = "Əhmədli", Address = "Əhmədli filialı", IsDeleted = false },
                new Branchies { Id = 2, Name = "Yasamal", Address = "Yasamal filialı", IsDeleted = false },
                new Branchies { Id = 3, Name = "Sumqayıt", Address = "Sumqayıt filialı", IsDeleted = false },
                new Branchies { Id = 4, Name = "Bakıxanov", Address = "Bakıxanov filialı", IsDeleted = false }
            };

            builder.HasData(branches);
        }
    }
}
