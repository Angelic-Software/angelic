using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mattermost;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MattermostWebhookContent
{
    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channel { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("icon_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconUrl { get; set; } 

    [JsonProperty("icon_emoji", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconEmoji { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Attachments { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("props", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MattermostPropsObject? Props { get; set; } 

}