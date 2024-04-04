using Payments.Application.Common.Interfaces;

namespace Payments.Application.Currencies.Commands.UpdateCurrency;

public record UpdateCurrencyHandler(IRepository Repository) : IRequestHandler<UpdateCurrencyCommand>
{
    public async Task Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<Currency>(cancellationToken);
        transaction.Update(request.Currency);
        await transaction.CommitAsync(cancellationToken);
    }
}
