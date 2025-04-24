using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailCampaign
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("created_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created_datetime { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("status_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_desc { get; set; } 

    [JsonProperty("sent_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Sent_datetime { get; set; } 

    [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emails_sent { get; set; } 

    [JsonProperty("halo_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halo_created { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Distribution_list { get; set; } 

    [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailbox_from { get; set; } 

    [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailbox_replyto { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type_name { get; set; } 

    [JsonProperty("distribution_list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Distribution_list_name { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? External_links { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("mailchimp_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpCampaign? Mailchimp_campaign { get; set; } 

    [JsonProperty("recipients_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recipients_count { get; set; } 

    [JsonProperty("create_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Create_in { get; set; } 

    [JsonProperty("mailchimp_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailchimp_list { get; set; } 

    [JsonProperty("mailchimp_sent_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpSentTo>? Mailchimp_sent_to { get; set; } 

    [JsonProperty("emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailCampaignEmail>? Emails { get; set; } 

    [JsonProperty("marketing_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingUnsubscribe>? Marketing_unsubscribes { get; set; } 

    [JsonProperty("unsubscribe_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unsubscribe_rate { get; set; } 

    [JsonProperty("total_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_unsubscribes { get; set; } 

    [JsonProperty("total_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_opens { get; set; } 

    [JsonProperty("unique_open_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unique_open_rate { get; set; } 

    [JsonProperty("total_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_clicks { get; set; } 

    [JsonProperty("click_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Click_rate { get; set; } 

    [JsonProperty("top_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TopLinkClick>? Top_clicks { get; set; } 

    [JsonProperty("all_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingOpen>? All_clicks { get; set; } 

    [JsonProperty("all_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MarketingOpen>? All_opens { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_start_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _start_code { get; set; } 

    [JsonProperty("_start_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _start_campaign { get; set; } 

    [JsonProperty("_start_campaign_confirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _start_campaign_confirmed { get; set; } 

    [JsonProperty("_cancel_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _cancel_campaign { get; set; } 

    [JsonProperty("_end_campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _end_campaign { get; set; } 

}