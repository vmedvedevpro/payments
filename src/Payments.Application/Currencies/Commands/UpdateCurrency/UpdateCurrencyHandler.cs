using MediatR;

namespace Payments.Application.Currencies.Commands.UpdateCurrency;

public record UpdateCurrencyHandler : IRequestHandler<UpdateCurrencyCommand>
{
    public Task Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
