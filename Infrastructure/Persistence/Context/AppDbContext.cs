using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Branchies> Branchies { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Commits> Commits { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Filters> Filters { get; set; }
        public DbSet<FuelTypes> FuelTypes { get; set; }
        public DbSet<OilChangeFiltersMatrix> OilChangeFiltersMatrix { get; set; }
        public DbSet<OilChanges> OilChanges { get; set; }
        public DbSet<OilTypes> OilTypes { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<UsersCarsMatrix> UsersCarsMatrix { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BranchiesConfiguration());
            modelBuilder.ApplyConfiguration(new CarsConfiguration());
            modelBuilder.ApplyConfiguration(new ColorsConfiguration());
            modelBuilder.ApplyConfiguration(new CommitsConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
            modelBuilder.ApplyConfiguration(new FiltersConfiguration());
            modelBuilder.ApplyConfiguration(new FuelTypesConfiguration());
            modelBuilder.ApplyConfiguration(new OilChangeFiltersMatrixConfiguration());
            modelBuilder.ApplyConfiguration(new OilChangesConfiguration());
            modelBuilder.ApplyConfiguration(new OilTypesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new ServicesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersCarsMatrixConfiguration());

        }
    }
}
