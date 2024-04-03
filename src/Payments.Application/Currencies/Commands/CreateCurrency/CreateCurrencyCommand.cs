namespace Payments.Application.Currencies.Commands.CreateCurrency;

public record CreateCurrencyCommand : IRequest
{
    public CreateCurrencyDto Currency { get; set; } = default!;
}
