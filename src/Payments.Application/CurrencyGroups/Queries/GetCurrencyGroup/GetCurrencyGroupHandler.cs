using MediatR;

using Payments.Application.CurrencyGroups.Quencies.GetCurrencyGroup;

namespace Payments.Application.CurrencyGroups.Queries.GetCurrencyGroup;

public record GetCurrencyGroupHandler : IRequestHandler<GetCurrencyGroupQuery, CurrencyGroup>
{
    public Task<CurrencyGroup> Handle(GetCurrencyGroupQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
