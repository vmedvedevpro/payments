namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentCommand() : IRequest<Guid>
{
    public CreatePaymentDto Payment { get; set; } = default!;
}
