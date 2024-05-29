using FluentValidation;

namespace Payments.WebApi.Common.Extensions;

public static class ValidationExceptionExtensions
{
    public static string GetErrorMessage(this ValidationException exception) =>
        $"Validation errors: {string.Join(", ", exception.Errors.Select(x => x.ErrorMessage))}";
}
