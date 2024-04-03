namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystem;

public record GetPaymentSystemQuery : IRequest<PaymentSystem>
{
    public Guid Id { get; set; }
}
