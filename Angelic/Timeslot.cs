using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Timeslot
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdayId { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkdayGuid { get; set; } 

    [JsonProperty("bookingtype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BookingTypeId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartTime { get; set; } 

    [JsonProperty("end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndTime { get; set; } 

    [JsonProperty("start_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartLabel { get; set; } 

    [JsonProperty("end_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndLabel { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}