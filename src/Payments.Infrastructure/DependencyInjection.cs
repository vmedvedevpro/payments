using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Npgsql;

using Payments.Application.Common.Interfaces;
using Payments.Infrastructure.Persistence;
using Payments.Infrastructure.Persistence.Repository;

namespace Payments.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDatabase(configuration);

    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var dataSource = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("Database")).Build();
        return services.AddSingleton<IRepository, Repository>()
                       .AddDbContextFactory<DatabaseContext>(o => o.EnableSensitiveDataLogging().UseNpgsql(dataSource));
    }
}
