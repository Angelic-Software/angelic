using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MileStone
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Target_date { get; set; } 

    [JsonProperty("milestone_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MileStone>? Milestone_dependencies { get; set; } 

    [JsonProperty("dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MileStoneDependency>? Dependencies { get; set; } 

    [JsonProperty("tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaultsMileStone>? Tickets { get; set; } 

    [JsonProperty("_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _complete { get; set; } 

    [JsonProperty("_dateschanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dateschanged { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("start_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Start_days { get; set; } 

    [JsonProperty("target_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Target_days { get; set; } 

    [JsonProperty("_fromtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _fromtemplate { get; set; } 

    [JsonProperty("milestone_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Milestone_value { get; set; } 

    [JsonProperty("processed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Processed_date { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoicenumber { get; set; } 

    [JsonProperty("from_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? From_template_id { get; set; } 

}