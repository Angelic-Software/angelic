using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MicrosoftTeamsMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_id { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_name { get; set; } 

    [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subscription_id { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Subscription_expiry { get; set; } 

    [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribed { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_subscription_key { get; set; } 

    [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dosave { get; set; } 

}