namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public record CreatePaymentSystemCommand : IRequest
{
    public CreatePaymentSystemDto PaymentSystem { get; set; } = default!;
}
