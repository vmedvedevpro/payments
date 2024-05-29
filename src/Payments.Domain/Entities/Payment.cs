using Payments.Domain.Entities.Base;
using Payments.Domain.Enum;

namespace Payments.Domain.Entities;

public class Payment : EntityBase
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public PaymentStatus Status { get; set; }

    public Guid CurrencyId { get; set; }

    public Currency Currency { get; set; } = null!;
}
