using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Twitter;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwitterWebhookContent
{
    [JsonProperty("for_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? ForUserId { get; set; } 

    [JsonProperty("user_has_blocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserHasBlocked { get; set; } 

    [JsonProperty("direct_message_events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TwitterEvent>? DirectMessageEvents { get; set; } 

    [JsonProperty("tweet_create_events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tweet>? TweetCreateEvents { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, object?>? Users { get; set; } 

}