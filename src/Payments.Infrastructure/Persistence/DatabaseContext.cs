using System.Reflection;

using Microsoft.EntityFrameworkCore;

namespace Payments.Infrastructure.Persistence;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<Payment> Payments { get; set; }

    public DbSet<PaymentSystem> PaymentSystems { get; set; }

    public DbSet<Currency> Currencies { get; set; }

    public DbSet<CurrencyGroup> CurrencyGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
