using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SetupTab
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("subtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subtitle { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Duration { get; set; } 

    [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? System_use { get; set; } 

    [JsonProperty("completed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Completed { get; set; } 

    [JsonProperty("article1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Article1 { get; set; } 

    [JsonProperty("article2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Article2 { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_name { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}