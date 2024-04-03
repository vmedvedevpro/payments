using MediatR;

namespace Payments.Application.CurrencyGroups.Quencies.GetCurrencyGroup;

public record GetCurrencyGroupQuery : IRequest<CurrencyGroup>
{
    public Guid Id { get; set; }
}
