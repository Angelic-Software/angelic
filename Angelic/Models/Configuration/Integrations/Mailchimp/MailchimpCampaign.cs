using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MailchimpCampaign
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("web_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebId { get; set; } 

    [JsonProperty("parent_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentCampaignId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("create_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreateTime { get; set; } 

    [JsonProperty("archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ArchiveUrl { get; set; } 

    [JsonProperty("long_archive_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LongArchiveUrl { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailsSent { get; set; } 

    [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SendTime { get; set; } 

    [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContentType { get; set; } 

    [JsonProperty("needs_block_refresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NeedsBlockRefresh { get; set; } 

    [JsonProperty("resendable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resendable { get; set; } 

    [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpRecipients? Recipients { get; set; } 

    [JsonProperty("settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSettings? Settings { get; set; } 

    [JsonProperty("variate_settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpVariateSettings? VariateSettings { get; set; } 

    [JsonProperty("tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpTracking? Tracking { get; set; } 

    [JsonProperty("rss_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpRssOpts? RssOpts { get; set; } 

    [JsonProperty("ab_split_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpAbSplitOpts? AbSplitOpts { get; set; } 

    [JsonProperty("social_card", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSocialCard? SocialCard { get; set; } 

    [JsonProperty("report_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpReportSummary? ReportSummary { get; set; } 

    [JsonProperty("delivery_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpDeliveryStatus? DeliveryStatus { get; set; } 

    [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpLinks>? Links { get; set; } 

}