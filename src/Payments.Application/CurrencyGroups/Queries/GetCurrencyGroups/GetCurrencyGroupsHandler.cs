using MediatR;

namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroups;

public record GetCurrencyGroupsHandler : IRequestHandler<GetCurrencyGroupsQuery, ICollection<CurrencyGroup>>
{
    public Task<ICollection<CurrencyGroup>> Handle(GetCurrencyGroupsQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
