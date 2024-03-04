using Inventario.Application.DataContext;
using Inventario.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Application.Repositories;
public class ProductRepository : IRepository<Product> {
    readonly InventoryDbContext context;

    public ProductRepository(InventoryDbContext context) => this.context = context;

    public void Delete(Product entity) {
        entity.Active = false;
        context.Entry(entity).State = EntityState.Modified;
    }

    public IQueryable<Product> GetAll(bool noTracking = true) {
        return context.Set<Product>().AsQueryable();
    }

    public Task<Product> GetByIdAsync(Guid id) {
        return context.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public void Insert(Product entity) {
        context.Add(entity);
    }

    public void Insert(List<Product> entities) {
        context.AddRange(entities);
    }

    public void Modify(Product entity) {
        context.Entry(entity).State = EntityState.Modified;
    }
}