using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSegmentOpts
{
    [JsonProperty("saved_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SavedSegmentId { get; set; } 

    [JsonProperty("prebuilt_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrebuiltSegmentId { get; set; } 

    [JsonProperty("match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Match { get; set; } 

    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Conditions { get; set; } 

}