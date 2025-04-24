using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WordpressComObject
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("slug", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Slug { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("post_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Post_count { get; set; } 

    [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parent { get; set; } 

    [JsonProperty("meta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WordpressComMeta? Meta { get; set; } 

}