using MichelStore.Domain.Abstractions.Interfaces;
using MichelStore.Domain.Repositories;
using MichelStore.Infrastructure.Data;
using MichelStore.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MichelStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IProductRepository, ProductRepository>();

        return services;
    }
}