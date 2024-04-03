namespace Payments.Application.Payments.Commands.UpdatePayment;

public record UpdatePaymentCommand : IRequest
{
    public Payment Payment { get; set; } = default!;
}
