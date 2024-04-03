namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupDto
{
    public string Name { get; init; } = default!;
}
