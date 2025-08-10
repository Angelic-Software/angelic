using RestSharp;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options; // For .Select and .Join

namespace Angelic.Client;

internal class TokenResponse
{
    [System.Text.Json.Serialization.JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("token_type")]
    public string TokenType { get; set; } = string.Empty;
}

internal class AngelicTokenService(IOptionsSnapshot<AngelicClientOptions> angelicClientOptions) : IAngelicTokenService
{
    private readonly string haloUrl = angelicClientOptions.Value.HaloBaseUrl;
    private readonly string haloClientId = angelicClientOptions.Value.HaloClientId;
    private readonly string haloClientSecret = angelicClientOptions.Value.HaloClientSecret;
    private readonly string[] haloScopes = angelicClientOptions.Value.HaloApiScopes;
    

    public async Task<string> GetTokenAsync()
    {
        if (string.IsNullOrWhiteSpace(haloUrl) ||
            string.IsNullOrWhiteSpace(haloClientId) ||
            string.IsNullOrWhiteSpace(haloClientSecret))
        {
            throw new InvalidOperationException("One or more Halo API configuration values (Url, ClientId, ClientSecret) are missing or empty.");
        }
        
        RestClient restClient = new(haloUrl);
        RestRequest request = new("auth/token", Method.Post);
        
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

        request.AddParameter("grant_type", "client_credentials");
        request.AddParameter("client_id", haloClientId);
        request.AddParameter("client_secret", haloClientSecret);
        request.AddParameter("scope", string.Join(" ", haloScopes));

        try
        {
            RestResponse<TokenResponse> response = await restClient.ExecuteAsync<TokenResponse>(request);

            // Check for successful response
            if (!response.IsSuccessful)
            {
                throw new HttpRequestException($"Error getting token from HaloPSA: {response.ErrorMessage ?? response.Content}");
            }
            if (response.Data?.AccessToken is null)
            {
                throw new InvalidOperationException("Access token not found in the response.");
            }

            return response.Data.AccessToken;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while fetching token with RestSharp: {e.Message}");
            throw;
        }
    }
}