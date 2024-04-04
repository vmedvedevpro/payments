using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Currencies.Commands.DeleteCurrency;

public record DeleteCurrencyHandler(IRepository Repository) : IRequestHandler<DeleteCurrencyCommand>
{
    public async Task Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Currency>(cancellationToken);

        var entity = await transaction.Set.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity == null)
            throw new NullReferenceException("Currency with specified id not found");

        transaction.Remove(entity);
        await transaction.CommitAsync(cancellationToken);
    }
}
