using Payments.Domain.Entities.Base;

namespace Payments.Domain.Entities;

public class CurrencyGroup : EntityBase
{
    public string Name { get; set; } = default!;

    public ICollection<Currency> Currencies { get; set; } = new List<Currency>();
}
