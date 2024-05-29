using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Payments.Queries.GetPayment;

public record GetPaymentHandler(IRepository Repository) : IRequestHandler<GetPaymentQuery, Payment?>
{
    public async Task<Payment?> Handle(GetPaymentQuery request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Payment>(cancellationToken);
        return await transaction.Set.AsNoTracking().Include(x => x.Currency)
                                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}
