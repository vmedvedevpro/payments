namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupCommand : IRequest
{
    public CreateCurrencyGroupDto CurrencyGroup { get; set; } = default!;
}
