using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.SnelStart;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SnelStartWebhook
{
    [JsonProperty("koppelSleutel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KoppelSleutel { get; set; } 

    [JsonProperty("actionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionType { get; set; } 

    [JsonProperty("referenceKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReferenceKey { get; set; } 

}