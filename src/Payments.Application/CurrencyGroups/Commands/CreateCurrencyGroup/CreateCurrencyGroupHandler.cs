using AutoMapper;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupHandler(IRepository Repository, IMapper Mapper) : IRequestHandler<CreateCurrencyGroupCommand, Guid>
{
    public async Task<Guid> Handle(CreateCurrencyGroupCommand request, CancellationToken cancellationToken)
    {
        var entity = Mapper.Map<CurrencyGroup>(request.CurrencyGroup);

        await using var transaction = await Repository.BeginTransactionAsync<CurrencyGroup>(cancellationToken);
        transaction.Add(entity);
        await transaction.CommitAsync(cancellationToken);
        return entity.Id;
    }
}
