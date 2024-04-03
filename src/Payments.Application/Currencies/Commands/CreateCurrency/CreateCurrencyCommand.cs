using MediatR;

namespace Payments.Application.Currencies.Commands.CreateCurrency;

public record CreateCurrencyCommand : IRequest
{
    public Currency Currency { get; set; } = default!;
}
