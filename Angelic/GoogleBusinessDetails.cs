using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GoogleBusinessDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connectionname { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_integration_method { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Account { get; set; } 

    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Location { get; set; } 

    [JsonProperty("account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Account_name { get; set; } 

    [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Location_name { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _disconnect { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}