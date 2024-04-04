using AutoMapper;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Currencies.Commands.CreateCurrency;

public record CreateCurrencyHandler(IRepository Repository, IMapper Mapper) : IRequestHandler<CreateCurrencyCommand, Guid>
{
    public async Task<Guid> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var entity = Mapper.Map<Currency>(request.Currency);

        await using var transaction = await Repository.BeginTransactionAsync<Currency>(cancellationToken);
        transaction.Add(entity);
        await transaction.CommitAsync(cancellationToken);
        return entity.Id;
    }
}
