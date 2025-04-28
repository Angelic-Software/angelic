using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Ninja;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NinjaAlert
{
    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Uid { get; set; } 

    [JsonProperty("deviceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceId { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreateTime { get; set; } 

    [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UpdateTime { get; set; } 

    [JsonProperty("sourceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceType { get; set; } 

    [JsonProperty("sourceConfigUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceConfigUid { get; set; } 

    [JsonProperty("sourceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SourceName { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

}