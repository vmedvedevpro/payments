namespace Payments.Application.PaymentSystems.Commands.DeletePaymentSystem;

public record DeletePaymentSystemCommand : IRequest
{
    public Guid Id { get; init; }
}
