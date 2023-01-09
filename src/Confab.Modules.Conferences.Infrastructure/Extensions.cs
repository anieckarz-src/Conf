using Confab.Modules.Conferences.Core.Policies;
using Confab.Modules.Conferences.Core.Repositories;
using Confab.Modules.Conferences.Infrastructure.EF.Repositories;
using Confab.Modules.Conferences.Infrastructure.Policies;
using Microsoft.Extensions.DependencyInjection;

namespace Confab.Modules.Conferences.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IHostRepository, HostRepository>();
        services.AddSingleton<IHostDeletionPolicy, HostDeletionPolicy>();
        services.AddSingleton<IConferenceDeletionPolicy, ConferenceDeletionPolicy>();
        
        return services;
    }
}