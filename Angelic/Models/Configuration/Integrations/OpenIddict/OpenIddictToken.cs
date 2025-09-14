using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.OpenIddict;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record OpenIddictToken
{
    [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OpenIddictApplication? Application { get; set; } 

    [JsonProperty("authorization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public OpenIddictAuthorization? Authorization { get; set; } 

    [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConcurrencyToken { get; set; } 

    [JsonProperty("creationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreationDate { get; set; } 

    [JsonProperty("expirationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpirationDate { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Payload { get; set; } 

    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Properties { get; set; } 

    [JsonProperty("referenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReferenceId { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

}