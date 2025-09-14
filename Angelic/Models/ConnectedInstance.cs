using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ConnectedInstance
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("apiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiUrl { get; set; } 

    [JsonProperty("authurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthUrl { get; set; } 

    [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("new_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Test { get; set; } 

    [JsonProperty("_test_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestOk { get; set; } 

    [JsonProperty("_test_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? TestResult { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}