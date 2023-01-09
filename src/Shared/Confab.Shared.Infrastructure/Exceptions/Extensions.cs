using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Confab.Shared.Infrastructure.Exceptions;

internal static class Extensions
{
    public static IServiceCollection AddExceptionMiddleware(this IServiceCollection services)
        => services
            .AddScoped<ExceptionMiddleware>()
            .AddSingleton<IExceptionToResponseMapper,ExceptionToResponseMapper>()
            .AddSingleton<IExceptionCompositionRoot,ExceptionCompositionRoot>();

    public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<ExceptionMiddleware>();
}