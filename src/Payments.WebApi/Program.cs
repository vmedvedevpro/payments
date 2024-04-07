using System.Text.Json.Serialization;

using Microsoft.AspNetCore.Mvc;

using Payments.Application;
using Payments.Infrastructure;
using Payments.WebApi.Common.Extensions;
using Payments.WebApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
       .AddJsonFile("appsettings.json", true, true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true)
       .AddEnvironmentVariables()
       .AddUserSecrets<Program>(true);

builder.Services.AddEndpointsApiExplorer()
       .AddSwaggerGen(o => { o.SupportNonNullableReferenceTypes(); })
       .ConfigureHttpJsonOptions(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()))
       .Configure<JsonOptions>(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services
       .AddApplication()
       .AddInfrastructure(builder.Configuration);

var app = builder.Build();

await app.MigrateDatabaseAsync(app.Lifetime.ApplicationStopping);

if (app.Environment.IsDevelopment())
    app.UseSwagger()
       .UseSwaggerUI();

app.UseMiddleware<ApiExceptionMiddleware>();
app.UseHttpsRedirection()
   .UseRouting()
   .UseEndpoints(x => x.MapEndpoints());

app.Run();
