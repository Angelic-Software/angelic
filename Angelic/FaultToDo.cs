using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultToDo
{
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("done", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Done { get; set; } 

    [JsonProperty("done_by_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Done_by_id { get; set; } 

    [JsonProperty("done_by_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Done_by_name { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("actual_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Actual_start { get; set; } 

    [JsonProperty("actual_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Actual_end { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("addedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addedby { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_name { get; set; } 

    [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_seq { get; set; } 

}