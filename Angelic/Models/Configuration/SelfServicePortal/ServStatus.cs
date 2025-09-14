using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ServStatus
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("message_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageInternal { get; set; } 

    [JsonProperty("message_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessagePublic { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("lastcheck", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastCheck { get; set; } 

    [JsonProperty("lastok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastOk { get; set; } 

    [JsonProperty("lastfailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastFailed { get; set; } 

    [JsonProperty("okcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OkCount { get; set; } 

    [JsonProperty("failedcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FailedCount { get; set; } 

    [JsonProperty("lastemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastEmail { get; set; } 

    [JsonProperty("totaldownmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalDownMins { get; set; } 

    [JsonProperty("totaldowninstances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalDownInstances { get; set; } 

    [JsonProperty("message_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageInternalHtml { get; set; } 

    [JsonProperty("message_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessagePublicHtml { get; set; } 

    [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusTicketStartDate { get; set; } 

    [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusTicketEndDate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? UniqueId { get; set; } 

}