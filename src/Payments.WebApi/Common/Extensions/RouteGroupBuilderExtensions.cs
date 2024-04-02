using System.Diagnostics.CodeAnalysis;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Payments.WebApi.Common.Extensions;

public static class RouteGroupBuilderExtensions
{
    public static RouteGroupBuilder MapGroup(this RouteGroupBuilder group, string name, Action<RouteGroupBuilder> mapEndpoints)
    {
        mapEndpoints(group.MapGroup(name).WithTags(name).WithOpenApi());
        return group;
    }

    public static RouteGroupBuilder MapPost<TCommand>(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string? path = default,
        Action<RouteHandlerBuilder>? config = default)
        where TCommand : IRequest
    {
        var endpoint = EndpointRouteBuilderExtensions.MapPost(
            group,
            GetPath<TCommand>(path),
            async ([FromBody] TCommand request, IMediator mediator, CancellationToken cancellationToken) =>
                await mediator.Send(request, cancellationToken));
        config?.Invoke(endpoint);
        return group;
    }

    public static RouteGroupBuilder MapPost<TCommand, TResponse>(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string? path = default,
        Action<RouteHandlerBuilder>? config = default)
        where TCommand : IRequest<TResponse>
    {
        var endpoint = EndpointRouteBuilderExtensions.MapPost(
            group,
            GetPath<TCommand>(path),
            ([FromBody] TCommand request, IMediator mediator, CancellationToken cancellationToken) =>
                mediator.Send(request, cancellationToken));
        config?.Invoke(endpoint);
        return group;
    }

    public static RouteGroupBuilder MapPost(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string path,
        Delegate handler,
        Action<RouteHandlerBuilder>? config = default)
    {
        var endpoint = EndpointRouteBuilderExtensions.MapPost(group, path, handler);
        config?.Invoke(endpoint);
        return group;
    }

    public static RouteGroupBuilder MapPut(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string path,
        Delegate handler,
        Action<RouteHandlerBuilder>? config = default)
    {
        var endpoint = EndpointRouteBuilderExtensions.MapPut(group, path, handler);
        config?.Invoke(endpoint);
        return group;
    }

    public static RouteGroupBuilder MapDelete(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string path,
        Delegate handler,
        Action<RouteHandlerBuilder>? config = default)
    {
        var endpoint = EndpointRouteBuilderExtensions.MapDelete(group, path, handler);
        config?.Invoke(endpoint);
        return group;
    }

    public static RouteGroupBuilder MapGet(
        this RouteGroupBuilder group,
        [StringSyntax("Route")]
        string path,
        Delegate handler,
        Action<RouteHandlerBuilder>? config = default)
    {
        var endpoint = EndpointRouteBuilderExtensions.MapGet(group, path, handler);
        config?.Invoke(endpoint);
        return group;
    }

    private static string GetPath<TType>(string? path) => path ?? typeof(TType).Name.Replace("Command", "").Replace("Query", "");
}
