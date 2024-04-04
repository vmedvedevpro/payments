using Microsoft.EntityFrameworkCore;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.PaymentSystems.Commands.DeletePaymentSystem;

public record DeletePaymentSystemHandler(IRepository Repository) : IRequestHandler<DeletePaymentSystemCommand>
{
    public async Task Handle(DeletePaymentSystemCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<PaymentSystem>(cancellationToken);
        var entity = await transaction.Set.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity == null)
            throw new NullReferenceException("Payment system with specified id not found.");

        transaction.Remove(entity);
        await transaction.CommitAsync(cancellationToken);
    }
}
