using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.CurrencyGroups.Commands.DeleteCurrencyGroup;

public record DeleteCurrencyGroupHandler(IRepository Repository) : IRequestHandler<DeleteCurrencyGroupCommand>
{
    public async Task Handle(DeleteCurrencyGroupCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<CurrencyGroup>(cancellationToken);
        var entity = await transaction.Set.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity == null)
            throw new NullReferenceException("Currency group with specified id not found.");

        transaction.Remove(entity);
        await transaction.CommitAsync(cancellationToken);
    }
}
