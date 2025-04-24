using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GoogleBusinessReviewReply
{
    [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment { get; set; } 

    [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdateTime { get; set; } 

}