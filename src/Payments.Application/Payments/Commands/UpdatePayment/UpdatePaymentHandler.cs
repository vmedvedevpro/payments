using Payments.Application.Common.Interfaces;

namespace Payments.Application.Payments.Commands.UpdatePayment;

public record UpdatePaymentHandler(IRepository Repository) : IRequestHandler<UpdatePaymentCommand>
{
    public async Task Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Payment>(cancellationToken);
        transaction.Update(request.Payment);
        await transaction.CommitAsync(cancellationToken);
    }
}
