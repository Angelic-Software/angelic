using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Downtime
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faultid { get; set; } 

    [JsonProperty("fault_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FaultSummary { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("service_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDesc { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdays { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("ended", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ended { get; set; } 

    [JsonProperty("calculated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Calculated { get; set; } 

    [JsonProperty("allday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllDay { get; set; } 

}