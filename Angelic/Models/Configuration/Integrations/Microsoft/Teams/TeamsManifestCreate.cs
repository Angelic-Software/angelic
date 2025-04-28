using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Teams;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TeamsManifestCreate
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("shortDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShortDescription { get; set; } 

    [JsonProperty("longDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LongDescription { get; set; } 

    [JsonProperty("iconColor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconColor { get; set; } 

    [JsonProperty("iconOutline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconOutline { get; set; } 

}