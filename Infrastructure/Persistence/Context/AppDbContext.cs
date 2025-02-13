using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Branchies> Branchies { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Commits> Commits { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomersCarsMatrix> CustomersCarsMatrix { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Filters> Filters { get; set; }
        public DbSet<FuelTypes> FuelTypes { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public DbSet<NotificationHistory> Notifications { get; set; }
        public DbSet<OilChangeFiltersMatrix> OilChangeFiltersMatrix { get; set; }
        public DbSet<OilChanges> OilChanges { get; set; }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SAEViscosity> SAEViscosities { get; set; }
        public DbSet<WinterViscosity> WinterViscosities { get; set; }
        public DbSet<Services> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
