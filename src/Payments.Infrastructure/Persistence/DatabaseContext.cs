using System.Reflection;

using Microsoft.EntityFrameworkCore;

namespace Payments.Infrastructure.Persistence;

public partial class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
