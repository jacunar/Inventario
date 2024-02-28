using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Inventario.Application.DataContext; 
public class InventoryContextFactory: IDesignTimeDbContextFactory<InventoryDbContext> {
    public InventoryDbContext CreateDbContext(string[] args) {
        var optionBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
        optionBuilder.UseSqlite("Data Source=inventory.sqlite");
        return new InventoryDbContext(optionBuilder.Options);
    }
}