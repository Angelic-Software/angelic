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
    public int? TemplateId { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TemplateName { get; set; } 

    [JsonProperty("spotlight_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SpotlightTemplateId { get; set; } 

    [JsonProperty("spotlight_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SpotlightTemplateName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}