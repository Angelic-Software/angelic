using Microsoft.Extensions.Configuration;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;

namespace Angelic.Client;

public class AngelicClient<T>(IConfiguration configuration) : IAngelicClient where T : class, new()
{
    private readonly string haloUrl = configuration.GetSection("HaloUrl").Value;
    private readonly string haloClientId = configuration.GetSection("HaloClientId").Value;
    private readonly string haloClientSecret = configuration.GetSection("HaloClientSecret").Value;
    private readonly IEnumerable<KeyValuePair<string, string?>> scope = configuration.GetSection("Scope").AsEnumerable();
    
    public async Task<T> GetAsync<T>(int id, Dictionary<string, string> queryParams = null)
    {
        IAuthenticator authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator("yadadadasdd");
        
        var clientOpts = new RestClientOptions
        {
            BaseUrl = new Uri(haloUrl),
            
        };
        var client = new RestClient();
    }

    public async Task<T> PostAsync<T>(T body)
    {
        throw new NotImplementedException();
    }

    public async Task<T> DeleteAsync<T>(int id)
    {
        throw new NotImplementedException();
    }
}

