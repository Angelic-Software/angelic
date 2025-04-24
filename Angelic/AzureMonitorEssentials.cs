using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureMonitorEssentials
{
    [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertId { get; set; } 

    [JsonProperty("alertRule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertRule { get; set; } 

    [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Severity { get; set; } 

    [JsonProperty("signalType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SignalType { get; set; } 

    [JsonProperty("monitorCondition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MonitorCondition { get; set; } 

    [JsonProperty("monitoringService", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MonitoringService { get; set; } 

    [JsonProperty("alertTargetIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? AlertTargetIds { get; set; } 

    [JsonProperty("configurationItems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ConfigurationItems { get; set; } 

    [JsonProperty("originAlertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAlertId { get; set; } 

    [JsonProperty("firedDateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FiredDateTime { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("essentialsVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EssentialsVersion { get; set; } 

    [JsonProperty("alertContextVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertContextVersion { get; set; } 

}