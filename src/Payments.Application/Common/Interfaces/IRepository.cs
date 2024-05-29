using Payments.Domain.Entities.Base;

namespace Payments.Application.Common.Interfaces;

public interface IRepository
{
    ITransaction<TEntity> BeginTransaction<TEntity>()
        where TEntity : EntityBase;

    Task<ITransaction<TEntity>> BeginTransactionAsync<TEntity>(CancellationToken cancellationToken)
        where TEntity : EntityBase;
}
