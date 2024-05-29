namespace Payments.Application.CurrencyGroups.Commands.UpdateCurrencyGroup;

public record UpdateCurrencyGroupCommand : IRequest
{
    public CurrencyGroup CurrencyGroup { get; set; } = null!;
}
