using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpRecipients
{
    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? List_id { get; set; } 

    [JsonProperty("list_is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? List_is_active { get; set; } 

    [JsonProperty("list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? List_name { get; set; } 

    [JsonProperty("segment_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Segment_text { get; set; } 

    [JsonProperty("recipient_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recipient_count { get; set; } 

    [JsonProperty("segment_opts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSegment_Opts? Segment_opts { get; set; } 

}