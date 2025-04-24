using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSentTo
{
    [JsonProperty("email_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_id { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_address { get; set; } 

    [JsonProperty("merge_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpMerge_Fields? Merge_fields { get; set; } 

    [JsonProperty("vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Vip { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("open_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_count { get; set; } 

    [JsonProperty("last_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_open { get; set; } 

    [JsonProperty("absplit_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Absplit_group { get; set; } 

    [JsonProperty("gmt_offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public float? Gmt_offset { get; set; } 

    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? List_id { get; set; } 

    [JsonProperty("campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Campaign_id { get; set; } 

    [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? List_is_active { get; set; } 

    [JsonProperty("_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Mailchimp_Links>? _links { get; set; } 

}