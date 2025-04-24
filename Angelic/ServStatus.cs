using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServStatus
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("message_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_internal { get; set; } 

    [JsonProperty("message_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_public { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("lastcheck", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcheck { get; set; } 

    [JsonProperty("lastok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastok { get; set; } 

    [JsonProperty("lastfailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastfailed { get; set; } 

    [JsonProperty("okcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Okcount { get; set; } 

    [JsonProperty("failedcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Failedcount { get; set; } 

    [JsonProperty("lastemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastemail { get; set; } 

    [JsonProperty("totaldownmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Totaldownmins { get; set; } 

    [JsonProperty("totaldowninstances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Totaldowninstances { get; set; } 

    [JsonProperty("message_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_internal_html { get; set; } 

    [JsonProperty("message_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_public_html { get; set; } 

    [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_ticket_start_date { get; set; } 

    [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_ticket_end_date { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Uniqueid { get; set; } 

}