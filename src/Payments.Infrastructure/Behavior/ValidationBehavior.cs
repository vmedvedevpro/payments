using FluentValidation;

using MediatR;

namespace Payments.Infrastructure.Behavior;

public record ValidationBehavior<TRequest, TResponse>(IValidator<TRequest>? Validator = default) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (Validator != null)
        {
            await Validator.ValidateAndThrowAsync(request, cancellationToken);
        }

        var response = await next();
        return response;
    }
}
