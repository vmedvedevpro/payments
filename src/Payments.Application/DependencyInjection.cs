using System.Reflection;

using FluentValidation;

using Microsoft.Extensions.DependencyInjection;

namespace Payments.Application;

public static class DependencyInjection
{
    private static Assembly Assembly => Assembly.GetExecutingAssembly();

    public static IServiceCollection AddApplication(this IServiceCollection services) =>
        services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(Assembly); })
                .AddAutoMapper(Assembly)
                .AddValidatorsFromAssembly(Assembly);
}
