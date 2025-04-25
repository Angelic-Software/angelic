using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LanguagePackTranslationsCustom
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LanguageId { get; set; } 

    [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? Entity { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? FieldName { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } 

    [JsonProperty("entity_id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId2 { get; set; } 

    [JsonProperty("translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Translation { get; set; } 

    [JsonProperty("_dotranslate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dotranslate { get; set; } 

    [JsonProperty("_translateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Translateonly { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("default_translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTranslation { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}