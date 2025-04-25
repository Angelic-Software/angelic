using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Orion;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrionAlert
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Application { get; set; } 

    [JsonProperty("alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertId { get; set; } 

    [JsonProperty("alert_active_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertActiveId { get; set; } 

    [JsonProperty("alert_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertName { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details { get; set; } 

    [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Severity { get; set; } 

    [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetValue { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team { get; set; } 

    [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent { get; set; } 

}