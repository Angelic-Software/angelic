using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketTypes;

/// <summary>
/// Originally named as AssignSchedule.
/// </summary>
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketTypeLoadBalanceSchedule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("day", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Day { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("assignto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssignToAgentId { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusId { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("last_run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastRunDate { get; set; } 

    [JsonProperty("interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Interval { get; set; } 

    [JsonProperty("paused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Paused { get; set; } 

    [JsonProperty("asslinked_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssLinkedTicketType { get; set; } 

}