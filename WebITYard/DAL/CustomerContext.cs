using Microsoft.EntityFrameworkCore;
using WebITYard.DAL.Configurations;
using WebITYard.Repositories.Models;

namespace WebITYard.DAL
{
    public class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}
