using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkflowHistory
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("moved_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moved_from { get; set; } 

    [JsonProperty("moved_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moved_to { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Flow_id { get; set; } 

    [JsonProperty("moved_from_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moved_from_stage { get; set; } 

    [JsonProperty("moved_to_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moved_to_stage { get; set; } 

    [JsonProperty("moved_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Moved_date { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Target_date { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Target_hours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_hours { get; set; } 

    [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Target_met { get; set; } 

    [JsonProperty("override_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Override_date { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_id { get; set; } 

}