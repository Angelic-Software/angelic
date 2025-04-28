using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Permalinks
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } 

    [JsonProperty("published_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublishedGuid { get; set; } 

    [JsonProperty("access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccessToken { get; set; } 

    [JsonProperty("publishedlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Publishedlink { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}