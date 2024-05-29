using Payments.Domain.Entities.Base;

namespace Payments.Domain.Entities;

public class Currency : EntityBase
{
    public string Name { get; set; } = null!;
}
