using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwitterDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Screen_name { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_id { get; set; } 

    [JsonProperty("new_oauth_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_oauth_token { get; set; } 

    [JsonProperty("new_oauth_token_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_oauth_token_secret { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("_gettoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _gettoken { get; set; } 

    [JsonProperty("_oauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _oauthtoken { get; set; } 

    [JsonProperty("_oauthverifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _oauthverifier { get; set; } 

    [JsonProperty("create_direct_message_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_direct_message_tickets { get; set; } 

    [JsonProperty("direct_message_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Direct_message_ticket_type { get; set; } 

    [JsonProperty("direct_message_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Direct_message_ticket_type_name { get; set; } 

    [JsonProperty("direct_message_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Direct_message_user { get; set; } 

    [JsonProperty("direct_message_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Direct_message_user_name { get; set; } 

    [JsonProperty("reopen_direct_message_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reopen_direct_message_tickets { get; set; } 

    [JsonProperty("create_mention_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_mention_tickets { get; set; } 

    [JsonProperty("mention_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mention_ticket_type { get; set; } 

    [JsonProperty("mention_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mention_ticket_type_name { get; set; } 

    [JsonProperty("mention_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mention_user { get; set; } 

    [JsonProperty("mention_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mention_user_name { get; set; } 

    [JsonProperty("days_after_mention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Days_after_mention { get; set; } 

    [JsonProperty("include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Include_word_list { get; set; } 

    [JsonProperty("exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Exclude_word_list { get; set; } 

    [JsonProperty("direct_message_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Direct_message_create_users { get; set; } 

    [JsonProperty("direct_message_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Direct_message_site { get; set; } 

    [JsonProperty("direct_message_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Direct_message_site_name { get; set; } 

    [JsonProperty("mention_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mention_create_users { get; set; } 

    [JsonProperty("mention_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mention_site { get; set; } 

    [JsonProperty("mention_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mention_site_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}