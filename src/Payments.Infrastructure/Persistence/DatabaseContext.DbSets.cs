using Microsoft.EntityFrameworkCore;

namespace Payments.Infrastructure.Persistence;

public partial class DatabaseContext
{
    public DbSet<Payment> Payments { get; set; }

    public DbSet<PaymentSystem> PaymentSystems { get; set; }

    public DbSet<Currency> Currencies { get; set; }

    public DbSet<CurrencyGroup> CurrencyGroups { get; set; }
}
