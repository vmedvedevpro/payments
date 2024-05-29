namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroup;

public record GetCurrencyGroupQuery : IRequest<CurrencyGroup?>
{
    public Guid Id { get; set; }
}
