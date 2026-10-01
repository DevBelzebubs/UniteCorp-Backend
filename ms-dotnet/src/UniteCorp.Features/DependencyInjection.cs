using Microsoft.Extensions.DependencyInjection;

public static class FeatureServiceCollectionExtensions
{
    public static IServiceCollection AddFeatures(this IServiceCollection services)
    {
        services.AddScoped<IGeocercaActividadRepository, GeocercaActividadRepository>();
        services.AddScoped<IGeocercaActividadCommandService, GeocercaActividadCommandService>();
        services.AddScoped<IGeocercaActividadQueryService, GeocercaActividadQueryService>();

        return services;
    }
}