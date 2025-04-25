using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.Azure.AzureDelta;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureDeltaReset
{
    [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Result { get; set; } 

}