namespace Inventario.Application.Repositories; 
public interface IUnitOfWork : IDisposable {
    Task<bool> CommitAsync(CancellationToken cancellationToken = default);
}