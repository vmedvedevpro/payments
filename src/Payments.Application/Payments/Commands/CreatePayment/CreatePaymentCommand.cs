namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentCommand() : IRequest
{
    public Payment Payment { get; set; } = default!;
}
