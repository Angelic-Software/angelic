using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StdRequestDateDependencies
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parenttemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parenttemplateid { get; set; } 

    [JsonProperty("childtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Childtemplateid { get; set; } 

    [JsonProperty("child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChildTemplateName { get; set; } 

    [JsonProperty("dependentchildtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dependentchildtemplateid { get; set; } 

    [JsonProperty("dependent_child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DependentChildTemplateName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}