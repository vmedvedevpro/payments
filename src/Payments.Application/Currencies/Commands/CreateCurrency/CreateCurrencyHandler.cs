using MediatR;

namespace Payments.Application.Currencies.Commands.CreateCurrency;

public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand>
{
    public Task Handle(CreateCurrencyCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
