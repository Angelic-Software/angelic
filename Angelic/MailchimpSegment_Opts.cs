using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSegment_Opts
{
    [JsonProperty("saved_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Saved_segment_id { get; set; } 

    [JsonProperty("prebuilt_segment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Prebuilt_segment_id { get; set; } 

    [JsonProperty("match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Match { get; set; } 

    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Conditions { get; set; } 

}