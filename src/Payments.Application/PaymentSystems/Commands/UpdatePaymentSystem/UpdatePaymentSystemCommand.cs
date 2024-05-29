namespace Payments.Application.PaymentSystems.Commands.UpdatePaymentSystem;

public record UpdatePaymentSystemCommand() : IRequest
{
    public PaymentSystem PaymentSystem { get; set; } = null!;
}
