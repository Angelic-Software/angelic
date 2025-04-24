using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Timeslot
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workday_id { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Workday_guid { get; set; } 

    [JsonProperty("bookingtype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bookingtype_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_time { get; set; } 

    [JsonProperty("end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? End_time { get; set; } 

    [JsonProperty("start_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_label { get; set; } 

    [JsonProperty("end_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? End_label { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}