using Payments.Application.Common.Interfaces;

namespace Payments.Application.CurrencyGroups.Commands.UpdateCurrencyGroup;

public record UpdateCurrencyGroupHandler(IRepository Repository) : IRequestHandler<UpdateCurrencyGroupCommand>
{
    public async Task Handle(UpdateCurrencyGroupCommand request, CancellationToken cancellationToken)
    {
        await using var transaction = await Repository.BeginTransactionAsync<CurrencyGroup>(cancellationToken);
        transaction.Update(request.CurrencyGroup);
        await transaction.CommitAsync(cancellationToken);
    }
}
