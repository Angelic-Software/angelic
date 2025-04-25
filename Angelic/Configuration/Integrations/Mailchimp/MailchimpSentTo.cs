using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSentTo
{
    [JsonProperty("email_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailId { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("merge_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpMergeFields? MergeFields { get; set; } 

    [JsonProperty("vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Vip { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("open_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenCount { get; set; } 

    [JsonProperty("last_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastOpen { get; set; } 

    [JsonProperty("absplit_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AbsplitGroup { get; set; } 

    [JsonProperty("gmt_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public float? GmtOffset { get; set; } 

    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ListId { get; set; } 

    [JsonProperty("campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CampaignId { get; set; } 

    [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ListIsActive { get; set; } 

    [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpLinks>? Links { get; set; } 

}