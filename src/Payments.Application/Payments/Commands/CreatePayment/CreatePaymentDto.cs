namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentDto
{
    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public Guid PaymentSystemId { get; set; }

    public Guid CurrencyId { get; set; }
}
