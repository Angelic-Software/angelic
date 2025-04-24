using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class VirtualAgent
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connection_type { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("_connection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _connection_enabled { get; set; } 

    [JsonProperty("_instructions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _instructions { get; set; } 

    [JsonProperty("_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _model { get; set; } 

    [JsonProperty("_update_tools", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _update_tools { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}