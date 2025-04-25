using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpRecipients
{
    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ListId { get; set; } 

    [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ListIsActive { get; set; } 

    [JsonProperty("list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ListName { get; set; } 

    [JsonProperty("segment_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SegmentText { get; set; } 

    [JsonProperty("recipient_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecipientCount { get; set; } 

    [JsonProperty("segment_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSegmentOpts? SegmentOpts { get; set; } 

}