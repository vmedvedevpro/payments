using Microsoft.EntityFrameworkCore.Storage;

using Payments.Application.Common.Interfaces;
using Payments.Domain.Entities.Base;

namespace Payments.Infrastructure.Persistence.Repository;

public class Transaction<TEntity> : ITransaction<TEntity>
    where TEntity : EntityBase
{
    public IQueryable<TEntity> Set => Context.Set<TEntity>();

    private DatabaseContext? _dbContext;

    private IDbContextTransaction? _transaction;

    private DatabaseContext Context =>
        _dbContext ?? throw new ObjectDisposedException("The transaction is already closed (applied or cancelled)");

    public Transaction(DatabaseContext context)
    {
        _dbContext = context;
        _transaction = _dbContext.Database.BeginTransaction();
    }

    public void Commit()
    {
        Context.SaveChanges();
        _transaction?.Commit();
    }

    public async Task CommitAsync(CancellationToken cancellationToken)
    {
        await Context.SaveChangesAsync(cancellationToken);
        if (_transaction != null)
        {
            await _transaction.CommitAsync(cancellationToken);
        }
    }

    public void Dispose()
    {
        if (_transaction != null)
        {
            _transaction.Dispose();
            _transaction = null;
        }

        if (_dbContext != null)
        {
            _dbContext.Dispose();
            _dbContext = null;
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_transaction != null)
        {
            await _transaction.DisposeAsync().ConfigureAwait(false);
            _transaction = null;
        }

        if (_dbContext != null)
        {
            await _dbContext.DisposeAsync().ConfigureAwait(false);
            _dbContext = null;
        }
    }

    public TEntity Update(TEntity entity) => Context.Set<TEntity>().Update(entity).Entity;

    public void UpdateRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().UpdateRange(entities);

    public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);

    public void RemoveRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().RemoveRange(entities);

    public TEntity Add(TEntity entity) => Context.Set<TEntity>().Add(entity).Entity;

    public void AddRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().AddRange(entities);
}
