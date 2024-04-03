using MediatR;

using Payments.Application.Payments.Commands.CreatePayment;
using Payments.Application.Payments.Commands.DeletePayment;
using Payments.Application.Payments.Commands.UpdatePayment;
using Payments.Application.Payments.Queries.GetPayment;
using Payments.Application.Payments.Queries.GetPayments;
using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Endpoints;

public static class PaymentEndpoints
{
    public static RouteGroupBuilder MapPayment(this RouteGroupBuilder group) =>
        group.MapGroup(
            "payment",
            x => x
                 .MapGet(
                     "",
                     (ISender sender, [AsParameters] GetPaymentsQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get payments"))
                 .MapGet(
                     "{id:guid}",
                     (ISender sender, [AsParameters] GetPaymentQuery query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Get payment by id"))
                 .MapPost(
                     "",
                     (ISender sender, [AsParameters] CreatePaymentCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Create payment"))
                 .MapDelete(
                     "",
                     (
                         ISender sender,
                         [AsParameters] DeletePaymentCommand query,
                         CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Delete payment"))
                 .MapPut(
                     "",
                     (ISender sender, [AsParameters] UpdatePaymentCommand query, CancellationToken cancellationToken) =>
                         sender.Send(query, cancellationToken),
                     c => c.WithSummary("Update payment")));
}
