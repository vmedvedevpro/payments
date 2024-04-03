namespace Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;

public record CreatePaymentSystemHandler : IRequestHandler<CreatePaymentSystemCommand>
{
    public Task Handle(CreatePaymentSystemCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
