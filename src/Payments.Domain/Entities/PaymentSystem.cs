using Payments.Domain.Entities.Base;

namespace Payments.Domain.Entities;

public class PaymentSystem : EntityBase
{
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public ICollection<Currency> Currencies { get; set; } = [];

    public ICollection<Payment> Payments { get; set; } = [];
}
