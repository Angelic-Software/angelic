using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationRunbookVariable
{
    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("output", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Output { get; set; } 

    [JsonProperty("method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method_id { get; set; } 

    [JsonProperty("method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Method_name { get; set; } 

    [JsonProperty("step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Step { get; set; } 

    [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Step_name { get; set; } 

    [JsonProperty("persist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Persist { get; set; } 

    [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapping_type { get; set; } 

    [JsonProperty("object_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Object_mapping { get; set; } 

    [JsonProperty("variable_name_root_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Variable_name_root_override { get; set; } 

}