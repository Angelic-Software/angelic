using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PowerShellScriptProcessing
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("pssid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pssid { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faultid { get; set; } 

    [JsonProperty("processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Processed { get; set; } 

    [JsonProperty("failactionadded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Failactionadded { get; set; } 

    [JsonProperty("execution_parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, object?>? Execution_parameters { get; set; } 

    [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Success { get; set; } 

    [JsonProperty("result_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Result_message { get; set; } 

    [JsonProperty("run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Run_date { get; set; } 

    [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Script_name { get; set; } 

    [JsonProperty("_requeue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _requeue { get; set; } 

    [JsonProperty("requeued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Requeued { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}