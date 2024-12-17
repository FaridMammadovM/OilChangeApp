using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class MotorConfiguration : IEntityTypeConfiguration<Motor>
    {
        public void Configure(EntityTypeBuilder<Motor> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.EngineCapacity).HasMaxLength(50);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            var motor = new List<Motor>();
            int id = 1;

            for (int capacity = 100; capacity <= 6500; capacity += 100)
            {
                motor.Add(new Motor
                {
                    Id = id++,
                    EngineCapacity = capacity,
                    IsDeleted = false,
                    InsertedBy = 3,
                    InsertedDate = DateTime.Now
                });
            }

            for (int capacity = 6500; capacity <= 16000; capacity += 500)
            {
                motor.Add(new Motor
                {
                    Id = id++,
                    EngineCapacity = capacity,
                    IsDeleted = false,
                    InsertedBy = 3,
                    InsertedDate = DateTime.Now
                });
            }

            builder.HasData(motor);
        }
    }
}
