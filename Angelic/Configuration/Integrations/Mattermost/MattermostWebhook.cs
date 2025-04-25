using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mattermost;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MattermostWebhook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChannelId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserId { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamId { get; set; } 

    [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("icon_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconUrl { get; set; } 

    [JsonProperty("create_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? CreateAt { get; set; } 

    [JsonProperty("update_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? UpdateAt { get; set; } 

    [JsonProperty("delete_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? DeleteAt { get; set; } 

}