using CRUDWithCleanArchitectureAndSolid.Application.MappingImplementations;
using CRUDWithCleanArchitectureAndSolid.Application.MappingInterfaces;
using CRUDWithCleanArchitectureAndSolid.Application.UseCaseImplementations;
using CRUDWithCleanArchitectureAndSolid.Application.UseCaseInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDWithCleanArchitectureAndSolid.Application.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddApplicationService (this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductMapper, ProductMapper>();
        return services;
    }
}
