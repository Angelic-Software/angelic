using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Ticket;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketToDo
{
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("done", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Done { get; set; } 

    [JsonProperty("done_by_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DoneById { get; set; } 

    [JsonProperty("done_by_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DoneByName { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("actual_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ActualStart { get; set; } 

    [JsonProperty("actual_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ActualEnd { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("addedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addedby { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; } 

    [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupSeq { get; set; } 

}