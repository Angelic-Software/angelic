using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpRssOpts
{
    [JsonProperty("feed_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FeedUrl { get; set; } 

    [JsonProperty("frequency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Frequency { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Schedule? Schedule { get; set; } 

    [JsonProperty("last_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastSent { get; set; } 

    [JsonProperty("constrain_rss_img", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConstrainRssImg { get; set; } 

}