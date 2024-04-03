namespace Payments.Application.Payments.Queries.GetPayment;

public record GetPaymentHandler() : IRequestHandler<GetPaymentQuery, Payment>
{
    public Task<Payment> Handle(GetPaymentQuery request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
