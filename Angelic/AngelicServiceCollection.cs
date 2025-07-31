using Angelic.Client;
using Microsoft.Extensions.DependencyInjection;

namespace Angelic;

public static class AngelicServiceCollection
{
    public static IServiceCollection AddAngelic(this IServiceCollection services, string haloBaseUrl, string haloClientId, string haloClientSecret, string[] haloScopes)
    {
        // Configure the options directly
        services.Configure<AngelicClientOptions>(options =>
        {
            options.HaloBaseUrl = haloBaseUrl;
            options.HaloClientId = haloClientId;
            options.HaloClientSecret = haloClientSecret;
            options.HaloApiScopes = haloScopes;
        });
        
        services.AddScoped<IAngelicTokenService, AngelicTokenService>();
        services.AddScoped<IAngelicClient, AngelicClient>();
        
        return services;
    }
}