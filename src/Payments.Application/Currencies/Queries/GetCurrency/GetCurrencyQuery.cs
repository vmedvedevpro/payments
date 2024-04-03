using MediatR;

namespace Payments.Application.Currencies.Queries.GetCurrency;

public record GetCurrencyQuery : IRequest<Currency>
{
    public Guid Id { get; set; }
}
