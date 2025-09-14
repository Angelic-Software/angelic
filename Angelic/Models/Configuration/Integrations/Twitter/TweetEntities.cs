using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Twitter;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TweetEntities
{
    [JsonProperty("hashtags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Hashtags { get; set; } 

    [JsonProperty("symbols", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Symbols { get; set; } 

    [JsonProperty("user_mentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TweetUserMentions>? UserMentions { get; set; } 

    [JsonProperty("urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<object>? Urls { get; set; } 

}