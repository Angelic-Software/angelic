using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Hubspot;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HubspotWebhook
{
    [JsonProperty("eventId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventId { get; set; } 

    [JsonProperty("subscriptionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionId { get; set; } 

    [JsonProperty("portalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalId { get; set; } 

    [JsonProperty("appId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? AppId { get; set; } 

    [JsonProperty("occurredAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? OccurredAt { get; set; } 

    [JsonProperty("subscriptionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionType { get; set; } 

    [JsonProperty("attemptNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttemptNumber { get; set; } 

    [JsonProperty("objectId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectId { get; set; } 

    [JsonProperty("objectTypeId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectTypeId { get; set; } 

    [JsonProperty("propertyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PropertyName { get; set; } 

    [JsonProperty("propertyValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PropertyValue { get; set; } 

    [JsonProperty("changeSource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChangeSource { get; set; } 

    [JsonProperty("sourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceId { get; set; } 

    [JsonProperty("isSensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSensitive { get; set; } 

    [JsonProperty("changeFlag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChangeFlag { get; set; } 

    [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [Range(0, 3)]
    public int? EventTypeNum { get; set; } 

    [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [Range(0, 7)]
    public int? EventCategoryNum { get; set; } 

}