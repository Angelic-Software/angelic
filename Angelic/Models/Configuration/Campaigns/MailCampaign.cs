using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails;
using Angelic.Models.Configuration.Integrations.Mailchimp;
using Angelic.Models.ExternalLinks;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Campaigns;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MailCampaign
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDateTime { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusDesc { get; set; } 

    [JsonProperty("sent_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SentDateTime { get; set; } 

    [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailsSent { get; set; } 

    [JsonProperty("halo_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloCreated { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DistributionList { get; set; } 

    [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxFrom { get; set; } 

    [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxReplyTo { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TypeName { get; set; } 

    [JsonProperty("distribution_list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DistributionListName { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ExternalLinks { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("mailchimp_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpCampaign? MailchimpCampaign { get; set; } 

    [JsonProperty("recipients_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecipientsCount { get; set; } 

    [JsonProperty("create_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateIn { get; set; } 

    [JsonProperty("mailchimp_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailchimpList { get; set; } 

    [JsonProperty("mailchimp_sent_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpSentTo>? MailchimpSentTo { get; set; } 

    [JsonProperty("emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailCampaignEmail>? Emails { get; set; } 

    [JsonProperty("marketing_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingUnsubscribe>? MarketingUnsubscribes { get; set; } 

    [JsonProperty("unsubscribe_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnsubscribeRate { get; set; } 

    [JsonProperty("total_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalUnsubscribes { get; set; } 

    [JsonProperty("total_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalOpens { get; set; } 

    [JsonProperty("unique_open_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UniqueOpenRate { get; set; } 

    [JsonProperty("total_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalClicks { get; set; } 

    [JsonProperty("click_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ClickRate { get; set; } 

    [JsonProperty("top_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TopLinkClick>? TopClicks { get; set; } 

    [JsonProperty("all_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingOpen>? AllClicks { get; set; } 

    [JsonProperty("all_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingOpen>? AllOpens { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_start_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartCode { get; set; } 

    [JsonProperty("_start_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StartCampaign { get; set; } 

    [JsonProperty("_start_campaign_confirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StartCampaignConfirmed { get; set; } 

    [JsonProperty("_cancel_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CancelCampaign { get; set; } 

    [JsonProperty("_end_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndCampaign { get; set; } 

}