using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PowerShellScript
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Location { get; set; } 

    [JsonProperty("resultstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resultstring { get; set; } 

    [JsonProperty("resultpartialmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resultpartialmatch { get; set; } 

    [JsonProperty("resultstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resultstatus { get; set; } 

    [JsonProperty("resultfailedstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resultfailedstatus { get; set; } 

    [JsonProperty("customtableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Customtableid { get; set; } 

    [JsonProperty("customtable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customtable_name { get; set; } 

    [JsonProperty("fieldmappings_powershell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PowerShellScriptCriteria>? Fieldmappings_powershell { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelKeyPair>? Halointegrator_allowedclientidslist { get; set; } 

    [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_allowedclientids { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("usepowershellseven", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usepowershellseven { get; set; } 

}