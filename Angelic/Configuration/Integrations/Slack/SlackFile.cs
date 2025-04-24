using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackFile
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("url_private", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UrlPrivate { get; set; } 

    [JsonProperty("url_private_download", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UrlPrivateDownload { get; set; } 

    [JsonProperty("permalink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Permalink { get; set; } 

    [JsonProperty("permalink_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PermalinkPublic { get; set; } 

    [JsonProperty("is_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPublic { get; set; } 

    [JsonProperty("is_external", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsExternal { get; set; } 

}