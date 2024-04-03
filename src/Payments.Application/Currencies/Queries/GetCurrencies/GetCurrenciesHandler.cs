using MediatR;

namespace Payments.Application.Currencies.Queries.GetCurrencies;

public record GetCurrenciesHandler : IRequestHandler<GetCurrenciesQuery, ICollection<Currency>>
{
    public Task<ICollection<Currency>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
