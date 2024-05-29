using MediatR;

using Payments.Application.CurrencyGroups.Commands.CreateCurrencyGroup;
using Payments.Application.CurrencyGroups.Commands.DeleteCurrencyGroup;
using Payments.Application.CurrencyGroups.Commands.UpdateCurrencyGroup;
using Payments.Application.CurrencyGroups.Queries.GetCurrencyGroup;
using Payments.Application.CurrencyGroups.Queries.GetCurrencyGroups;
using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Endpoints;

public static class CurrencyGroupEndpoints
{
    public static RouteGroupBuilder MapCurrencyGroup(this RouteGroupBuilder group) =>
        group.MapGroup(
            "currency-group",
            x => x
                 .MapGet(
                     "{id:guid}",
                     (ISender sender, [AsParameters] GetCurrencyGroupQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get currency group by id"))
                 .MapGet(
                     "",
                     (ISender sender, [AsParameters] GetCurrencyGroupsQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get all currency groups"))
                 .MapPost(
                     "",
                     (ISender sender, [AsParameters] CreateCurrencyGroupCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Create currency group"))
                 .MapDelete(
                     "",
                     (ISender sender, [AsParameters] DeleteCurrencyGroupCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Delete currency group"))
                 .MapPut(
                     "",
                     (ISender sender, [AsParameters] UpdateCurrencyGroupCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Update currency group")));
}
