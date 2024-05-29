namespace Payments.Application.Payments.Commands.DeletePayment;

public record DeletePaymentCommand : IRequest
{
    public Guid Id { get; init; }
}
