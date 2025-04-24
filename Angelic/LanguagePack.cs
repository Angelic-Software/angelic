using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LanguagePack
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("short_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Short_name { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("flag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Flag { get; set; } 

    [JsonProperty("is_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_custom { get; set; } 

    [JsonProperty("synctonhd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Synctonhd { get; set; } 

    [JsonProperty("linked_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_id { get; set; } 

    [JsonProperty("linked_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_code { get; set; } 

    [JsonProperty("azure_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? Azure_code { get; set; } 

    [JsonProperty("is_right_to_left", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_right_to_left { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? Notes { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Translations { get; set; } 

    [JsonProperty("translation_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslations>? Translation_details { get; set; } 

    [JsonProperty("translations_are_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Translations_are_custom { get; set; } 

    [JsonProperty("dont_remove_translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_remove_translations { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}