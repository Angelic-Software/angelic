using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PublishProfiles
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("profile_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfileUsername { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("auth_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AuthMethod { get; set; } 

    [JsonProperty("basic_auth_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BasicAuthPassword { get; set; } 

    [JsonProperty("basic_auth_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BasicAuthSalt { get; set; } 

    [JsonProperty("basic_auth_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BasicAuthIterations { get; set; } 

    [JsonProperty("_profile_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfileAccessToken { get; set; } 

}