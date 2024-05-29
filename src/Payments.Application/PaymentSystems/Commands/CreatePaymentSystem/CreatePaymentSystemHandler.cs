using AutoMapper;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public record CreatePaymentSystemHandler(IRepository Repository, IMapper Mapper) : IRequestHandler<CreatePaymentSystemCommand, Guid>
{
    public async Task<Guid> Handle(CreatePaymentSystemCommand request, CancellationToken cancellationToken)
    {
        var entity = Mapper.Map<PaymentSystem>(request.PaymentSystem);

        await using var transaction = await Repository.BeginTransactionAsync<PaymentSystem>(cancellationToken);
        transaction.Add(entity);
        await transaction.CommitAsync(cancellationToken);
        return entity.Id;
    }
}
