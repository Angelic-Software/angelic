using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.OpenIddict;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OpenIddictApplication
{
    [JsonProperty("authorizations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OpenIddictAuthorization>? Authorizations { get; set; } 

    [JsonProperty("clientId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("clientSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientSecret { get; set; } 

    [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConcurrencyToken { get; set; } 

    [JsonProperty("consentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConsentType { get; set; } 

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("permissions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Permissions { get; set; } 

    [JsonProperty("postLogoutRedirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostLogoutRedirectUris { get; set; } 

    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Properties { get; set; } 

    [JsonProperty("redirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUris { get; set; } 

    [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OpenIddictToken>? Tokens { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

}