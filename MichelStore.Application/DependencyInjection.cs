using Microsoft.Extensions.DependencyInjection;

namespace MichelStore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(x =>
        {
            // registra os commands e os handlers
            x.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        return services;
    }
}