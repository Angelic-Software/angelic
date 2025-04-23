using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum XMessagePriority
    {

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyname { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("isbladehost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Isbladehost { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tags { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

        [JsonProperty("includesoftware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includesoftware { get; set; } 

        [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Field_mappings { get; set; } 

        [JsonProperty("field_mapping_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_mapping_count { get; set; } 

        [JsonProperty("sub_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sub_type { get; set; } 

        [JsonProperty("tag_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tag_list { get; set; } 

        [JsonProperty("tag_list_pairs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Tag_list_pairs { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("partial_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partial_match { get; set; } 

        [JsonProperty("detailsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Detailsid { get; set; } 

        [JsonProperty("userules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userules { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMappingCriteria>? Criteria { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_count { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeMappingCriteria
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("xtypemapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xtypemapping_id { get; set; } 

        [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tablename { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_type { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value_float { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_string { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Value_datetime { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_display { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeRole
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("xtype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xtype_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeStatus
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("xtype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xtype_id { get; set; } 

        [JsonProperty("xtype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xtype_name { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("allowafterallstatuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowafterallstatuses { get; set; } 

        [JsonProperty("allowedafterstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeStatusRestrictions>? Allowedafterstatus { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeStatusRestrictions
    {
        [JsonProperty("xtypestatus_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xtypestatus_id { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XeroDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_id { get; set; } 

        [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_name { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_uri { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecode { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_top_level { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("isdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isdefault { get; set; } 

        [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesync { get; set; } 

        [JsonProperty("default_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_item_code { get; set; } 

        [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_message { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sync_entities { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_top_level { get; set; } 

        [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_top_level_name { get; set; } 

        [JsonProperty("archive_contacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archive_contacts { get; set; } 

        [JsonProperty("default_order_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_order_item_code { get; set; } 

        [JsonProperty("rounding_adjustment_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rounding_adjustment_account_code { get; set; } 

        [JsonProperty("group_rounding_adjustments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Group_rounding_adjustments { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("receive_client_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_client_created { get; set; } 

        [JsonProperty("receive_client_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_client_updated { get; set; } 

        [JsonProperty("receive_invoice_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_invoice_created { get; set; } 

        [JsonProperty("receive_invoice_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_invoice_updated { get; set; } 

        [JsonProperty("default_creditnote_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_creditnote_item_code { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("sync_currency_for_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_currency_for_invoices { get; set; } 

        [JsonProperty("no_item_group_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? No_item_group_sync { get; set; } 

        [JsonProperty("invoice_description_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_description_data { get; set; } 

        [JsonProperty("dont_sync_cost_tracking_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_sync_cost_tracking_lines { get; set; } 

        [JsonProperty("organisation_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Organisation_version { get; set; } 

        [JsonProperty("no_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? No_tax_code { get; set; } 

        [JsonProperty("category_1_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Category_1_keypair { get; set; } 

        [JsonProperty("category_2_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Category_2_keypair { get; set; } 

        [JsonProperty("category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1_name { get; set; } 

        [JsonProperty("category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1_id { get; set; } 

        [JsonProperty("category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2_name { get; set; } 

        [JsonProperty("category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XeroWebhookEvent
    {
        [JsonProperty("resourceUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResourceUrl { get; set; } 

        [JsonProperty("resourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResourceId { get; set; } 

        [JsonProperty("eventDateUtc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EventDateUtc { get; set; } 

        [JsonProperty("eventType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventType { get; set; } 

        [JsonProperty("eventCategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventCategory { get; set; } 

        [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantId { get; set; } 

        [JsonProperty("tenantType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantType { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

        [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventType? EventTypeNum { get; set; } 

        [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventCategory? EventCategoryNum { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XType
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetgroup_id { get; set; } 

        [JsonProperty("assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assetgroup_guid { get; set; } 

        [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetgroup_name { get; set; } 

        [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Keyfield_id { get; set; } 

        [JsonProperty("keyfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Keyfield_name { get; set; } 

        [JsonProperty("keyfield2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Keyfield2_id { get; set; } 

        [JsonProperty("keyfield2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Keyfield2_name { get; set; } 

        [JsonProperty("keyfield3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Keyfield3_id { get; set; } 

        [JsonProperty("keyfield3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Keyfield3_name { get; set; } 

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Memo { get; set; } 

        [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Manufacturer { get; set; } 

        [JsonProperty("supplier1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier1 { get; set; } 

        [JsonProperty("itemno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemno { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("useteamviewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useteamviewer { get; set; } 

        [JsonProperty("accountscode1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountscode1 { get; set; } 

        [JsonProperty("accountscode2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountscode2 { get; set; } 

        [JsonProperty("weeklycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Weeklycost { get; set; } 

        [JsonProperty("monthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Monthlycost { get; set; } 

        [JsonProperty("quarterlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quarterlycost { get; set; } 

        [JsonProperty("sixmonthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Sixmonthlycost { get; set; } 

        [JsonProperty("yearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Yearlycost { get; set; } 

        [JsonProperty("twoyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Twoyearlycost { get; set; } 

        [JsonProperty("threeyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Threeyearlycost { get; set; } 

        [JsonProperty("fouryearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Fouryearlycost { get; set; } 

        [JsonProperty("fiveyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Fiveyearlycost { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("show_to_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_to_users { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TypeInfo>? Fields { get; set; } 

        [JsonProperty("field_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Field>? Field_list { get; set; } 

        [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_code { get; set; } 

        [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsequence { get; set; } 

        [JsonProperty("tagprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tagprefix { get; set; } 

        [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Column_profile_id { get; set; } 

        [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Column_profile_guid { get; set; } 

        [JsonProperty("columnprofileoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Columnprofileoverride_name { get; set; } 

        [JsonProperty("enableresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableresourcebooking { get; set; } 

        [JsonProperty("resourcebooking_workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebooking_workdays_id { get; set; } 

        [JsonProperty("resourcebooking_workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resourcebooking_workdays_name { get; set; } 

        [JsonProperty("resourcebooking_allow_asset_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resourcebooking_allow_asset_selection { get; set; } 

        [JsonProperty("resourcebooking_asset_restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebooking_asset_restriction_type { get; set; } 

        [JsonProperty("resourcebooking_min_hours_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Resourcebooking_min_hours_advance { get; set; } 

        [JsonProperty("resourcebooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Resourcebooking_max_days_advance { get; set; } 

        [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BookingType>? Bookingtypes { get; set; } 

        [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BookingTypeTimeslot>? Timeslots { get; set; } 

        [JsonProperty("timeslot_bookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeslot_bookingtype { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("linkedcontracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linkedcontracttype { get; set; } 

        [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiid { get; set; } 

        [JsonProperty("fiid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Fiid_guid { get; set; } 

        [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Finame { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("xtype_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeRole>? Xtype_roles { get; set; } 

        [JsonProperty("asset_details_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_details_tab_display { get; set; } 

        [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TabConfig>? Tab_config { get; set; } 

        [JsonProperty("resourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebookingtype { get; set; } 

        [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeStatus>? Allowed_status { get; set; } 

        [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_status { get; set; } 

        [JsonProperty("businessowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Businessowner_visibility { get; set; } 

        [JsonProperty("technicalowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technicalowner_visibility { get; set; } 

        [JsonProperty("sla_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_visibility { get; set; } 

        [JsonProperty("priority_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_visibility { get; set; } 

        [JsonProperty("status_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_visibility { get; set; } 

        [JsonProperty("services_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Services_visibility { get; set; } 

        [JsonProperty("dependencies_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dependencies_visibility { get; set; } 

        [JsonProperty("notes_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notes_visibility { get; set; } 

        [JsonProperty("visibility_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Visibility_level { get; set; } 

        [JsonProperty("resourcebooking_site_selection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebooking_site_selection_type { get; set; } 

        [JsonProperty("booking_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Site_List>? Booking_sites { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("newticket_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticket_priority { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("licence_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_visibility { get; set; } 

        [JsonProperty("allow_all_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_all_view { get; set; } 

        [JsonProperty("criticality_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Criticality_visibility { get; set; } 

        [JsonProperty("is_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_service { get; set; } 

        [JsonProperty("is_businessapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_businessapp { get; set; } 

        [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_category_id { get; set; } 

        [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_category_name { get; set; } 

        [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServSite_List>? Services { get; set; } 

        [JsonProperty("field_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldRoleRestriction>? Field_restrictions { get; set; } 

    }