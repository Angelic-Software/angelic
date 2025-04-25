using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Google;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GoogleReviewer
{
    [JsonProperty("profilePhotoUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfilePhotoUrl { get; set; } 

    [JsonProperty("profilePhotoUri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfilePhotoUri { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("isAnonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAnonymous { get; set; } 

}