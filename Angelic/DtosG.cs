using System.CodeDom.Compiler;
using Angelic.Dtos;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GenerateExternalLink
    {
        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tenant_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Generic
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Memo { get; set; } 

        [JsonProperty("islan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IsLan { get; set; } 

        [JsonProperty("connector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connector { get; set; } 

        [JsonProperty("showasitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showasitem { get; set; } 

        [JsonProperty("showasequip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showasequip { get; set; } 

        [JsonProperty("showwarningifonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showwarningifonrequest { get; set; } 

        [JsonProperty("moveassetonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Moveassetonrequest { get; set; } 

        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsite { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Items_in_group_no_consign { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XType>? Assettypes { get; set; } 

        [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("isfixedasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isfixedasset { get; set; } 

        [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode { get; set; } 

        [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_name { get; set; } 

        [JsonProperty("nominalcodepurchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcodepurchase { get; set; } 

        [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_name_purchase { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("tcsnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tcsnote { get; set; } 

        [JsonProperty("accounts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GenericAccountsMappings>? Accounts_mappings { get; set; } 

        [JsonProperty("tax_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tax_id { get; set; } 

        [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name { get; set; } 

        [JsonProperty("tax_id_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tax_id_purchase { get; set; } 

        [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name_purchase { get; set; } 

        [JsonProperty("itemcode_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemcode_id { get; set; } 

        [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemcode_name { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("multipleaccountstenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multipleaccountstenants { get; set; } 

        [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_class { get; set; } 

        [JsonProperty("qbo_item_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbo_item_type { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("item_recurring_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_recurring_default { get; set; } 

        [JsonProperty("item_donttrackstock_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_donttrackstock_default { get; set; } 

        [JsonProperty("item_doesnotneedconsigning_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_doesnotneedconsigning_default { get; set; } 

        [JsonProperty("item_contract_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_contract_default { get; set; } 

        [JsonProperty("item_assettype_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_assettype_default { get; set; } 

        [JsonProperty("item_billing_period_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_billing_period_default { get; set; } 

        [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_item_code { get; set; } 

        [JsonProperty("item_assettype_name_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_assettype_name_default { get; set; } 

        [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup { get; set; } 

        [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup { get; set; } 

        [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup_name { get; set; } 

        [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GenericAccountsMappings
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gid { get; set; } 

        [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantid { get; set; } 

        [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_name { get; set; } 

        [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode { get; set; } 

        [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_name { get; set; } 

        [JsonProperty("nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_purchase { get; set; } 

        [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode_name_purchase { get; set; } 

        [JsonProperty("itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemcode { get; set; } 

        [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemcode_name { get; set; } 

        [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taxcode { get; set; } 

        [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name { get; set; } 

        [JsonProperty("taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taxcode_purchase { get; set; } 

        [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name_purchase { get; set; } 

        [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup { get; set; } 

        [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup { get; set; } 

        [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_1_lookup_name { get; set; } 

        [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_category_2_lookup_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GeoLocationRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_id { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country_code { get; set; } 

        [JsonProperty("continent_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Continent_code { get; set; } 

        [JsonProperty("exclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GmailMessage
    {
        [JsonProperty("haloMailboxId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HaloMailboxId { get; set; } 

        [JsonProperty("mimeMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MimeMessage? MimeMessage { get; set; } 

        [JsonProperty("incomingEmailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingEmailId { get; set; } 

        [JsonProperty("historyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? HistoryId { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("internalDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? InternalDate { get; set; } 

        [JsonProperty("labelIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? LabelIds { get; set; } 

        [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MessagePart? Payload { get; set; } 

        [JsonProperty("raw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Raw { get; set; } 

        [JsonProperty("sizeEstimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SizeEstimate { get; set; } 

        [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snippet { get; set; } 

        [JsonProperty("threadId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThreadId { get; set; } 

        [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ETag { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleBusinessAnswer
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleReviewer? Author { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreateTime { get; set; } 

        [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdateTime { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleBusinessDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectionname { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Account { get; set; } 

        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Location { get; set; } 

        [JsonProperty("account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Account_name { get; set; } 

        [JsonProperty("location_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Location_name { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleBusinessQuestion
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("author", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleReviewer? Author { get; set; } 

        [JsonProperty("upvoteCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UpvoteCount { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreateTime { get; set; } 

        [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdateTime { get; set; } 

        [JsonProperty("totalAnswerCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalAnswerCount { get; set; } 

        [JsonProperty("topAnswers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GoogleBusinessAnswer>? TopAnswers { get; set; } 

        [JsonProperty("gbdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gbdid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleBusinessReview
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("reviewId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReviewId { get; set; } 

        [JsonProperty("reviewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleReviewer? Reviewer { get; set; } 

        [JsonProperty("starRating", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StarRating { get; set; } 

        [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; } 

        [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreateTime { get; set; } 

        [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdateTime { get; set; } 

        [JsonProperty("reviewReply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleBusinessReviewReply? ReviewReply { get; set; } 

        [JsonProperty("gbdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gbdid { get; set; } 

        [JsonProperty("starRating_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StarRating_int { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleBusinessReviewReply
    {
        [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; } 

        [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UpdateTime { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleReviewer
    {
        [JsonProperty("profilePhotoUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProfilePhotoUrl { get; set; } 

        [JsonProperty("profilePhotoUri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProfilePhotoUri { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; } 

        [JsonProperty("isAnonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnonymous { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class GoogleWorkplaceMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customerid { get; set; } 

        [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteid { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("filterfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filterfield { get; set; } 

        [JsonProperty("filtertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filtertype { get; set; } 

        [JsonProperty("filtervalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filtervalue { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filter { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }