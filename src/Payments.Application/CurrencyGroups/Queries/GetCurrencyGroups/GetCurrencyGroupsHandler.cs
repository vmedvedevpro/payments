using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroups;

public record GetCurrencyGroupsHandler(IRepository Repository) : IRequestHandler<GetCurrencyGroupsQuery, ICollection<CurrencyGroup>>
{
    public async Task<ICollection<CurrencyGroup>> Handle(GetCurrencyGroupsQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<CurrencyGroup>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Currencies).ToListAsync(cancellationToken);
    }
}
