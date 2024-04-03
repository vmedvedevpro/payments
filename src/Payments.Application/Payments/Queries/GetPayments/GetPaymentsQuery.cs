namespace Payments.Application.Payments.Queries.GetPayments;

public record GetPaymentsQuery() : IRequest<ICollection<Payment>>;
