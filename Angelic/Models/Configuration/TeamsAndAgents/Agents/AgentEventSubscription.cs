using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentEventSubscription
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("azure_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureIdentifier { get; set; } 

    [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? SubscriptionAction { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionId { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SubscriptionExpiry { get; set; } 

    [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribed { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSubscriptionKey { get; set; } 

    [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoSave { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

}