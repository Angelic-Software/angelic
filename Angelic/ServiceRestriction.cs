using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_category_id { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("data_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Data_id { get; set; } 

    [JsonProperty("svrdata_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Svrdata_guid { get; set; } 

    [JsonProperty("data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Data_name { get; set; } 

    [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_name { get; set; } 

    [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_access { get; set; } 

    [JsonProperty("data_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Data_string { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}