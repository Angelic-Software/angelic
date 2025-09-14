using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Adobe.AdobeAcrobat;

[HasEndpoint("AdobeAcrobatDetails")]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AdobeAcrobatDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("access_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccessKey { get; set; }

    [JsonProperty("secret_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SecretKey { get; set; }

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; }

    [JsonProperty("client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientSecret { get; set; }
}
