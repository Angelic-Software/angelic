using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceLinks
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_id { get; set; } 

    [JsonProperty("linked_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_service_id { get; set; } 

    [JsonProperty("linked_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_service_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}