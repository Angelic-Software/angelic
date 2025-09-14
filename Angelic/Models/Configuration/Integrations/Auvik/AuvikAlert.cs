using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Auvik;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AuvikAlert
{
    [JsonProperty("entityId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityId { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("alertStatusString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertStatusString { get; set; } 

    [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertId { get; set; } 

    [JsonProperty("alertName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertName { get; set; } 

    [JsonProperty("entityName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } 

    [JsonProperty("companyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyName { get; set; } 

    [JsonProperty("entityType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityType { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("alertStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AlertStatus { get; set; } 

    [JsonProperty("alertDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertDescription { get; set; } 

    [JsonProperty("alertSeverityString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertSeverityString { get; set; } 

    [JsonProperty("alertSeverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AlertSeverity { get; set; } 

    [JsonProperty("companyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyId { get; set; } 

    [JsonProperty("correlationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CorrelationId { get; set; } 

}