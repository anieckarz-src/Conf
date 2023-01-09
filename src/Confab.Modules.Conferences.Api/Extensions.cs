using System.Runtime.CompilerServices;
using Confab.Modules.Conferences.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Confab.Modules.Conferences.Api;

public static class Extensions
{
    public static IServiceCollection AddConferences(this IServiceCollection services)
    {
        services.AddCore();
        
        return services;
    }
}
