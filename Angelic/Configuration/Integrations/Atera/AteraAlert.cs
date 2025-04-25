using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Atera;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AteraAlert
{
    [JsonProperty("alertID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AlertId { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Code { get; set; } 

    [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Source { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Severity { get; set; } 

    [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created { get; set; } 

    [JsonProperty("snoozedEndDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SnoozedEndDate { get; set; } 

    [JsonProperty("deviceGuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceGuid { get; set; } 

    [JsonProperty("archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Archived { get; set; } 

    [JsonProperty("alertCategoryID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertCategoryId { get; set; } 

    [JsonProperty("archivedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ArchivedDate { get; set; } 

    [JsonProperty("alertMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertMessage { get; set; } 

    [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceName { get; set; } 

    [JsonProperty("customerID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomerId { get; set; } 

    [JsonProperty("customerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerName { get; set; } 

}