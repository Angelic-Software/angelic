using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MattermostDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_integration_method { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("channels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MattermostChannelDetails>? Channels { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("integratorhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integratorhours { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}