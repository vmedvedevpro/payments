using FluentValidation;

using Microsoft.AspNetCore.Diagnostics;

using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Middlewares;

public record ValidationExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if (exception is not ValidationException validationException) return false;

        httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        await httpContext.Response.WriteAsync(validationException.GetErrorMessage(), cancellationToken);
        return true;
    }
}
