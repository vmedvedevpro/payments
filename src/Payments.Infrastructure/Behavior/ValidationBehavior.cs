using FluentValidation;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace Payments.Infrastructure.Behavior;

public record ValidationBehavior<TRequest, TResponse>(IServiceProvider ServiceProvider) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var validator = ServiceProvider.GetService<IValidator<TRequest>>();
        if (validator != null)
        {
            await validator.ValidateAndThrowAsync(request, cancellationToken);
        }

        var response = await next();
        return response;
    }
}
