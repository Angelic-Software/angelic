using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpCampaign
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("web_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Web_id { get; set; } 

    [JsonProperty("parent_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Parent_campaign_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("create_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Create_time { get; set; } 

    [JsonProperty("archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Archive_url { get; set; } 

    [JsonProperty("long_archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Long_archive_url { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emails_sent { get; set; } 

    [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Send_time { get; set; } 

    [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Content_type { get; set; } 

    [JsonProperty("needs_block_refresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Needs_block_refresh { get; set; } 

    [JsonProperty("resendable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resendable { get; set; } 

    [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpRecipients? Recipients { get; set; } 

    [JsonProperty("settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSettings? Settings { get; set; } 

    [JsonProperty("variate_settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpVariate_Settings? Variate_settings { get; set; } 

    [JsonProperty("tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpTracking? Tracking { get; set; } 

    [JsonProperty("rss_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpRss_Opts? Rss_opts { get; set; } 

    [JsonProperty("ab_split_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpAb_Split_Opts? Ab_split_opts { get; set; } 

    [JsonProperty("social_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSocial_Card? Social_card { get; set; } 

    [JsonProperty("report_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpReport_Summary? Report_summary { get; set; } 

    [JsonProperty("delivery_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpDelivery_Status? Delivery_status { get; set; } 

    [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Mailchimp_Links>? _links { get; set; } 

}