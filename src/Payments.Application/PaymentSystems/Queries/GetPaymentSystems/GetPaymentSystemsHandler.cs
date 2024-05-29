using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystems;

public record GetPaymentSystemsHandler(IRepository Repository) : IRequestHandler<GetPaymentSystemsQuery, ICollection<PaymentSystem>>
{
    public async Task<ICollection<PaymentSystem>> Handle(GetPaymentSystemsQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<PaymentSystem>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Payments).Include(x => x.Currencies).ToListAsync(cancellationToken);
    }
}
