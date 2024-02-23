using Inventario.Core.Entities;

namespace Inventario.Application.Repositories; 
public interface IRepository<T> where T : EntityBase {
    IQueryable<T> GetAll(bool noTracking = true);
    Task<T?> GetByIdAsync(Guid id);
    void Insert(T entity);
    void Insert(List<T> entities);
    void Delete(T entity);
    void Remove(IEnumerable<T> entitiesToRemove);
}