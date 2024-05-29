using MediatR;

using Payments.Application.PaymentSystems.Commands.CreatePaymentSystem;
using Payments.Application.PaymentSystems.Commands.DeletePaymentSystem;
using Payments.Application.PaymentSystems.Commands.UpdatePaymentSystem;
using Payments.Application.PaymentSystems.Queries.GetPaymentSystem;
using Payments.Application.PaymentSystems.Queries.GetPaymentSystems;
using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Endpoints;

public static class PaymentSystemEndpoints
{
    public static RouteGroupBuilder MapPaymentSystem(this RouteGroupBuilder group) =>
        group.MapGroup(
            "payment-system",
            x => x
                 .MapGet(
                     "",
                     (ISender sender, [AsParameters] GetPaymentSystemsQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get payment systems"))
                 .MapGet(
                     "{id:guid}",
                     (ISender sender, [AsParameters] GetPaymentSystemQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get payment system by id"))
                 .MapPost(
                     "",
                     (ISender sender, [AsParameters] CreatePaymentSystemCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Create payment system"))
                 .MapDelete(
                     "",
                     (ISender sender, [AsParameters] DeletePaymentSystemCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Delete payment system"))
                 .MapPut(
                     "",
                     (ISender sender, [AsParameters] UpdatePaymentSystemCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Update payment system")));
}
