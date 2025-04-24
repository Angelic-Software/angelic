using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FAQListHead
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("showforall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforall { get; set; } 

        [JsonProperty("showforallagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforallagents { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("is_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_group { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Full_name { get; set; } 

        [JsonProperty("article_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Article_count { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("grandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Grandparent_name { get; set; } 

        [JsonProperty("greatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgrandparent_name { get; set; } 

        [JsonProperty("greatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgreatgrandparent_name { get; set; } 

        [JsonProperty("greatgreatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgreatgreatgrandparent_name { get; set; } 

        [JsonProperty("fullgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fullgroup_name { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Roles { get; set; } 

        [JsonProperty("draft_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Draft_roles { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaList>? Clients { get; set; } 

        [JsonProperty("dontshowonportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshowonportal { get; set; } 

        [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GeoLocationRestriction>? Geo_restrictions { get; set; } 

    }

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

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookKeyPair
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookMessage
    {
        [JsonProperty("sender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FacebookKeyPair? Sender { get; set; } 

        [JsonProperty("recipient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FacebookKeyPair? Recipient { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FacebookMessageContent? Message { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookMessageAttachment
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FacebookMessagePayload? Payload { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookMessageContent
    {
        [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mid { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FacebookMessageAttachment>? Attachments { get; set; } 

        [JsonProperty("is_deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_deleted { get; set; } 

        [JsonProperty("is_echo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_echo { get; set; } 

        [JsonProperty("is_unsupported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_unsupported { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookMessagePayload
    {
        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookPage
    {
        [JsonProperty("access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Access_token { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

        [JsonProperty("category_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FacebookKeyPair>? Category_list { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Tasks { get; set; } 

        [JsonProperty("instagram_business_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public InstagramBusinessAccount? Instagram_business_account { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookWebhook
    {
        [JsonProperty("object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Object { get; set; } 

        [JsonProperty("entry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FacebookWebhookEntry>? Entry { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookWebhookChange
    {
        [JsonProperty("field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FacebookWebhookEntry
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; } 

        [JsonProperty("messaging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FacebookMessage>? Messaging { get; set; } 

        [JsonProperty("changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FacebookWebhookChange>? Changes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaqRequestType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("faq_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faq_id { get; set; } 

        [JsonProperty("faq_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Faq_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultAdditionalAgents
    {
        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultApproval
    {
        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_order_id { get; set; } 

        [JsonProperty("purchase_order_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_order_ref { get; set; } 

        [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_id { get; set; } 

        [JsonProperty("quote_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quote_ref { get; set; } 

        [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Startdate_timezone { get; set; } 

        [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Startdate_with_timezone { get; set; } 

        [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targetdate_timezone { get; set; } 

        [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? Targetdate_with_timezone { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("invoice_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_ref { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionnumber { get; set; } 

        [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailstatus { get; set; } 

        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("adhoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adhoc { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("ticket_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_user_id { get; set; } 

        [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_user_name { get; set; } 

        [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cab_id { get; set; } 

        [JsonProperty("templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Templateid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Image { get; set; } 

        [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initials { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("requestor_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestor_agent_id { get; set; } 

        [JsonProperty("requestor_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestor_user_id { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_process_id { get; set; } 

        [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approval_process_name { get; set; } 

        [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Approval_process_guid { get; set; } 

        [JsonProperty("approver_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approver_note { get; set; } 

        [JsonProperty("requestor_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestor_name { get; set; } 

        [JsonProperty("requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestor_imgpath { get; set; } 

        [JsonProperty("requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestor_colour { get; set; } 

        [JsonProperty("requestor_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestor_initials { get; set; } 

        [JsonProperty("requestor_onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requestor_onlinestatus { get; set; } 

        [JsonProperty("requestor_lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestor_lastonline { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("_includeticketinresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _includeticketinresponse { get; set; } 

        [JsonProperty("attachment_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AttachmentView? Attachment_list { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("agent_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_initials { get; set; } 

        [JsonProperty("agent_requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_requestor_colour { get; set; } 

        [JsonProperty("agent_requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_requestor_imgpath { get; set; } 

        [JsonProperty("delegated_by_uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delegated_by_uid { get; set; } 

        [JsonProperty("votes_required_to_accept", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Votes_required_to_accept { get; set; } 

        [JsonProperty("votes_required_to_reject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Votes_required_to_reject { get; set; } 

        [JsonProperty("is_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_mandatory { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("faresultchanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faresultchanged { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uniqueid { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("newsignatureadded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newsignatureadded { get; set; } 

        [JsonProperty("lastreminderdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastreminderdatetime { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Targetdate { get; set; } 

        [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttime { get; set; } 

        [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targettime { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Timetaken { get; set; } 

        [JsonProperty("allow_approver_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_approver_attachments { get; set; } 

        [JsonProperty("holiday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Holiday_id { get; set; } 

        [JsonProperty("holiday_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Holiday_ref { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("admin_overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin_overridden { get; set; } 

        [JsonProperty("admin_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Admin_override_id { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Role_id { get; set; } 

        [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_count { get; set; } 

        [JsonProperty("send_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_webhook { get; set; } 

        [JsonProperty("dateapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateapproved { get; set; } 

        [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step_id { get; set; } 

        [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Step_name { get; set; } 

        [JsonProperty("approval_inprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_inprogress { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("_isportalagentnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isportalagentnote { get; set; } 

        [JsonProperty("delegated_by_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delegated_by_username { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultBudget
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype_name { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Days { get; set; } 

        [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate { get; set; } 

        [JsonProperty("rate_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rate_days { get; set; } 

        [JsonProperty("money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Money { get; set; } 

        [JsonProperty("estimated_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimated_hours { get; set; } 

        [JsonProperty("estimated_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimated_days { get; set; } 

        [JsonProperty("estimated_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimated_money { get; set; } 

        [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actual_hours { get; set; } 

        [JsonProperty("actual_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actual_days { get; set; } 

        [JsonProperty("actual_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actual_money { get; set; } 

        [JsonProperty("scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Scheduled_hours { get; set; } 

        [JsonProperty("scheduled_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Scheduled_days { get; set; } 

        [JsonProperty("scheduled_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Scheduled_value { get; set; } 

        [JsonProperty("toschedule_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Toschedule_hours { get; set; } 

        [JsonProperty("toschedule_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Toschedule_days { get; set; } 

        [JsonProperty("toschedule_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Toschedule_value { get; set; } 

        [JsonProperty("remaining_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Remaining_hours { get; set; } 

        [JsonProperty("remaining_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Remaining_days { get; set; } 

        [JsonProperty("remaining_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Remaining_value { get; set; } 

        [JsonProperty("quoteline_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quoteline_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultCommit
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultItem
    {
        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; } 

        [JsonProperty("quantity_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_shipped { get; set; } 

        [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unit { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("date_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_shipped { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("note2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note2 { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_part_code { get; set; } 

        [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stocklocation_id { get; set; } 

        [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stocklocation_name { get; set; } 

        [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_in_stock { get; set; } 

        [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_number { get; set; } 

        [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_site { get; set; } 

        [JsonProperty("warranty_reported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warranty_reported { get; set; } 

        [JsonProperty("selected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selected { get; set; } 

        [JsonProperty("stock_adjusted_already", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stock_adjusted_already { get; set; } 

        [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cost_centre { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetgroup_name { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("item_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_taxable { get; set; } 

        [JsonProperty("item_generic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_generic { get; set; } 

        [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_recurring { get; set; } 

        [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_internal_reference { get; set; } 

        [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_external_reference { get; set; } 

        [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_tax_name { get; set; } 

        [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_total { get; set; } 

        [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price { get; set; } 

        [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax { get; set; } 

        [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total { get; set; } 

        [JsonProperty("consignment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Consignment_ids { get; set; } 

        [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_id { get; set; } 

        [JsonProperty("from_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? From_order_id { get; set; } 

        [JsonProperty("from_order_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? From_order_line { get; set; } 

        [JsonProperty("reserved_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Reserved_assets { get; set; } 

        [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inventory_number { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_type_matching_field_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgettype_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultOLA
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fault_id { get; set; } 

        [JsonProperty("target_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Target_id { get; set; } 

        [JsonProperty("target_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Target_name { get; set; } 

        [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Target_hours { get; set; } 

        [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actual_hours { get; set; } 

        [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Target_date { get; set; } 

        [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Target_met { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultOLADates>? Dates { get; set; } 

        [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowTarget? Target { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("pause_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Pause_date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultOLADates
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fault_ola", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fault_ola { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultRuleMatch
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fault_id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("rule_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_sequence { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("popupmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popupmsg { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultToDo
    {
        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("done", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Done { get; set; } 

        [JsonProperty("done_by_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Done_by_id { get; set; } 

        [JsonProperty("done_by_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Done_by_name { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("actual_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actual_start { get; set; } 

        [JsonProperty("actual_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actual_end { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("addedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addedby { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_seq { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultVector
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("vector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vector { get; set; } 

        [JsonProperty("datesynced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datesynced { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultVectorScore
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("matched_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Matched_id { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Search_score { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("date_occurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_occurred { get; set; } 

        [JsonProperty("date_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_closed { get; set; } 

        [JsonProperty("article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Article_description { get; set; } 

        [JsonProperty("article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Article_resolution { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultsDateDependencies
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("parentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentfaultid { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("dependentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dependentfaultid { get; set; } 

        [JsonProperty("applied_from_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Applied_from_template { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultsForecasting
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultsMileStone
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("milestone_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Milestone_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("ticket_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaultsTimeEntry
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actioncode { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Time { get; set; } 

        [JsonProperty("actionbillingplanid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionbillingplanid { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; } 

        [JsonProperty("overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overridden { get; set; } 

        [JsonProperty("actualtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actualtime { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Feedback
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; } 

        [JsonProperty("score_band", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Score_band { get; set; } 

        [JsonProperty("user_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_message { get; set; } 

        [JsonProperty("customsurveyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customsurveyfields { get; set; } 

        [JsonProperty("recaptcha_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recaptcha_token { get; set; } 

        [JsonProperty("feedback_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback_faultid { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("automation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ip_address { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Field
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kind { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeinfo_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Validate { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Systemuse { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("idstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Idstring { get; set; } 

        [JsonProperty("datafrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datafrom { get; set; } 

        [JsonProperty("datalength", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datalength { get; set; } 

        [JsonProperty("issoftware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Issoftware { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup { get; set; } 

        [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory { get; set; } 

        [JsonProperty("showoncalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showoncalendar { get; set; } 

        [JsonProperty("moveupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moveupdatetype { get; set; } 

        [JsonProperty("inactiveupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inactiveupdatetype { get; set; } 

        [JsonProperty("moveupdatedefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Moveupdatedefault { get; set; } 

        [JsonProperty("showonactivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonactivity { get; set; } 

        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Values { get; set; } 

        [JsonProperty("new_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_values { get; set; } 

        [JsonProperty("parenttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parenttype_id { get; set; } 

        [JsonProperty("parenttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parenttype_name { get; set; } 

        [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_id { get; set; } 

        [JsonProperty("order_values_alphanumerically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order_values_alphanumerically { get; set; } 

        [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_id { get; set; } 

        [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tab_name { get; set; } 

        [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_sequence { get; set; } 

        [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_columns { get; set; } 

        [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Groupname { get; set; } 

        [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techdetail { get; set; } 

        [JsonProperty("userdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userdetail { get; set; } 

        [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

        [JsonProperty("access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_level { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FieldGroup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Header { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Tickettypes { get; set; } 

        [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Outcomes { get; set; } 

        [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

        [JsonProperty("endusernew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Endusernew { get; set; } 

        [JsonProperty("enduserdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enduserdetail { get; set; } 

        [JsonProperty("technew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technew { get; set; } 

        [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techdetail { get; set; } 

        [JsonProperty("enduseraction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enduseraction { get; set; } 

        [JsonProperty("techaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techaction { get; set; } 

        [JsonProperty("techdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Techdetailhideifempty { get; set; } 

        [JsonProperty("enduserdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enduserdetailhideifempty { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("collapsedbydefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapsedbydefault { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FieldHelper
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Validate { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Value { get; set; } 

        [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display { get; set; } 

        [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory { get; set; } 

        [JsonProperty("showonactivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonactivity { get; set; } 

        [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Systemuse { get; set; } 

        [JsonProperty("parenttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parenttype_id { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_id { get; set; } 

        [JsonProperty("access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_level { get; set; } 

        [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeinfo_id { get; set; } 

        [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_id { get; set; } 

        [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tab_name { get; set; } 

        [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_sequence { get; set; } 

        [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_columns { get; set; } 

        [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Groupname { get; set; } 

        [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techdetail { get; set; } 

        [JsonProperty("userdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userdetail { get; set; } 

        [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FieldInfo
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get; set; } 

        [JsonProperty("labellong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Labellong { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hint { get; set; } 

        [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Custom { get; set; } 

        [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; } 

        [JsonProperty("usage_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Usage_guid { get; set; } 

        [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_id { get; set; } 

        [JsonProperty("tab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tab_guid { get; set; } 

        [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tab_name { get; set; } 

        [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_sequence { get; set; } 

        [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tab_columns { get; set; } 

        [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_id { get; set; } 

        [JsonProperty("table_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Table_guid { get; set; } 

        [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Table_name { get; set; } 

        [JsonProperty("readonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; } 

        [JsonProperty("addunknown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addunknown { get; set; } 

        [JsonProperty("extratype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Extratype { get; set; } 

        [JsonProperty("calcfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Calcfield { get; set; } 

        [JsonProperty("characterlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Characterlimit { get; set; } 

        [JsonProperty("characterlimittype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Characterlimittype { get; set; } 

        [JsonProperty("inputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inputtype { get; set; } 

        [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytochild { get; set; } 

        [JsonProperty("copytoparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytoparent { get; set; } 

        [JsonProperty("searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchable { get; set; } 

        [JsonProperty("user_searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_searchable { get; set; } 

        [JsonProperty("calendar_searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calendar_searchable { get; set; } 

        [JsonProperty("defaultvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultvalue { get; set; } 

        [JsonProperty("ordervaluesalphanumerically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ordervaluesalphanumerically { get; set; } 

        [JsonProperty("ordervalueby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordervalueby { get; set; } 

        [JsonProperty("defaultvalue_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultvalue_lookup { get; set; } 

        [JsonProperty("defaultvalue_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomTableRow>? Defaultvalue_table { get; set; } 

        [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Values { get; set; } 

        [JsonProperty("table_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomTableRow>? Table_values { get; set; } 

        [JsonProperty("new_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_values { get; set; } 

        [JsonProperty("variable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Variable_name { get; set; } 

        [JsonProperty("faults_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Faults_field_name { get; set; } 

        [JsonProperty("actions_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actions_field_name { get; set; } 

        [JsonProperty("table_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CustomTable? Table_info { get; set; } 

        [JsonProperty("client_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaField>? Client_restrictions { get; set; } 

        [JsonProperty("org_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrganisationField>? Org_restrictions { get; set; } 

        [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Database_lookup_id { get; set; } 

        [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Database_lookup_name { get; set; } 

        [JsonProperty("database_lookup_auto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Database_lookup_auto { get; set; } 

        [JsonProperty("database_lookup_triggers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookupField>? Database_lookup_triggers { get; set; } 

        [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_name { get; set; } 

        [JsonProperty("sqllookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqllookup { get; set; } 

        [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytochildonupdate { get; set; } 

        [JsonProperty("copytoparentonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytoparentonupdate { get; set; } 

        [JsonProperty("showintable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintable { get; set; } 

        [JsonProperty("importalias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importalias { get; set; } 

        [JsonProperty("hyperlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hyperlink { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Visibility { get; set; } 

        [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Groupname { get; set; } 

        [JsonProperty("_testsql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _testsql { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("showhintondetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showhintondetails { get; set; } 

        [JsonProperty("partslookupusedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Partslookupusedin { get; set; } 

        [JsonProperty("showondetailsscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showondetailsscreen { get; set; } 

        [JsonProperty("selection_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Selection_field_id { get; set; } 

        [JsonProperty("selection_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Selection_field_name { get; set; } 

        [JsonProperty("variable_format_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? Variable_format_1 { get; set; } 

        [JsonProperty("variable_format_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? Variable_format_2 { get; set; } 

        [JsonProperty("customextratableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customextratableid { get; set; } 

        [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copytorelated { get; set; } 

        [JsonProperty("deleteafterclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleteafterclosure { get; set; } 

        [JsonProperty("deleteafterclosuredays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deleteafterclosuredays { get; set; } 

        [JsonProperty("defaultdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultdate { get; set; } 

        [JsonProperty("validation_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldValidation>? Validation_data { get; set; } 

        [JsonProperty("calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Calculation { get; set; } 

        [JsonProperty("rounding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rounding { get; set; } 

        [JsonProperty("regex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Regex { get; set; } 

        [JsonProperty("onlyshowforagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyshowforagents { get; set; } 

        [JsonProperty("excludefromallfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefromallfields { get; set; } 

        [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory { get; set; } 

        [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("inherit_ac_from_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inherit_ac_from_tickettype { get; set; } 

        [JsonProperty("is_horizontal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_horizontal { get; set; } 

        [JsonProperty("sqlcfvariables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Sqlcfvariables { get; set; } 

        [JsonProperty("showoncrmnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showoncrmnote { get; set; } 

        [JsonProperty("database_lookup_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Database_lookup_input { get; set; } 

        [JsonProperty("table_data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_data_entry_type { get; set; } 

        [JsonProperty("isencrypted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isencrypted { get; set; } 

        [JsonProperty("table_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_height { get; set; } 

        [JsonProperty("sql_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sql_connection_type { get; set; } 

        [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_user { get; set; } 

        [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_new_password { get; set; } 

        [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_server { get; set; } 

        [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_database { get; set; } 

        [JsonProperty("sql_certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sql_certificate_id { get; set; } 

        [JsonProperty("sql_certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_certificate_name { get; set; } 

        [JsonProperty("lookup_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SqlLookupRequest? Lookup_request { get; set; } 

        [JsonProperty("max_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_selection { get; set; } 

        [JsonProperty("hint_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hint_type { get; set; } 

        [JsonProperty("defaultdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultdays { get; set; } 

        [JsonProperty("new_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_storage_method { get; set; } 

        [JsonProperty("where_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Where_sql { get; set; } 

        [JsonProperty("load_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Load_type { get; set; } 

        [JsonProperty("hide_from_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_from_filters { get; set; } 

        [JsonProperty("lookup_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_method { get; set; } 

        [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_id { get; set; } 

        [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_method_name { get; set; } 

        [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_value { get; set; } 

        [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_method_value_name { get; set; } 

        [JsonProperty("display_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display_property { get; set; } 

        [JsonProperty("value_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_property { get; set; } 

        [JsonProperty("showinpool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinpool { get; set; } 

        [JsonProperty("allow_pool_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_pool_override { get; set; } 

        [JsonProperty("simplify_rich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Simplify_rich { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FieldRoleRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FlowDetail
    {
        [JsonProperty("fdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fdid { get; set; } 

        [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step_id { get; set; } 

        [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flow_id { get; set; } 

        [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chatprofile_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("isstart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isstart { get; set; } 

        [JsonProperty("isend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isend { get; set; } 

        [JsonProperty("islaststep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Islaststep { get; set; } 

        [JsonProperty("old_diagram_x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_diagram_x { get; set; } 

        [JsonProperty("old_diagram_y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_diagram_y { get; set; } 

        [JsonProperty("new_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_flow_id { get; set; } 

        [JsonProperty("stage_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stage_number { get; set; } 

        [JsonProperty("pipeline_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pipeline_stage_id { get; set; } 

        [JsonProperty("pipeline_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pipeline_stage_name { get; set; } 

        [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowSubDetail>? Actions { get; set; } 

        [JsonProperty("overrideprobabiliywhenatthisstep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overrideprobabiliywhenatthisstep { get; set; } 

        [JsonProperty("probabilityoverridevalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Probabilityoverridevalue { get; set; } 

        [JsonProperty("steptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Steptype { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Message { get; set; } 

        [JsonProperty("message2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Message2 { get; set; } 

        [JsonProperty("message3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Message3 { get; set; } 

        [JsonProperty("auto_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_action { get; set; } 

        [JsonProperty("auto_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_action_type { get; set; } 

        [JsonProperty("auto_action_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Auto_action_type_guid { get; set; } 

        [JsonProperty("input_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Input_field_id { get; set; } 

        [JsonProperty("newticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticket_type { get; set; } 

        [JsonProperty("newticket_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticket_tickettype_id { get; set; } 

        [JsonProperty("newticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticket_template_id { get; set; } 

        [JsonProperty("step_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Step_conditions { get; set; } 

        [JsonProperty("chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SectionDetail_List>? Chat_teams { get; set; } 

        [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Autoassign>? Rules { get; set; } 

        [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_image_type { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Note { get; set; } 

        [JsonProperty("newticket_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticket_service_id { get; set; } 

        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Content { get; set; } 

        [JsonProperty("ai_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Ai_model { get; set; } 

        [JsonProperty("virtual_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Virtual_agent_id { get; set; } 

        [JsonProperty("start_new_chat_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Start_new_chat_flow_id { get; set; } 

        [JsonProperty("iteration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iteration_type { get; set; } 

        [JsonProperty("iteration_batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iteration_batch_size { get; set; } 

        [JsonProperty("use_batch_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_batch_response { get; set; } 

        [JsonProperty("newticket_sendlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newticket_sendlink { get; set; } 

        [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

        [JsonProperty("runbook_variable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Runbook_variable_mappings { get; set; } 

        [JsonProperty("chat_input_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChatInputSuggestion>? Chat_input_suggestions { get; set; } 

        [JsonProperty("chat_step_questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChatStepQuestion>? Chat_step_questions { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FlowHeader
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("notinuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Notinuse { get; set; } 

        [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Flow_chart_json { get; set; } 

        [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowDetail>? Steps { get; set; } 

        [JsonProperty("always_allow_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TOutcome>? Always_allow_actions { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("stages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowStages>? Stages { get; set; } 

        [JsonProperty("in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? In_use { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowTarget>? Targets { get; set; } 

        [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? Workflow_history { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FlowStages
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flow_id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("edit_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Edit_outcome { get; set; } 

        [JsonProperty("outcome_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outcome_step { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FlowSubDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flow_id { get; set; } 

        [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chatprofile_id { get; set; } 

        [JsonProperty("start_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Start_step { get; set; } 

        [JsonProperty("end_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? End_step { get; set; } 

        [JsonProperty("old_diagram_startpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_diagram_startpos { get; set; } 

        [JsonProperty("old_diagram_endpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_diagram_endpos { get; set; } 

        [JsonProperty("action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_type { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_id { get; set; } 

        [JsonProperty("action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Action_guid { get; set; } 

        [JsonProperty("action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_name { get; set; } 

        [JsonProperty("action_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_colour { get; set; } 

        [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_outcome { get; set; } 

        [JsonProperty("time_limit_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Time_limit_mins { get; set; } 

        [JsonProperty("use_work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_work_hours { get; set; } 

        [JsonProperty("time_limit_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Time_limit_action_id { get; set; } 

        [JsonProperty("time_limit_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Time_limit_action_guid { get; set; } 

        [JsonProperty("time_limit_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Time_limit_action_name { get; set; } 

        [JsonProperty("automation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_type { get; set; } 

        [JsonProperty("automation_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_action_id { get; set; } 

        [JsonProperty("automation_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Automation_action_guid { get; set; } 

        [JsonProperty("automation_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automation_action_name { get; set; } 

        [JsonProperty("automation_runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automation_runbook_id { get; set; } 

        [JsonProperty("automation_runbook_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automation_runbook_name { get; set; } 

        [JsonProperty("automation_execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automation_execution_type { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("approval_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_result { get; set; } 

        [JsonProperty("restricted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Restricted { get; set; } 

        [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Conditions { get; set; } 

        [JsonProperty("conditions_exec", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Conditions_exec { get; set; } 

        [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FlowSubDetailRestriction>? Restrictions { get; set; } 

        [JsonProperty("todo_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Todo_group_id { get; set; } 

        [JsonProperty("todo_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Todo_group_name { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("chat_selection_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_selection_order { get; set; } 

        [JsonProperty("number_of_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Number_of_days { get; set; } 

        [JsonProperty("date_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Date_field_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FlowSubDetailRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("flowsubdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flowsubdetail_id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_id { get; set; } 

        [JsonProperty("value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FormattedEmail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fmid { get; set; } 

        [JsonProperty("fmdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fmdata { get; set; } 

        [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority { get; set; } 

        [JsonProperty("dateopened", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dateopened { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site { get; set; } 

        [JsonProperty("email_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_to { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("timeopened", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timeopened { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype { get; set; } 

        [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1 { get; set; } 

        [JsonProperty("category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2 { get; set; } 

        [JsonProperty("category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3 { get; set; } 

        [JsonProperty("category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4 { get; set; } 

        [JsonProperty("opportunity_contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_contact_name { get; set; } 

        [JsonProperty("opportunity_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_company_name { get; set; } 

        [JsonProperty("opportunity_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_email { get; set; } 

        [JsonProperty("opportunity_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_phone { get; set; } 

        [JsonProperty("opportunity_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_value { get; set; } 

        [JsonProperty("email_cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_cc { get; set; } 

        [JsonProperty("opportunity_country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opportunity_country { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Template_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FortnoxDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isauthorized { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_top_level { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_message { get; set; } 

        [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sync_entities { get; set; } 

        [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskAttachment
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } 

        [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content_type { get; set; } 

        [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("attachment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Attachment_url { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Updated_at { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskCompany
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskPriority
    {
        [JsonProperty("respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Respond_within { get; set; } 

        [JsonProperty("resolve_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resolve_within { get; set; } 

        [JsonProperty("next_respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_respond_within { get; set; } 

        [JsonProperty("business_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Business_hours { get; set; } 

        [JsonProperty("escalation_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Escalation_enabled { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskSLA
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("is_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_default { get; set; } 

        [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Updated_at { get; set; } 

        [JsonProperty("sla_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, FreshdeskPriority>? Sla_target { get; set; } 

        [JsonProperty("applicable_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Applicable_to { get; set; } 

        [JsonProperty("escalation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Escalation { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskStats
    {
        [JsonProperty("agent_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_responded_at { get; set; } 

        [JsonProperty("responder_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responder_responded_at { get; set; } 

        [JsonProperty("first_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? First_responded_at { get; set; } 

        [JsonProperty("status_updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_updated_at { get; set; } 

        [JsonProperty("reopened_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reopened_at { get; set; } 

        [JsonProperty("resolved_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resolved_at { get; set; } 

        [JsonProperty("closed_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Closed_at { get; set; } 

        [JsonProperty("pending_since", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pending_since { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskTicket
    {
        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FreshdeskAttachment>? Attachments { get; set; } 

        [JsonProperty("cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Cc_emails { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Company_id { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("description_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description_text { get; set; } 

        [JsonProperty("due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Due_by { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("email_config_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Email_config_id { get; set; } 

        [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebook_id { get; set; } 

        [JsonProperty("fr_due_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fr_due_by { get; set; } 

        [JsonProperty("fr_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fr_escalated { get; set; } 

        [JsonProperty("fwd_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Fwd_emails { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Group_id { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("is_escalated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_escalated { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; } 

        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Product_id { get; set; } 

        [JsonProperty("reply_cc_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Reply_cc_emails { get; set; } 

        [JsonProperty("requester_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Requester_id { get; set; } 

        [JsonProperty("responder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Responder_id { get; set; } 

        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Source { get; set; } 

        [JsonProperty("spam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spam { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tags { get; set; } 

        [JsonProperty("to_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? To_emails { get; set; } 

        [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twitter_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Updated_at { get; set; } 

        [JsonProperty("requester", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskUser? Requester { get; set; } 

        [JsonProperty("stats", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskStats? Stats { get; set; } 

        [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskCompany? Company { get; set; } 

        [JsonProperty("sla_policy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskSLA? Sla_policy { get; set; } 

        [JsonProperty("custom_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string?>? Custom_fields { get; set; } 

        [JsonProperty("association_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Association_type { get; set; } 

        [JsonProperty("associated_tickets_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Associated_tickets_list { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FreshdeskUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobile { get; set; } 

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address { get; set; } 

        [JsonProperty("avatar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Avatar { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Company_id { get; set; } 

        [JsonProperty("view_all_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? View_all_tickets { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("job_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Job_title { get; set; } 

        [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Language { get; set; } 

        [JsonProperty("other_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Other_emails { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tags { get; set; } 

        [JsonProperty("time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Time_zone { get; set; } 

        [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twitter_id { get; set; } 

        [JsonProperty("unique_external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unique_external_id { get; set; } 

        [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Created_at { get; set; } 

        [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Updated_at { get; set; } 

        [JsonProperty("custom_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string?>? Custom_fields { get; set; } 

    }