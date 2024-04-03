namespace Payments.Application.PaymentSystems.Queries.GetPaymentSystems;

public record GetPaymentSystemsQuery() : IRequest<ICollection<PaymentSystem>>;
