using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Google;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record GoogleBusinessAnswer
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public GoogleReviewer? Author { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreateTime { get; set; } 

    [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdateTime { get; set; } 

}