namespace Payments.Application.Payments.Commands.CreatePayment;

public class CreatePaymentDto
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public Guid CurrencyId { get; set; }
}
