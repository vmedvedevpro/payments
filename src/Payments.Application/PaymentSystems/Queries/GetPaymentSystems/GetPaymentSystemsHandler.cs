namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystems;

public record GetPaymentSystemsHandler : IRequestHandler<GetPaymentSystemsQuery, ICollection<PaymentSystem>>
{
    public Task<ICollection<PaymentSystem>> Handle(GetPaymentSystemsQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
