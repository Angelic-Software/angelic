using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DevOpsProject
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? State { get; set; } 

    [JsonProperty("revision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Revision { get; set; } 

    [JsonProperty("visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Visibility { get; set; } 

    [JsonProperty("lastUpdateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdateTime { get; set; } 

}