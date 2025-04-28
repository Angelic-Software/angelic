using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ModuleSetup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("module_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ModuleName { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("core", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Core { get; set; } 

    [JsonProperty("licensed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Licensed { get; set; } 

    [JsonProperty("accesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Accesslevel { get; set; } 

    [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloIntegratorenabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("actual_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActualName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}