using Microsoft.EntityFrameworkCore;

using Npgsql;

using Payments.DatabaseSeeder;
using Payments.Infrastructure.Persistence;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration
       .AddJsonFile("appsettings.json", true, true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true)
       .AddEnvironmentVariables()
       .AddUserSecrets<Program>(true);

builder.Services.AddSingleton<DatabaseSeeder>()
       .AddDbContextFactory<DatabaseContext>(
           o => o.EnableSensitiveDataLogging()
                 .UseNpgsql(new NpgsqlDataSourceBuilder(builder.Configuration.GetConnectionString("Database")).Build()));

var host = builder.Build();

await host.Services.GetRequiredService<DatabaseSeeder>().SeedDatabaseAsync();
