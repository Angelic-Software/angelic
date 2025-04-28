using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LoginScreenConfig
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationId { get; set; } 

    [JsonProperty("function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Function { get; set; } 

    [JsonProperty("function_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FunctionName { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Display { get; set; } 

    [JsonProperty("label_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LabelOverride { get; set; } 

    [JsonProperty("hasform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasForm { get; set; } 

}