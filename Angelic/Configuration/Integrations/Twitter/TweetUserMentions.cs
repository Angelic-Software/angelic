using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TweetUserMentions
{
    [JsonProperty("screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScreenName { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IdStr { get; set; } 

}