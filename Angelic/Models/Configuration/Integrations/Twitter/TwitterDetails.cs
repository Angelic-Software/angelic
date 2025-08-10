using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Twitter;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwitterDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("screen_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScreenName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserId { get; set; } 

    [JsonProperty("new_oauth_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewOauthToken { get; set; } 

    [JsonProperty("new_oauth_token_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewOauthTokenSecret { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("_gettoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Gettoken { get; set; } 

    [JsonProperty("_oauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauthtoken { get; set; } 

    [JsonProperty("_oauthverifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauthverifier { get; set; } 

    [JsonProperty("create_direct_message_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateDirectMessageTickets { get; set; } 

    [JsonProperty("direct_message_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DirectMessageTicketType { get; set; } 

    [JsonProperty("direct_message_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DirectMessageTicketTypeName { get; set; } 

    [JsonProperty("direct_message_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DirectMessageUser { get; set; } 

    [JsonProperty("direct_message_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DirectMessageUsername { get; set; } 

    [JsonProperty("reopen_direct_message_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReopenDirectMessageTickets { get; set; } 

    [JsonProperty("create_mention_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateMentionTickets { get; set; } 

    [JsonProperty("mention_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MentionTicketType { get; set; } 

    [JsonProperty("mention_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MentionTicketTypeName { get; set; } 

    [JsonProperty("mention_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MentionUser { get; set; } 

    [JsonProperty("mention_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MentionUsername { get; set; } 

    [JsonProperty("days_after_mention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DaysAfterMention { get; set; } 

    [JsonProperty("include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? IncludeWordList { get; set; } 

    [JsonProperty("exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? ExcludeWordList { get; set; } 

    [JsonProperty("direct_message_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DirectMessageCreateUsers { get; set; } 

    [JsonProperty("direct_message_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DirectMessageSite { get; set; } 

    [JsonProperty("direct_message_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DirectMessageSiteName { get; set; } 

    [JsonProperty("mention_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MentionCreateUsers { get; set; } 

    [JsonProperty("mention_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MentionSite { get; set; } 

    [JsonProperty("mention_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MentionSiteName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}