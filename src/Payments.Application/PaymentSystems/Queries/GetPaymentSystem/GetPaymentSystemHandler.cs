using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystem;

public record GetPaymentSystemHandler(IRepository Repository) : IRequestHandler<GetPaymentSystemQuery, PaymentSystem?>
{
    public async Task<PaymentSystem?> Handle(GetPaymentSystemQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<PaymentSystem>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Payments).Include(x => x.Currencies)
                                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}
