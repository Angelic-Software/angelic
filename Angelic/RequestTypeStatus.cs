using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RequestTypeStatus
{
    [JsonProperty("ticketype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticketype_id { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tickettype_name { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status_id { get; set; } 

    [JsonProperty("status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Status_guid { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_name { get; set; } 

    [JsonProperty("tickettype_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_group_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}