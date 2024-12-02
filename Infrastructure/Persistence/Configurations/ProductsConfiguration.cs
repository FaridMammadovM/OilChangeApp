﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);

            var products = new[]
        {
                new Products { Id = 1, Name = "Elf", IsDeleted = false, InsertedDate = DateTime.Now },
             
            };

            builder.HasData(products);
        }
    }
}
