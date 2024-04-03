using Payments.Application;
using Payments.WebApi.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
       .AddJsonFile("appsettings.json", true, true)
       .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true)
       .AddEnvironmentVariables()
       .AddUserSecrets<Program>(true);

builder.Services.AddEndpointsApiExplorer()
       .AddSwaggerGen();

builder.Services.AddApplication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseSwagger()
       .UseSwaggerUI();

app.UseHttpsRedirection()
   .UseRouting()
   .UseEndpoints(x => x.MapEndpoints());

app.Run();
