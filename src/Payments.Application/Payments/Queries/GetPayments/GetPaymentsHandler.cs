namespace Payments.Application.Payments.Queries.GetPayments;

public record GetPaymentsHandler() : IRequestHandler<GetPaymentsQuery, ICollection<Payment>>
{
    public Task<ICollection<Payment>> Handle(GetPaymentsQuery request, CancellationToken cancellationToken) =>
        throw new NotImplementedException();
}
