using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceNowAction
{
    [JsonProperty("sys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sys_id { get; set; } 

    [JsonProperty("sys_created_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sys_created_on { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("element_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Element_id { get; set; } 

    [JsonProperty("sys_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sys_tags { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("sys_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sys_created_by { get; set; } 

    [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Element { get; set; } 

    [JsonProperty("halo_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_key { get; set; } 

    [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_client_id { get; set; } 

}