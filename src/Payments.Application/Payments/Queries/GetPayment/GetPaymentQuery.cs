namespace Payments.Application.Payments.Queries.GetPayment;

public record GetPaymentQuery : IRequest<Payment?>
{
    public Guid Id { get; set; }
}
