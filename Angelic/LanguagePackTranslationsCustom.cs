using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LanguagePackTranslationsCustom
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Language_id { get; set; } 

    [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? Entity { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? Fieldname { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity_id { get; set; } 

    [JsonProperty("entity_id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity_id2 { get; set; } 

    [JsonProperty("translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Translation { get; set; } 

    [JsonProperty("_dotranslate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dotranslate { get; set; } 

    [JsonProperty("_translateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _translateonly { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("default_translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_translation { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}