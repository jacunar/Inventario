using Inventario.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Application.DataContext;
public class InventoryDbContext : DbContext {
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options):
        base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Sales> Sales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().Property(p => p.Name)
            .IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Product>().Property(p => p.Description)
            .HasMaxLength(300);

        modelBuilder.Entity<Category>().Property(p => p.Name)
            .IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Category>().Property(p => p.Description)
            .HasMaxLength(300);

        modelBuilder.Entity<Provider>().Property(p => p.Name)
            .IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Provider>().Property(p => p.Address)
            .IsRequired().HasMaxLength(300);
        modelBuilder.Entity<Provider>().Property(p => p.City)
            .IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Provider>().Property(p => p.PhoneNumber)
            .IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Provider>().Property(p => p.Email)
            .IsRequired().HasMaxLength(60);

        modelBuilder.Entity<Stock>().Property(p => p.Description)
            .HasMaxLength(200);
        modelBuilder.Entity<Sales>().Property(p => p.Description)
            .HasMaxLength(200);

        modelBuilder.Entity<Category>().HasData(
            new Category {
                Id = Guid.NewGuid(), Name = "Memoria USB",
                Active = true, CreationDate = DateTime.Now
            },
            new Category {
                Id = Guid.NewGuid(), Name = "Auriculares",
                Active = true, CreationDate = DateTime.Now
            },
            new Category {
                Id = Guid.NewGuid(), Name = "Mouse",
                Active = true, CreationDate = DateTime.Now
            });
    }
}