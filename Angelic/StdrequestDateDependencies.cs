using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StdrequestDateDependencies
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parenttemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parenttemplateid { get; set; } 

    [JsonProperty("childtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Childtemplateid { get; set; } 

    [JsonProperty("child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Child_template_name { get; set; } 

    [JsonProperty("dependentchildtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dependentchildtemplateid { get; set; } 

    [JsonProperty("dependent_child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dependent_child_template_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}