using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TabConfig
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Usage { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity_id { get; set; } 

    [JsonProperty("screenlayout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Screenlayout_id { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_id { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tab_name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Display { get; set; } 

    [JsonProperty("icon_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Icon_override { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_icon { get; set; } 

    [JsonProperty("nosidemenu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Nosidemenu { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

}