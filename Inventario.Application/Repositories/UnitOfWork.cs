using Inventario.Application.DataContext;

namespace Inventario.Application.Repositories;
public class UnitOfWork : IUnitOfWork {
    readonly InventoryDbContext Context;
    public UnitOfWork(InventoryDbContext context) => Context = context;

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default) {
        return await Context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose() {
        Context.Dispose();
    }
}