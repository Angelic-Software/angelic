using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Custom;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record CustomIntegrationMethodValueMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("methodvalue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MethodValueId { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Input { get; set; } 

    [JsonProperty("output", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Output { get; set; } 

}