namespace Payments.Application.PaymentSystems.Commands.DeletePaymentSystem;

public record DeletePaymentSystemHandler : IRequestHandler<DeletePaymentSystemCommand>
{
    public Task Handle(DeletePaymentSystemCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
