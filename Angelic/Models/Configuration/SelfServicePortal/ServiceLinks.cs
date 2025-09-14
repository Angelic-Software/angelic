using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ServiceLinks
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("linked_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedServiceId { get; set; } 

    [JsonProperty("linked_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedServiceName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}