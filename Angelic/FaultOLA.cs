using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultOLA
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fault_id { get; set; } 

    [JsonProperty("target_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Target_id { get; set; } 

    [JsonProperty("target_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Target_name { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Target_hours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_hours { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Target_date { get; set; } 

    [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Target_met { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaultOLADates>? Dates { get; set; } 

    [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WorkflowTarget? Target { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("pause_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Pause_date { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

}