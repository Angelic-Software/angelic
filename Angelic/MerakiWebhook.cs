using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MerakiWebhook
{
    [JsonProperty("sharedSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SharedSecret { get; set; } 

    [JsonProperty("deviceSerial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceSerial { get; set; } 

    [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceName { get; set; } 

    [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertId { get; set; } 

    [JsonProperty("alertType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertType { get; set; } 

    [JsonProperty("alertTypeId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertTypeId { get; set; } 

    [JsonProperty("alertLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlertLevel { get; set; } 

    [JsonProperty("organizationName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrganizationName { get; set; } 

    [JsonProperty("networkName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NetworkName { get; set; } 

    [JsonProperty("alertData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? AlertData { get; set; } 

    [JsonProperty("networkTags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? NetworkTags { get; set; } 

}