namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupCommand : IRequest<Guid>
{
    public CreateCurrencyGroupDto CurrencyGroup { get; set; } = default!;
}
