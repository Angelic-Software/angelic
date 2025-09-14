using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Migrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Instance
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hostname { get; set; } 

    [JsonProperty("envname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EnvName { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("commits_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommitsAhead { get; set; } 

    [JsonProperty("commits_behind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommitsBehind { get; set; } 

    [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncId { get; set; } 

    [JsonProperty("offline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Offline { get; set; } 

    [JsonProperty("insync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InSync { get; set; } 

    [JsonProperty("versionmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? VersionMatch { get; set; } 

    [JsonProperty("canmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanMerge { get; set; } 

    [JsonProperty("iscurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCurrent { get; set; } 

    [JsonProperty("nomergereason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NoMergeReason { get; set; } 

    [JsonProperty("isself", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSelf { get; set; } 

    [JsonProperty("isprod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsProd { get; set; } 

    [JsonProperty("_restore_from_prod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestoreFromProd { get; set; } 

    [JsonProperty("_restore_from_prod_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestoreFromProdResult { get; set; } 

}