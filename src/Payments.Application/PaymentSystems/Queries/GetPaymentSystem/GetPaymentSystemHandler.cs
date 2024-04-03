namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystem;

public record GetPaymentSystemHandler : IRequestHandler<GetPaymentSystemQuery, PaymentSystem>
{
    public Task<PaymentSystem> Handle(GetPaymentSystemQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
