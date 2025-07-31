using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;

namespace Angelic.Client;

public class AngelicClient(IOptionsSnapshot<AngelicClientOptions> angelicClientOptions, IAngelicTokenService tokenService) : IAngelicClient
{
    private readonly string haloUrl = angelicClientOptions.Value.HaloBaseUrl;
    
    public async Task<T> GetAsync<T>(string endpoint, Dictionary<string, string> queryParams = null)
    {
        string token = await tokenService.GetTokenAsync();
        IAuthenticator authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token);
        
        RestClientOptions clientOpts = new RestClientOptions
        {
            BaseUrl = new Uri(haloUrl),
            Authenticator = authenticator
        };
        RestClient client = new RestClient(clientOpts);

        RestRequest request = new RestRequest(endpoint, Method.Get);
        foreach (KeyValuePair<string, string?> param in queryParams)
        {
            request.AddQueryParameter(param.Key, param.Value);
        }
        request.AddHeader("Content-Type", "application/json");

        RestResponse<T> response = await client.ExecuteGetAsync<T>(request);
        return response.Data;
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

