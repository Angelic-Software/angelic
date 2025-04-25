using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.OpenIddict;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OpenIddictAuthorization
{
    [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OpenIddictApplication? Application { get; set; } 

    [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConcurrencyToken { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Properties { get; set; } 

    [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Scopes { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OpenIddictToken>? Tokens { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

}