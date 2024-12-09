using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            var employee = new[]
            {
                new Employees { Id = 1, Name = "Master Employee", Surname = "Master", IsDeleted = false, InsertedDate = DateTime.Now, InsertedBy = 1 }
            };

            builder.HasData(employee);
        }
    }
}
