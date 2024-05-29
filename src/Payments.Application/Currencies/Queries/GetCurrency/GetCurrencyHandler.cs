using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Currencies.Queries.GetCurrency;

public record GetCurrencyHandler(IRepository Repository) : IRequestHandler<GetCurrencyQuery, Currency?>
{
    public async Task<Currency?> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Currency>(cancellationToken);
        return await transaction.Set.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}
