using Payments.WebApi.Endpoints;

namespace Payments.WebApi.Common.Extensions;

public static class EndpointsRouteGroupBuilderExtensions
{
    public static void MapEndpoints(this IEndpointRouteBuilder builder) =>
        builder.MapGroup("api/v1")
               .MapCurrency();
}
