using MediatR;

namespace Payments.Application.Currencies.Commands.DeleteCurrency;

public record DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand>
{
    public Task Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
