using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Syncro;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SyncroAlertProperties
{
    [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceId { get; set; } 

    [JsonProperty("trigger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Trigger { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

}