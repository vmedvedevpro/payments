using MediatR;

namespace Payments.Application.Currencies.Queries.GetCurrency;

public record GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, Currency>
{
    public Task<Currency> Handle(GetCurrencyQuery request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
