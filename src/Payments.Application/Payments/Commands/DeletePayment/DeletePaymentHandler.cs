namespace Payments.Application.Payments.Commands.DeletePayment;

public record DeletePaymentHandler : IRequestHandler<DeletePaymentCommand>
{
    public Task Handle(DeletePaymentCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
