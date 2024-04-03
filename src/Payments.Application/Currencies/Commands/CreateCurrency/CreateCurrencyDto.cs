namespace Payments.Application.Currencies.Commands.CreateCurrency;

public record CreateCurrencyDto
{
    public string Name { get; init; } = default!;
}
