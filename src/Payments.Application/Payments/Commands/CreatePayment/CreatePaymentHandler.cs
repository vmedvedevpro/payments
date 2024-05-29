using AutoMapper;

using Payments.Application.Common.Interfaces;

namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentHandler(IRepository Repository, IMapper Mapper) : IRequestHandler<CreatePaymentCommand, Guid>
{
    public async Task<Guid> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = Mapper.Map<Payment>(request.Payment);

        await using var transaction = await Repository.BeginTransactionAsync<Payment>(cancellationToken);
        transaction.Add(entity);
        await transaction.CommitAsync(cancellationToken);
        return entity.Id;
    }
}
