using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_id { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("page_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Page_id { get; set; } 

    [JsonProperty("page_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Page_name { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oauth_code { get; set; } 

    [JsonProperty("new_user_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_user_token { get; set; } 

    [JsonProperty("new_page_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_page_token { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirect_uri { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New { get; set; } 

    [JsonProperty("base_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Base_address { get; set; } 

    [JsonProperty("page", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FacebookPage? Page { get; set; } 

    [JsonProperty("create_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_messenger_tickets { get; set; } 

    [JsonProperty("messenger_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messenger_ticket_type { get; set; } 

    [JsonProperty("messenger_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Messenger_ticket_type_name { get; set; } 

    [JsonProperty("messenger_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messenger_user { get; set; } 

    [JsonProperty("messenger_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Messenger_user_name { get; set; } 

    [JsonProperty("reopen_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reopen_messenger_tickets { get; set; } 

    [JsonProperty("create_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Create_post_tickets { get; set; } 

    [JsonProperty("post_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Post_ticket_type { get; set; } 

    [JsonProperty("post_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Post_user { get; set; } 

    [JsonProperty("post_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Post_user_name { get; set; } 

    [JsonProperty("post_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Post_ticket_type_name { get; set; } 

    [JsonProperty("days_after_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Days_after_post { get; set; } 

    [JsonProperty("include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Include_word_list { get; set; } 

    [JsonProperty("exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Exclude_word_list { get; set; } 

    [JsonProperty("reopen_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reopen_post_tickets { get; set; } 

    [JsonProperty("messenger_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Messenger_create_users { get; set; } 

    [JsonProperty("messenger_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messenger_site { get; set; } 

    [JsonProperty("messenger_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Messenger_site_name { get; set; } 

    [JsonProperty("post_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Post_create_users { get; set; } 

    [JsonProperty("post_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Post_site { get; set; } 

    [JsonProperty("ratings_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ratings_create_users { get; set; } 

    [JsonProperty("ratings_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ratings_create_tickets { get; set; } 

    [JsonProperty("ratings_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ratings_site { get; set; } 

    [JsonProperty("ratings_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ratings_ticket_type { get; set; } 

    [JsonProperty("ratings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ratings_user { get; set; } 

    [JsonProperty("ratings_status_after_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ratings_status_after_update { get; set; } 

    [JsonProperty("ratings_only_negative", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ratings_only_negative { get; set; } 

    [JsonProperty("ads_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ads_create_users { get; set; } 

    [JsonProperty("ads_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ads_create_tickets { get; set; } 

    [JsonProperty("ads_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ads_site { get; set; } 

    [JsonProperty("ads_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ads_ticket_type { get; set; } 

    [JsonProperty("ads_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ads_user { get; set; } 

    [JsonProperty("ratings_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ratings_site_name { get; set; } 

    [JsonProperty("ratings_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ratings_ticket_type_name { get; set; } 

    [JsonProperty("ratings_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ratings_user_name { get; set; } 

    [JsonProperty("ads_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ads_site_name { get; set; } 

    [JsonProperty("ads_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ads_ticket_type_name { get; set; } 

    [JsonProperty("ads_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ads_user_name { get; set; } 

    [JsonProperty("ratings_status_after_update_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ratings_status_after_update_name { get; set; } 

    [JsonProperty("post_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Post_site_name { get; set; } 

    [JsonProperty("insta_messenger_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_messenger_create_users { get; set; } 

    [JsonProperty("insta_messenger_create_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_messenger_create_tickets { get; set; } 

    [JsonProperty("insta_messenger_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_messenger_site { get; set; } 

    [JsonProperty("insta_messenger_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_messenger_ticket_type { get; set; } 

    [JsonProperty("insta_messenger_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_messenger_user { get; set; } 

    [JsonProperty("insta_reopen_messenger_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_reopen_messenger_tickets { get; set; } 

    [JsonProperty("insta_messenger_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_messenger_ticket_type_name { get; set; } 

    [JsonProperty("insta_messenger_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_messenger_user_name { get; set; } 

    [JsonProperty("insta_messenger_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_messenger_site_name { get; set; } 

    [JsonProperty("insta_create_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_create_post_tickets { get; set; } 

    [JsonProperty("insta_post_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_post_ticket_type { get; set; } 

    [JsonProperty("insta_post_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_post_user { get; set; } 

    [JsonProperty("insta_post_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_post_user_name { get; set; } 

    [JsonProperty("insta_post_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_post_ticket_type_name { get; set; } 

    [JsonProperty("insta_days_after_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_days_after_post { get; set; } 

    [JsonProperty("insta_include_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Insta_include_word_list { get; set; } 

    [JsonProperty("insta_exclude_word_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Insta_exclude_word_list { get; set; } 

    [JsonProperty("insta_reopen_post_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_reopen_post_tickets { get; set; } 

    [JsonProperty("insta_post_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Insta_post_create_users { get; set; } 

    [JsonProperty("insta_post_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Insta_post_site { get; set; } 

    [JsonProperty("insta_post_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Insta_post_site_name { get; set; } 

    [JsonProperty("linked_instagram_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_instagram_account { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}