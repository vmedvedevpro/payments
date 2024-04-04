namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public record CreatePaymentSystemCommand : IRequest<Guid>
{
    public CreatePaymentSystemDto PaymentSystem { get; set; } = default!;
}
