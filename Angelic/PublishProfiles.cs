using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PublishProfiles
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("profile_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Profile_username { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("auth_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auth_method { get; set; } 

    [JsonProperty("basic_auth_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Basic_auth_password { get; set; } 

    [JsonProperty("basic_auth_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Basic_auth_salt { get; set; } 

    [JsonProperty("basic_auth_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Basic_auth_iterations { get; set; } 

    [JsonProperty("_profile_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _profile_access_token { get; set; } 

}