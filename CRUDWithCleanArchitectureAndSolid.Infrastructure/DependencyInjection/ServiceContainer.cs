using CRUDWithCleanArchitectureAndSolid.Domain.Interfaces.Products;
using CRUDWithCleanArchitectureAndSolid.Infrastructure.Data;
using CRUDWithCleanArchitectureAndSolid.Infrastructure.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDWithCleanArchitectureAndSolid.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(x =>
            x.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
