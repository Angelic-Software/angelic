using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.Azure.AzureDevOps;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DevOpsWebhook
{
    [JsonProperty("subscriptionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionId { get; set; } 

    [JsonProperty("notificationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotificationId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("eventType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventType { get; set; } 

    [JsonProperty("publisherId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublisherId { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Resource { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsWebhookMessage? Message { get; set; } 

    [JsonProperty("detailedMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsWebhookMessage? DetailedMessage { get; set; } 

    [JsonProperty("resourceContainers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsResourceContainer? ResourceContainers { get; set; } 

    [JsonProperty("resourceVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResourceVersion { get; set; } 

    [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; } 

}