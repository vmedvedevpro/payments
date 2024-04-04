using Microsoft.EntityFrameworkCore;

using Payments.Infrastructure.Persistence;

namespace Payments.WebApi.Common.Extensions;

public static class WebApplicationExtensions
{
    public static async Task MigrateDatabaseAsync(this WebApplication app, CancellationToken cancellationToken)
    {
        await using var scope = app.Services.CreateAsyncScope();
        await scope.ServiceProvider.GetRequiredService<DatabaseContext>().Database.MigrateAsync(cancellationToken);
    }
}
