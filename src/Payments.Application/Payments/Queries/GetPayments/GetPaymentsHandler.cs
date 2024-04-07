using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Payments.Queries.GetPayments;

public record GetPaymentsHandler(IRepository Repository) : IRequestHandler<GetPaymentsQuery, ICollection<Payment>>
{
    public async Task<ICollection<Payment>> Handle(GetPaymentsQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Payment>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Currency).ToListAsync(cancellationToken);
    }
}
