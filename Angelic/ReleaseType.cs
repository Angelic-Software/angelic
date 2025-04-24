using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleaseType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("releasenoteset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Releasenoteset { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Template_id { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Template_name { get; set; } 

    [JsonProperty("spotlight_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Spotlight_template_id { get; set; } 

    [JsonProperty("spotlight_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Spotlight_template_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}