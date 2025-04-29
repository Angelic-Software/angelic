using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Campaigns;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailCampaignEmail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailCampaignId { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BodyHtml { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("date_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateSent { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("send_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SendType { get; set; } 

    [JsonProperty("send_at_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SendAtDateTime { get; set; } 

    [JsonProperty("send_at_timeafter_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SendAtTimeAfterDays { get; set; } 

    [JsonProperty("send_at_timeafter_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SendAtTimeAfterHours { get; set; } 

    [JsonProperty("send_at_timeafter_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SendAtTimeAfterMins { get; set; } 

    [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusDesc { get; set; } 

    [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public HtmlDesign? Design { get; set; } 

}