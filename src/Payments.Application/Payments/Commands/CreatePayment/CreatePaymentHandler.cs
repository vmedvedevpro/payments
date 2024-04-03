namespace Payments.Application.Payments.Commands.CreatePayment;

public record CreatePaymentHandler : IRequestHandler<CreatePaymentCommand>
{
    public Task Handle(CreatePaymentCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
