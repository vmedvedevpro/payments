namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentCommand() : IRequest
{
    public CreatePaymentDto Payment { get; set; } = default!;
}
