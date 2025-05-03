using System.CodeDom.Compiler;
using Angelic.Models.Configuration;
using Newtonsoft.Json;

namespace Angelic.Models;

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
    public int? ConnectionType { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("_connection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConnectionEnabled { get; set; } 

    [JsonProperty("_instructions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Instructions { get; set; } 

    [JsonProperty("_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Model { get; set; } 

    [JsonProperty("_update_tools", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateTools { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}