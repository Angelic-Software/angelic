using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PowerShellScriptCriteria
{
    [JsonProperty("pssid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pssid { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fiid { get; set; } 

    [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Finame { get; set; } 

    [JsonProperty("parametername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Parametername { get; set; } 

    [JsonProperty("fiusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fiusage { get; set; } 

    [JsonProperty("filabel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filabel { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}