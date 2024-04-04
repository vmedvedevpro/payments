using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Currencies.Queries.GetCurrencies;

public record GetCurrenciesHandler(IRepository Repository) : IRequestHandler<GetCurrenciesQuery, ICollection<Currency>>
{
    public async Task<ICollection<Currency>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Currency>(cancellationToken);
        return await transaction.Set.AsNoTracking().ToListAsync(cancellationToken: cancellationToken);
    }
}
