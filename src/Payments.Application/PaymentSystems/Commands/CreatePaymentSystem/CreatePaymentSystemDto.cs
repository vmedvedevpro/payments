namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public class CreatePaymentSystemDto
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
