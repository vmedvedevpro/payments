namespace Payments.Application.Payments.Commands.UpdatePayment;

public record UpdatePaymentHandler : IRequestHandler<UpdatePaymentCommand>
{
    public Task Handle(UpdatePaymentCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
