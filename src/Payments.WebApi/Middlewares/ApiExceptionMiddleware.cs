using FluentValidation;

using Payments.WebApi.Common.Extensions;

namespace Payments.WebApi.Middlewares;

public record ApiExceptionMiddleware(RequestDelegate Next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await Next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = StatusCodes.Status500InternalServerError;
        var exceptionMessage = exception.Message;

        if (exception is ValidationException validationException)
        {
            code = StatusCodes.Status400BadRequest;
            exceptionMessage = validationException.GetErrorMessage();
        }
        else
        {
            exceptionMessage = exception.InnerException?.Message ?? exceptionMessage;
        }

        context.Response.StatusCode = code;

        return context.Response.WriteAsync(exceptionMessage);
    }
}
