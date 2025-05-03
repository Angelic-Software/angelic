using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Language;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LanguagePackTranslations
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LanguageId { get; set; } 

    [JsonProperty("sysid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sysid { get; set; } 

    [JsonProperty("systype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Systype { get; set; } 

    [JsonProperty("display_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayId { get; set; } 

    [JsonProperty("translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Translation { get; set; } 

    [JsonProperty("incomplete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incomplete { get; set; } 

    [JsonProperty("iscustomised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCustomised { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("default_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultString { get; set; } 

    [JsonProperty("context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Context { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}