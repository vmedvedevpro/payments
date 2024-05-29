namespace Payments.Application.Currencies.Commands.CreateCurrency;

public record CreateCurrencyCommand : IRequest<Guid>
{
    public CreateCurrencyDto Currency { get; set; } = null!;
}
