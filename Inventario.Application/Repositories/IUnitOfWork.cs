namespace Inventario.Application.Repositories; 
public interface IUnitOfWork : IDisposable {
    Task<int> CommitAsync(CancellationToken cancellationToken = default);
}