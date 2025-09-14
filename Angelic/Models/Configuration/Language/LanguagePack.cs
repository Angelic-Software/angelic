using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Language;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LanguagePack
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("short_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShortName { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("flag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Flag { get; set; } 

    [JsonProperty("is_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCustom { get; set; } 

    [JsonProperty("synctonhd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncToNhd { get; set; } 

    [JsonProperty("linked_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedId { get; set; } 

    [JsonProperty("linked_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedCode { get; set; } 

    [JsonProperty("azure_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(20)]
    public string? AzureCode { get; set; } 

    [JsonProperty("is_right_to_left", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRightToLeft { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? Notes { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Translations { get; set; } 

    [JsonProperty("translation_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslations>? TranslationDetails { get; set; } 

    [JsonProperty("translations_are_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TranslationsAreCustom { get; set; } 

    [JsonProperty("dont_remove_translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontRemoveTranslations { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}