using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Snow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SnowLicenseAbstract
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("applicationName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationName { get; set; } 

    [JsonProperty("manufacturerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ManufacturerName { get; set; } 

    [JsonProperty("metric", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Metric { get; set; } 

    [JsonProperty("assignmentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssignmentType { get; set; } 

    [JsonProperty("purchaseDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PurchaseDate { get; set; } 

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quantity { get; set; } 

    [JsonProperty("isIncomplete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIncomplete { get; set; } 

    [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedDate { get; set; } 

    [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedBy { get; set; } 

    [JsonProperty("snowDevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SnowDevice>? SnowDevices { get; set; } 

}