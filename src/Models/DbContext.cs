using AdventureTIme.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureTime.Models
{
    public class AdventureTimeDbContext : DbContext
    {
        
        public AdventureTimeDbContext(DbContextOptions<AdventureTimeDbContext> options) : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        
        // Add more DbSets for other entities

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer", schema: "SalesLT");
            modelBuilder.Entity<Product>().ToTable("Product", schema: "SalesLT");
            modelBuilder.Entity<Order>().ToTable("SalesOrderHeader", schema: "SalesLT");
            modelBuilder.Entity<OrderDetails>().ToTable("SalesOrderDetail", schema: "SalesLT");
            modelBuilder.Entity<Address>().ToTable("Address", schema: "SalesLT");
            modelBuilder.Entity<Category>().ToTable("ProductCategory", schema: "SalesLT");
            
            // Add more model configuration here

            base.OnModelCreating(modelBuilder);
        }
    }
}