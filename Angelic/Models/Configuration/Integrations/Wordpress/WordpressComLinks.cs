using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Wordpress;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record WordPressComLinks
{
    [JsonProperty("counts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Counts { get; set; } 

    [JsonProperty("self", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Self { get; set; } 

    [JsonProperty("help", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Help { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site { get; set; } 

}