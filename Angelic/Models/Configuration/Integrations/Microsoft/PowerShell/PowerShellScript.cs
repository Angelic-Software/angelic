using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.PowerShell;

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
    public int? CustomTableid { get; set; } 

    [JsonProperty("customtable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomTableName { get; set; } 

    [JsonProperty("fieldmappings_powershell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PowerShellScriptCriteria>? FieldMappingsPowershell { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelKeyPair>? HaloIntegratorAllowedclientidslist { get; set; } 

    [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorAllowedclientids { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("usepowershellseven", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UsePowerShellSeven { get; set; } 

}