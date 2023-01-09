using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace Confab.Modules.Conferences.Core;

public static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}
