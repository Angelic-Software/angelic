using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SlackDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("teamname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamName { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("webhookurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookUrl { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChannelId { get; set; } 

    [JsonProperty("allow_ticket_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowTicketCreate { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketType { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Getoauthtoken { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OauthCode { get; set; } 

    [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OauthRedirect { get; set; } 

    [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Scopes { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamId { get; set; } 

    [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketUser { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketUsername { get; set; } 

    [JsonProperty("command_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommandTicketType { get; set; } 

    [JsonProperty("command_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CommandTicketTypeName { get; set; } 

    [JsonProperty("command_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CommandUser { get; set; } 

    [JsonProperty("command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CommandUsername { get; set; } 

    [JsonProperty("uninstalled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Uninstalled { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}