using Inventario.Application.DataContext;
using Inventario.Core.Entities;

namespace Inventario.Application.Repositories;
public class ProductRepository : IRepository<Product> {
    readonly InventoryDbContext context;

    public ProductRepository(InventoryDbContext context) => this.context = context;

    public void Delete(Product entity) {
        entity.Active = false;

    }

    public IQueryable<Product> GetAll(bool noTracking = true) {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(Guid id) {
        throw new NotImplementedException();
    }

    public void Insert(Product entity) {
        context.Add(entity);
    }

    public void Insert(List<Product> entities) {
        context.AddRange(entities);
    }

    public void Remove(IEnumerable<Product> entitiesToRemove) {
        throw new NotImplementedException();
    }
}