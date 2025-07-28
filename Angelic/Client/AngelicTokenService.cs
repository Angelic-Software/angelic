using Microsoft.Extensions.Configuration;

namespace Angelic.Client;

internal class AngelicTokenService(IConfiguration configuration)
{
    private readonly string haloUrl = configuration.GetSection("HaloUrl").Value;
    private readonly string haloClientId = configuration.GetSection("HaloClientId").Value;
    private readonly string haloClientSecret = configuration.GetSection("HaloClientSecret").Value;
    private readonly IEnumerable<KeyValuePair<string, string?>> scope = configuration.GetSection("Scope").AsEnumerable();
    
    internal async Task<string> GetTokenAsync()
    {
        
    }
}