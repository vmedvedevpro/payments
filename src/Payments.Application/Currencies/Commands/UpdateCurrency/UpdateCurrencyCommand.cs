namespace Payments.Application.Currencies.Commands.UpdateCurrency;

public record UpdateCurrencyCommand : IRequest
{
    public Currency Currency { get; set; } = null!;
}
