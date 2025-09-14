using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Wordpress;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record WordPressComMeta
{
    [JsonProperty("links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WordPressComLinks? Links { get; set; } 

    [JsonProperty("next_page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NextPage { get; set; } 

    [JsonProperty("wpcom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? WpCom { get; set; } 

}