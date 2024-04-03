namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public record CreatePaymentSystemDto
{
    public string Name { get; set; } = default!;

    public string? Description { get; set; }
}
