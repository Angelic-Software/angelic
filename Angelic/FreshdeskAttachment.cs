using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskAttachment
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Content_type { get; set; } 

    [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Size { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("attachment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Attachment_url { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Created_at { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Updated_at { get; set; } 

}