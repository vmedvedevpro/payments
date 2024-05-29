using Payments.Domain.Entities.Base;

namespace Payments.Domain.Entities;

public class CurrencyGroup : EntityBase
{
    public string Name { get; set; } = null!;

    public ICollection<Currency> Currencies { get; set; } = [];
}
