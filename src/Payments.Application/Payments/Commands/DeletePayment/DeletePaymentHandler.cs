using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Payments.Commands.DeletePayment;

public record DeletePaymentHandler(IRepository Repository) : IRequestHandler<DeletePaymentCommand>
{
    public async Task Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Payment>(cancellationToken);
        var entity = await transaction.Set.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity == null)
            throw new NullReferenceException("Payment with specified id not found.");

        transaction.Remove(entity);
        await transaction.CommitAsync(cancellationToken);
    }
}
