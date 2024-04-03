namespace Payments.Application.PaymentSystems.Commands.UpdatePaymentSystem;

public record UpdatePaymentSystemHandler : IRequestHandler<UpdatePaymentSystemCommand>
{
    public Task Handle(UpdatePaymentSystemCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
