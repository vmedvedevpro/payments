using MediatR;

namespace Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;

public record CreateCurrencyGroupCommand : IRequest
{
    public CurrencyGroup CurrencyGroup { get; set; } = default!;
}
