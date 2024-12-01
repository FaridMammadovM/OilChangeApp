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
            builder.Property(x => x.Model).HasMaxLength(50);
            builder.Property(x => x.Brand).HasMaxLength(50);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            var cars = new[]
            {
                //bmw
                new Cars { Id = 1, Model = "X5", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 2, Model = "M3", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 3, Model = "M4", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 4, Model = "M2", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 5, Model = "3 Series", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 6, Model = "5 Series", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 7, Model = "7 Series", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 8, Model = "X3", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 9, Model = "X4", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 10, Model = "X6", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 11, Model = "X7", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 12, Model = "i3", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 13, Model = "i4", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 14, Model = "iX", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 15, Model = "Z4", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 16, Model = "530e", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 17, Model = "750i", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 18, Model = "M5", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 19, Model = "M8", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 20, Model = "i7", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 21, Model = "2 Series", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 22, Model = "1 Series", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 23, Model = "M6", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 24, Model = "320i", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 25, Model = "420i", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 26, Model = "520d", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 27, Model = "730d", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 28, Model = "740i", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 29, Model = "X1", Brand = "BMW", IsDeleted = false, InsertedDate = DateTime.Now },

                //mercedes
                new Cars { Id = 30, Model = "C-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 31, Model = "E-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 32, Model = "S-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 33, Model = "A-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 34, Model = "CLA-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 35, Model = "GLA-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 36, Model = "GLC-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 37, Model = "GLE-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 38, Model = "GLS-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 39, Model = "SLS AMG", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 40, Model = "AMG GT", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 41, Model = "G-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 42, Model = "Maybach S-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 43, Model = "EQC", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 44, Model = "EQS", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 45, Model = "Coupé", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 46, Model = "Roadster", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 47, Model = "B-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 48, Model = "V-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 49, Model = "GLB-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 50, Model = "S-Class Coupe", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 51, Model = "SL-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 52, Model = "M-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 53, Model = "X-Class", Brand = "Mercedes-Benz", IsDeleted = false, InsertedDate = DateTime.Now },

                //Audi
                new Cars { Id = 54, Model = "A4", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 55, Model = "A6", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 56, Model = "Q7", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 57, Model = "Q5", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 58, Model = "A8", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 59, Model = "Q3", Brand = "Audi", IsDeleted = false, InsertedDate = DateTime.Now },

                //toyota
                new Cars { Id = 60, Model = "Corolla", Brand = "Toyota", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 61, Model = "Camry", Brand = "Toyota", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 62, Model = "RAV4", Brand = "Toyota", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 63, Model = "Land Cruiser", Brand = "Toyota", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 64, Model = "Hilux", Brand = "Toyota", IsDeleted = false, InsertedDate = DateTime.Now },

                //kia
                new Cars { Id = 65, Model = "Sorento", Brand = "Kia", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 66, Model = "Sportage", Brand = "Kia", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 67, Model = "K5", Brand = "Kia", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 68, Model = "Stinger", Brand = "Kia", IsDeleted = false, InsertedDate = DateTime.Now },

                //Hyundai
                new Cars { Id = 69, Model = "Sonata", Brand = "Hyundai", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 70, Model = "Tucson", Brand = "Hyundai", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 71, Model = "Elantra", Brand = "Hyundai", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 72, Model = "Kona", Brand = "Hyundai", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 73, Model = "Palisade", Brand = "Hyundai", IsDeleted = false, InsertedDate = DateTime.Now },

                //Mitsubishi
                new Cars { Id = 74, Model = "Outlander", Brand = "Mitsubishi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 75, Model = "Lancer", Brand = "Mitsubishi", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 76, Model = "Eclipse", Brand = "Mitsubishi", IsDeleted = false, InsertedDate = DateTime.Now },

                //Lada
                new Cars { Id = 77, Model = "Granta", Brand = "Lada", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 78, Model = "Vesta", Brand = "Lada", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 79, Model = "XRay", Brand = "Lada", IsDeleted = false, InsertedDate = DateTime.Now },

                //Volkswagen
                new Cars { Id = 80, Model = "Golf", Brand = "Volkswagen", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 81, Model = "Passat", Brand = "Volkswagen", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 82, Model = "Tiguan", Brand = "Volkswagen", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 83, Model = "Jetta", Brand = "Volkswagen", IsDeleted = false, InsertedDate = DateTime.Now },

                //other
                new Cars { Id = 84, Model = "Mustang", Brand = "Ford", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 85, Model = "F-150", Brand = "Ford", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 86, Model = "Range Rover", Brand = "Land Rover", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 87, Model = "Discovery", Brand = "Land Rover", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 88, Model = "911", Brand = "Porsche", IsDeleted = false, InsertedDate = DateTime.Now },
                new Cars { Id = 89, Model = "Cayenne", Brand = "Porsche", IsDeleted = false, InsertedDate = DateTime.Now }

            };       


            builder.HasData(cars);
        }

    }
}