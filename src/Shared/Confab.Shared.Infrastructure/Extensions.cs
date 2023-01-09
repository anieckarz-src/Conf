using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Confab.Shared.Abstractions;
using Confab.Shared.Infrastructure.Api;
using Confab.Shared.Infrastructure.Services;
using Microsoft.AspNetCore.Http;

namespace Confab.Shared.Infrastructure;


public static class Extensions 
{
    public static IServiceCollection AddGlobalInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IClock, UtcClock>();
        
        services
            .AddControllers()
            .ConfigureApplicationPartManager(x =>
            {
                x.FeatureProviders.Add(new InternalControllerFeatureProvider());
            });
        return services;
    }
    
    public static IApplicationBuilder UseGlobalInfrastructure(this IApplicationBuilder app)
    {
        
        app.UseRouting();
        
        app.UseEndpoints(x =>
        {
            x.MapControllers();
            x.MapGet("/", contect => contect.Response.WriteAsync("Confab " + DateTime.UtcNow));
        });


        return app;
    }
}