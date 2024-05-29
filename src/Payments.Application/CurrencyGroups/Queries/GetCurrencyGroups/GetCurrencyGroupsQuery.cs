using MediatR;

namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroups;

public record GetCurrencyGroupsQuery() : IRequest<ICollection<CurrencyGroup>>;
