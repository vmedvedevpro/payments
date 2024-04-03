using MediatR;

using Payments.Application.Currencies.Commands.CreateCurrency;
using Payments.Application.Currencies.Commands.DeleteCurrency;
using Payments.Application.Currencies.Commands.UpdateCurrency;
using Payments.Application.Currencies.Queries.GetCurrencies;
using Payments.Application.Currencies.Queries.GetCurrency;
using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Endpoints;

public static class CurrencyEndpoints
{
    public static RouteGroupBuilder MapCurrency(this RouteGroupBuilder group) =>
        group.MapGroup(
            "currency",
            x => x
                 .MapGet(
                     "",
                     (ISender sender, [AsParameters] GetCurrenciesQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get all currencies"))
                 .MapGet(
                     "{id:guid}",
                     (ISender sender, [AsParameters] GetCurrencyQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get currency by id"))
                 .MapPost(
                     "",
                     (ISender sender, [AsParameters] CreateCurrencyCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Create currency"))
                 .MapDelete(
                     "",
                     (ISender sender, [AsParameters] DeleteCurrencyCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Delete currency"))
                 .MapPut(
                     "",
                     (ISender sender, [AsParameters] UpdateCurrencyCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Update currency")));
}
