using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Meta.Facebook;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("page_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PageId { get; set; } 

    [JsonProperty("page_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PageName { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCode { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OauthCode { get; set; } 

    [JsonProperty("new_user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewUserToken { get; set; } 

    [JsonProperty("new_page_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPageToken { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New { get; set; } 

    [JsonProperty("base_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BaseAddress { get; set; } 

    [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FacebookPage? Page { get; set; } 

    [JsonProperty("create_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateMessengerTickets { get; set; } 

    [JsonProperty("messenger_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessengerTicketType { get; set; } 

    [JsonProperty("messenger_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessengerTicketTypeName { get; set; } 

    [JsonProperty("messenger_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessengerUser { get; set; } 

    [JsonProperty("messenger_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessengerUsername { get; set; } 

    [JsonProperty("reopen_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReopenMessengerTickets { get; set; } 

    [JsonProperty("create_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatePostTickets { get; set; } 

    [JsonProperty("post_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PostTicketType { get; set; } 

    [JsonProperty("post_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PostUser { get; set; } 

    [JsonProperty("post_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostUsername { get; set; } 

    [JsonProperty("post_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostTicketTypeName { get; set; } 

    [JsonProperty("days_after_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DaysAfterPost { get; set; } 

    [JsonProperty("include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? IncludeWordList { get; set; } 

    [JsonProperty("exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? ExcludeWordList { get; set; } 

    [JsonProperty("reopen_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReopenPostTickets { get; set; } 

    [JsonProperty("messenger_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MessengerCreateUsers { get; set; } 

    [JsonProperty("messenger_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessengerSite { get; set; } 

    [JsonProperty("messenger_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessengerSiteName { get; set; } 

    [JsonProperty("post_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PostCreateUsers { get; set; } 

    [JsonProperty("post_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PostSite { get; set; } 

    [JsonProperty("ratings_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RatingsCreateUsers { get; set; } 

    [JsonProperty("ratings_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RatingsCreateTickets { get; set; } 

    [JsonProperty("ratings_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RatingsSite { get; set; } 

    [JsonProperty("ratings_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RatingsTicketType { get; set; } 

    [JsonProperty("ratings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RatingsUser { get; set; } 

    [JsonProperty("ratings_status_after_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RatingsStatusAfterUpdate { get; set; } 

    [JsonProperty("ratings_only_negative", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RatingsOnlyNegative { get; set; } 

    [JsonProperty("ads_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdsCreateUsers { get; set; } 

    [JsonProperty("ads_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdsCreateTickets { get; set; } 

    [JsonProperty("ads_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdsSite { get; set; } 

    [JsonProperty("ads_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdsTicketType { get; set; } 

    [JsonProperty("ads_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdsUser { get; set; } 

    [JsonProperty("ratings_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RatingsSiteName { get; set; } 

    [JsonProperty("ratings_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RatingsTicketTypeName { get; set; } 

    [JsonProperty("ratings_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RatingsUsername { get; set; } 

    [JsonProperty("ads_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AdsSiteName { get; set; } 

    [JsonProperty("ads_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AdsTicketTypeName { get; set; } 

    [JsonProperty("ads_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AdsUsername { get; set; } 

    [JsonProperty("ratings_status_after_update_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RatingsStatusAfterUpdateName { get; set; } 

    [JsonProperty("post_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostSiteName { get; set; } 

    [JsonProperty("insta_messenger_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaMessengerCreateUsers { get; set; } 

    [JsonProperty("insta_messenger_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaMessengerCreateTickets { get; set; } 

    [JsonProperty("insta_messenger_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaMessengerSite { get; set; } 

    [JsonProperty("insta_messenger_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaMessengerTicketType { get; set; } 

    [JsonProperty("insta_messenger_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaMessengerUser { get; set; } 

    [JsonProperty("insta_reopen_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaReopenMessengerTickets { get; set; } 

    [JsonProperty("insta_messenger_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaMessengerTicketTypeName { get; set; } 

    [JsonProperty("insta_messenger_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaMessengerUsername { get; set; } 

    [JsonProperty("insta_messenger_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaMessengerSiteName { get; set; } 

    [JsonProperty("insta_create_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaCreatePostTickets { get; set; } 

    [JsonProperty("insta_post_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaPostTicketType { get; set; } 

    [JsonProperty("insta_post_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaPostUser { get; set; } 

    [JsonProperty("insta_post_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaPostUsername { get; set; } 

    [JsonProperty("insta_post_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaPostTicketTypeName { get; set; } 

    [JsonProperty("insta_days_after_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaDaysAfterPost { get; set; } 

    [JsonProperty("insta_include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? InstaIncludeWordList { get; set; } 

    [JsonProperty("insta_exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? InstaExcludeWordList { get; set; } 

    [JsonProperty("insta_reopen_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaReopenPostTickets { get; set; } 

    [JsonProperty("insta_post_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InstaPostCreateUsers { get; set; } 

    [JsonProperty("insta_post_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstaPostSite { get; set; } 

    [JsonProperty("insta_post_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InstaPostSiteName { get; set; } 

    [JsonProperty("linked_instagram_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedInstagramAccount { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}