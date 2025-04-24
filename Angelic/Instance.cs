using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Instance
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hostname { get; set; } 

    [JsonProperty("envname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Envname { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("commits_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommitsAhead { get; set; } 

    [JsonProperty("commits_behind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommitsBehind { get; set; } 

    [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Syncid { get; set; } 

    [JsonProperty("offline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Offline { get; set; } 

    [JsonProperty("insync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insync { get; set; } 

    [JsonProperty("versionmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Versionmatch { get; set; } 

    [JsonProperty("canmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canmerge { get; set; } 

    [JsonProperty("iscurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscurrent { get; set; } 

    [JsonProperty("nomergereason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nomergereason { get; set; } 

    [JsonProperty("isself", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isself { get; set; } 

    [JsonProperty("isprod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isprod { get; set; } 

    [JsonProperty("_restore_from_prod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestoreFromProd { get; set; } 

    [JsonProperty("_restore_from_prod_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestoreFromProdResult { get; set; } 

}