using MediatR;

namespace Payments.Application.Currencies.Queries.GetCurrencies;

public record GetCurrenciesQuery : IRequest<ICollection<Currency>>;
