using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("teamname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamname { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("webhookurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhookurl { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channel_id { get; set; } 

    [JsonProperty("allow_ticket_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_ticket_create { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_type { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_type_name { get; set; } 

    [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _getoauthtoken { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauth_code { get; set; } 

    [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauth_redirect { get; set; } 

    [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Scopes { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_id { get; set; } 

    [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_user { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_user_name { get; set; } 

    [JsonProperty("command_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Command_ticket_type { get; set; } 

    [JsonProperty("command_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Command_ticket_type_name { get; set; } 

    [JsonProperty("command_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Command_user { get; set; } 

    [JsonProperty("command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Command_user_name { get; set; } 

    [JsonProperty("uninstalled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Uninstalled { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}