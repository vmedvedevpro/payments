using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroup;

public record GetCurrencyGroupHandler(IRepository Repository) : IRequestHandler<GetCurrencyGroupQuery, CurrencyGroup?>
{
    public async Task<CurrencyGroup?> Handle(GetCurrencyGroupQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<CurrencyGroup>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Currencies)
                                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}
