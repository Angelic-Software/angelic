using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class XeroWebhookEvent
{
    [JsonProperty("resourceUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResourceUrl { get; set; } 

    [JsonProperty("resourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResourceId { get; set; } 

    [JsonProperty("eventDateUtc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EventDateUtc { get; set; } 

    [JsonProperty("eventType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventType { get; set; } 

    [JsonProperty("eventCategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventCategory { get; set; } 

    [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenantType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantType { get; set; } 

    [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? ResourceObject { get; set; } 

    [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public RelayEventType? EventTypeNum { get; set; } 

    [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public RelayEventCategory? EventCategoryNum { get; set; } 

}