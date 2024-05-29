using Payments.Application.Common.Interfaces;

namespace Payments.Application.PaymentSystems.Commands.UpdatePaymentSystem;

public record UpdatePaymentSystemHandler(IRepository Repository) : IRequestHandler<UpdatePaymentSystemCommand>
{
    public async Task Handle(UpdatePaymentSystemCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<PaymentSystem>(cancellationToken);
        transaction.Update(request.PaymentSystem);
        await transaction.CommitAsync(cancellationToken);
    }
}
