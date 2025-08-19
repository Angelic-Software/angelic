using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceAvailability
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("service_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDesc { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("totalhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalHours { get; set; } 

    [JsonProperty("downhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DownHours { get; set; } 

    [JsonProperty("targetmet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TargetMet { get; set; } 

}