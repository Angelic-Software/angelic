using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailCampaignEmail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailcampaign_id { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body_html { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("date_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_sent { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("send_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Send_type { get; set; } 

    [JsonProperty("send_at_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Send_at_datetime { get; set; } 

    [JsonProperty("send_at_timeafter_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Send_at_timeafter_days { get; set; } 

    [JsonProperty("send_at_timeafter_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Send_at_timeafter_hours { get; set; } 

    [JsonProperty("send_at_timeafter_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Send_at_timeafter_mins { get; set; } 

    [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_desc { get; set; } 

    [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public HtmlDesign? Design { get; set; } 

}