using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TweetUser
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("id_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IdStr { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScreenName { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("profile_image_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfileImageUrl { get; set; } 

    [JsonProperty("profile_image_url_https", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfileImageUrlHttps { get; set; } 

}