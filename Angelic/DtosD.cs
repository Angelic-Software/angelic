using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DashboardFilter
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dashboard_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("column", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column { get; set; } 

    [JsonProperty("filter_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_sql { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DashboardLinks
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("iframe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iframe { get; set; } 

        [JsonProperty("newtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newtab { get; set; } 

        [JsonProperty("in_app", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? In_app { get; set; } 

        [JsonProperty("admin_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin_only { get; set; } 

        [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Org_id { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Org_name { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display_type { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restriction_type { get; set; } 

        [JsonProperty("layouts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Layouts { get; set; } 

        [JsonProperty("widgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Widget>? Widgets { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("report_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Report_access_token { get; set; } 

        [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportingperiod { get; set; } 

        [JsonProperty("reportingperiodstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Reportingperiodstartdate { get; set; } 

        [JsonProperty("reportingperiodenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Reportingperiodenddate { get; set; } 

        [JsonProperty("reportingperiodvisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportingperiodvisibility { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DashboardFilter>? Filters { get; set; } 

        [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DashboardRestriction>? User_access { get; set; } 

        [JsonProperty("is_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_published { get; set; } 

        [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Published_id { get; set; } 

        [JsonProperty("allow_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_anonymous { get; set; } 

        [JsonProperty("rowheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rowheight { get; set; } 

        [JsonProperty("manually_load_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Manually_load_dashboards { get; set; } 

        [JsonProperty("dashboard_theme_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dashboard_theme_override { get; set; } 

        [JsonProperty("list_item_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? List_item_height { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DashboardRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dashboard_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("data_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Data_id { get; set; } 

        [JsonProperty("data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_name { get; set; } 

        [JsonProperty("dashboard_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dashboard_name { get; set; } 

        [JsonProperty("data_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_string { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DateTimeZone
    {
        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezone { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DattoCommerceDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("new_api_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_api_key { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_group { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_group_name { get; set; } 

        [JsonProperty("customer_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Customer_field_mappings { get; set; } 

        [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

        [JsonProperty("quote_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Quote_status_mappings { get; set; } 

        [JsonProperty("create_items_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_items_on_import { get; set; } 

        [JsonProperty("product_supplier_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Product_supplier_on_import { get; set; } 

        [JsonProperty("sostatustoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sostatustoimport { get; set; } 

        [JsonProperty("sostatustoimport_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sostatustoimport_list { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum DbType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

        _6 = 6,

        _7 = 7,

        _8 = 8,

        _9 = 9,

        _10 = 10,

        _11 = 11,

        _12 = 12,

        _13 = 13,

        _14 = 14,

        _15 = 15,

        _16 = 16,

        _17 = 17,

        _18 = 18,

        _19 = 19,

        _20 = 20,

        _21 = 21,

        _22 = 22,

        _23 = 23,

        _25 = 25,

        _26 = 26,

        _27 = 27,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DecoderFallback
    {
        [JsonProperty("maxCharCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCharCount { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DevOpsProject
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; } 

        [JsonProperty("revision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Revision { get; set; } 

        [JsonProperty("visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Visibility { get; set; } 

        [JsonProperty("lastUpdateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdateTime { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DevOpsResourceContainer
    {
        [JsonProperty("project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DevOpsResourceContainerDetail? Project { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DevOpsResourceContainerDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("baseUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BaseUrl { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DevOpsWebhook
    {
        [JsonProperty("subscriptionId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SubscriptionId { get; set; } 

        [JsonProperty("notificationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationId { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("eventType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EventType { get; set; } 

        [JsonProperty("publisherId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PublisherId { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Resource { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DevOpsWebhookMessage? Message { get; set; } 

        [JsonProperty("detailedMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DevOpsWebhookMessage? DetailedMessage { get; set; } 

        [JsonProperty("resourceContainers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DevOpsResourceContainer? ResourceContainers { get; set; } 

        [JsonProperty("resourceVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResourceVersion { get; set; } 

        [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DevOpsWebhookMessage
    {
        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Markdown { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Device
    {
        [JsonProperty("os_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Os_override { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("changeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Changeguid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inventory_number { get; set; } 

        [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field { get; set; } 

        [JsonProperty("key_field2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field2 { get; set; } 

        [JsonProperty("key_field3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field3 { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_id { get; set; } 

        [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_name { get; set; } 

        [JsonProperty("business_owner_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_site { get; set; } 

        [JsonProperty("business_owner_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_client { get; set; } 

        [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_cab_id { get; set; } 

        [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_cab_name { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_id { get; set; } 

        [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_name { get; set; } 

        [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_cab_id { get; set; } 

        [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_cab_name { get; set; } 

        [JsonProperty("intune_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_default_site { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Warranty_end { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("is_primary_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_primary_asset { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("lansweeper_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_parent_id { get; set; } 

        [JsonProperty("child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_id { get; set; } 

        [JsonProperty("sibling_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sibling_id { get; set; } 

        [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contract_value { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_contract_id { get; set; } 

        [JsonProperty("supplier_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_contract_ref { get; set; } 

        [JsonProperty("supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_sla_id { get; set; } 

        [JsonProperty("supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_priority_id { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Fields { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relationship_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("default_contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Default_contract_value { get; set; } 

        [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemstock_id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("stock_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Stock_date { get; set; } 

        [JsonProperty("non_consignable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Non_consignable { get; set; } 

        [JsonProperty("reserved_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved_salesorder_id { get; set; } 

        [JsonProperty("reserved_salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved_salesorder_line_id { get; set; } 

        [JsonProperty("matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_field { get; set; } 

        [JsonProperty("device42_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42_id { get; set; } 

        [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42_url { get; set; } 

        [JsonProperty("related_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_services { get; set; } 

        [JsonProperty("technical_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner { get; set; } 

        [JsonProperty("business_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner { get; set; } 

        [JsonProperty("primary_asset_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Primary_asset_chart_json { get; set; } 

        [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Criticality { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("ascendant_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ascendant_count { get; set; } 

        [JsonProperty("ascendant_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device>? Ascendant_assets { get; set; } 

        [JsonProperty("descendant_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Descendant_count { get; set; } 

        [JsonProperty("descendant_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device>? Descendant_assets { get; set; } 

        [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_count { get; set; } 

        [JsonProperty("user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_count { get; set; } 

        [JsonProperty("licence_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_count { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("pingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pingservice { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Guid { get; set; } 

        [JsonProperty("import_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Import_guid { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("contractvaluecurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contractvaluecurrent { get; set; } 

        [JsonProperty("contractvalueprior", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contractvalueprior { get; set; } 

        [JsonProperty("warranty_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warranty_note { get; set; } 

        [JsonProperty("goodsin_po_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Goodsin_po_id { get; set; } 

        [JsonProperty("issue_consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Issue_consignment_id { get; set; } 

        [JsonProperty("supplier_expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Supplier_expirydate { get; set; } 

        [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_reference { get; set; } 

        [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id_string { get; set; } 

        [JsonProperty("supplierheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplierheaderid { get; set; } 

        [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_line_id { get; set; } 

        [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerpassword { get; set; } 

        [JsonProperty("commissioned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Commissioned { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device>? Children { get; set; } 

        [JsonProperty("parent_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Parent_assets { get; set; } 

        [JsonProperty("child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Child_assets { get; set; } 

        [JsonProperty("hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device>? Hierarchy { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users_List>? Users { get; set; } 

        [JsonProperty("clone_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clone_count { get; set; } 

        [JsonProperty("_dontaddnewfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontaddnewfields { get; set; } 

        [JsonProperty("_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dontupdatetype { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sla_name { get; set; } 

        [JsonProperty("supplier_sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_sla_name { get; set; } 

        [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority_name { get; set; } 

        [JsonProperty("supplier_priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_priority_name { get; set; } 

        [JsonProperty("clone_inventory_numbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clone_inventory_numbers { get; set; } 

        [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isclone { get; set; } 

        [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeader_List>? Contracts { get; set; } 

        [JsonProperty("scheduled_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequest_List>? Scheduled_tickets { get; set; } 

        [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_guid { get; set; } 

        [JsonProperty("sqlimport_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqlimport_user { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DeviceApplications>? Software { get; set; } 

        [JsonProperty("businesscentral_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentral_id { get; set; } 

        [JsonProperty("intune_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intune_id { get; set; } 

        [JsonProperty("intune_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_connectionid { get; set; } 

        [JsonProperty("azure_userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_userid { get; set; } 

        [JsonProperty("azure_userprincipalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_userprincipalname { get; set; } 

        [JsonProperty("stockdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ItemStock? Stockdetails { get; set; } 

        [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetgroup_name { get; set; } 

        [JsonProperty("prtg_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtg_id { get; set; } 

        [JsonProperty("prtg_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtg_details_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServSite_List>? Services { get; set; } 

        [JsonProperty("datto_site_uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_site_uid { get; set; } 

        [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ateraid { get; set; } 

        [JsonProperty("items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultItem>? Items_issued { get; set; } 

        [JsonProperty("lansweeper_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_id { get; set; } 

        [JsonProperty("lansweeper_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_url { get; set; } 

        [JsonProperty("lansweeper_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LansweeperSoftware>? Lansweeper_software { get; set; } 

        [JsonProperty("dlastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dlastupdate { get; set; } 

        [JsonProperty("createdfrompurchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SupplierOrderHeader? Createdfrompurchaseorder { get; set; } 

        [JsonProperty("stockdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Stockdate { get; set; } 

        [JsonProperty("item_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_cost { get; set; } 

        [JsonProperty("old_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Old_software_version { get; set; } 

        [JsonProperty("new_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_software_version { get; set; } 

        [JsonProperty("user_role_breakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DeviceUserCount>? User_role_breakdown { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_id { get; set; } 

        [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Area_guid { get; set; } 

        [JsonProperty("jamf_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_id { get; set; } 

        [JsonProperty("jamf_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_type { get; set; } 

        [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone_number { get; set; } 

        [JsonProperty("bookmarked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bookmarked { get; set; } 

        [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_ticket_count { get; set; } 

        [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onhold_ticket_count { get; set; } 

        [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_ticket_count { get; set; } 

        [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opened_thismonth_count { get; set; } 

        [JsonProperty("domotz_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_agentid { get; set; } 

        [JsonProperty("domotz_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_id { get; set; } 

        [JsonProperty("domotz_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_type_id { get; set; } 

        [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_client_id { get; set; } 

        [JsonProperty("deactivate_child_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivate_child_devices { get; set; } 

        [JsonProperty("auvik_network_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_network_id { get; set; } 

        [JsonProperty("parent_third_party_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Parent_third_party_ids { get; set; } 

        [JsonProperty("snowUsers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SnowComputerUserAbstract>? SnowUsers { get; set; } 

        [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TabConfig>? Tab_config { get; set; } 

        [JsonProperty("qualys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualys_id { get; set; } 

        [JsonProperty("assettype_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public XType? Assettype_config { get; set; } 

        [JsonProperty("passportal_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_client_id { get; set; } 

        [JsonProperty("addigy_policy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_policy_id { get; set; } 

        [JsonProperty("addigy_applications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AddigyApplication>? Addigy_applications { get; set; } 

        [JsonProperty("addigy_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Addigy_users { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("isassetdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isassetdetails { get; set; } 

        [JsonProperty("domotz_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domotz_agent { get; set; } 

        [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardid { get; set; } 

        [JsonProperty("iskaseyaagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iskaseyaagent { get; set; } 

        [JsonProperty("_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _donotvalidate { get; set; } 

        [JsonProperty("datto_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_remote_url { get; set; } 

        [JsonProperty("qualys_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QualysHostAssetSoftwareHostAssetSoftware>? Qualys_software { get; set; } 

        [JsonProperty("xtypeunamecanedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RT_Permission>? Xtypeunamecanedit { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("ethernetMacAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EthernetMacAddress { get; set; } 

        [JsonProperty("physicalMemoryInBytes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhysicalMemoryInBytes { get; set; } 

        [JsonProperty("azureTenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantId { get; set; } 

        [JsonProperty("services_hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServSite>? Services_hierarchy { get; set; } 

        [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validateonly { get; set; } 

        [JsonProperty("copy_unmapped_info_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copy_unmapped_info_fields { get; set; } 

        [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_email { get; set; } 

        [JsonProperty("lansweeper_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LansweeperRelation>? Lansweeper_relations { get; set; } 

        [JsonProperty("kbs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Kbs { get; set; } 

        [JsonProperty("site_external_link_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_external_link_id { get; set; } 

        [JsonProperty("workspace_orgunitpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_orgunitpath { get; set; } 

        [JsonProperty("sibling_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Sibling_assets { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("icinga_hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_hostname { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("new_access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? New_access_control { get; set; } 

        [JsonProperty("jamf_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_details_id { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("is_stock_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_stock_change { get; set; } 

        [JsonProperty("parent_third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_third_party_id { get; set; } 

        [JsonProperty("is_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_return { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_generate { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified { get; set; } 

        [JsonProperty("asset_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_chart_json { get; set; } 

        [JsonProperty("lansweeper_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_site_id { get; set; } 

        [JsonProperty("thirdparty_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thirdparty_client_id { get; set; } 

        [JsonProperty("syncro_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_asset_type { get; set; } 

        [JsonProperty("dynatrace_to_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DynatraceRelationship>? Dynatrace_to_relations { get; set; } 

        [JsonProperty("dynatrace_from_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DynatraceRelationship>? Dynatrace_from_relations { get; set; } 

        [JsonProperty("open_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_incident_count { get; set; } 

        [JsonProperty("open_change_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_change_count { get; set; } 

        [JsonProperty("thirdparty_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thirdparty_type_id { get; set; } 

        [JsonProperty("is_stock_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_stock_site { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("related_service_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_service_names { get; set; } 

        [JsonProperty("parent_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_asset_names { get; set; } 

        [JsonProperty("child_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Child_asset_names { get; set; } 

        [JsonProperty("sibling_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sibling_asset_names { get; set; } 

        [JsonProperty("related_kb_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_kb_names { get; set; } 

        [JsonProperty("licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Licence_List>? Licences { get; set; } 

        [JsonProperty("add_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Licence_List>? Add_licences { get; set; } 

        [JsonProperty("licences_hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Licence_List>? Licences_hierarchy { get; set; } 

        [JsonProperty("sqlimport_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqlimport_accountsid { get; set; } 

        [JsonProperty("created_from_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_from_template { get; set; } 

        [JsonProperty("sqlimport_did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_did { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("linked_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ServSite? Linked_service { get; set; } 

        [JsonProperty("is_linked_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_linked_service { get; set; } 

        [JsonProperty("runbook_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Runbook_button_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("device_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_number { get; set; } 

        [JsonProperty("assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assettype_guid { get; set; } 

        [JsonProperty("warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Warranty_start { get; set; } 

        [JsonProperty("labour_warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Labour_warranty_start { get; set; } 

        [JsonProperty("labour_warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Labour_warranty_end { get; set; } 

        [JsonProperty("parent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Parent_guid { get; set; } 

        [JsonProperty("child_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Child_guid { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Third_party_id { get; set; } 

        [JsonProperty("latest_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Latest_contract_ref { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("ncentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_url { get; set; } 

        [JsonProperty("ncentral_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_remote_url { get; set; } 

        [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Contract_end_date { get; set; } 

        [JsonProperty("atera_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_id { get; set; } 

        [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_id { get; set; } 

        [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_url { get; set; } 

        [JsonProperty("connectwise_control_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_control_url { get; set; } 

        [JsonProperty("ninjarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmm_id { get; set; } 

        [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_url { get; set; } 

        [JsonProperty("ninja_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_remote_url { get; set; } 

        [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_url { get; set; } 

        [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncroid { get; set; } 

        [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_url { get; set; } 

        [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsequence { get; set; } 

        [JsonProperty("service_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_ids { get; set; } 

        [JsonProperty("bulkcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulkcreated { get; set; } 

        [JsonProperty("bulkbillingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulkbillingperiod { get; set; } 

        [JsonProperty("asset_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_field { get; set; } 

        [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_alternate_id { get; set; } 

        [JsonProperty("syncro_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_id { get; set; } 

        [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_id { get; set; } 

        [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_id { get; set; } 

        [JsonProperty("auvik_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_device_id { get; set; } 

        [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_url { get; set; } 

        [JsonProperty("allowallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowallstatus { get; set; } 

        [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeStatus>? Allowed_status { get; set; } 

        [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_id { get; set; } 

        [JsonProperty("addigy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_id { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_url { get; set; } 

        [JsonProperty("liongard_environmnet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_environmnet_id { get; set; } 

        [JsonProperty("liongard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_id { get; set; } 

        [JsonProperty("kaseya_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_id { get; set; } 

        [JsonProperty("kaseyavsa_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyavsa_url { get; set; } 

        [JsonProperty("teamviewerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerid { get; set; } 

        [JsonProperty("serialization_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serialization_user { get; set; } 

        [JsonProperty("zabbix_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_id { get; set; } 

        [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_url { get; set; } 

        [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stockbin_name { get; set; } 

        [JsonProperty("issue_consignment_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Issue_consignment_line_id { get; set; } 

        [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_name { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_url { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_details_id { get; set; } 

        [JsonProperty("nable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nable_id { get; set; } 

        [JsonProperty("connectwisecontrolid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisecontrolid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_id { get; set; } 

        [JsonProperty("workspace_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_url { get; set; } 

        [JsonProperty("supplier_purchasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Supplier_purchasedate { get; set; } 

        [JsonProperty("logicmonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_id { get; set; } 

        [JsonProperty("barracudarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Barracudarmm_id { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("icinga_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_id { get; set; } 

        [JsonProperty("related_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_service_name { get; set; } 

        [JsonProperty("related_service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Related_service_count { get; set; } 

        [JsonProperty("connectwisermm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisermm_id { get; set; } 

        [JsonProperty("xensam_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_id { get; set; } 

        [JsonProperty("asset_type_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_type_priority { get; set; } 

        [JsonProperty("snipeit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snipeit_id { get; set; } 

        [JsonProperty("prometheus_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_id { get; set; } 

        [JsonProperty("dynatrace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynatrace_id { get; set; } 

        [JsonProperty("vmworkspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vmworkspace_id { get; set; } 

        [JsonProperty("tanium_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tanium_id { get; set; } 

        [JsonProperty("tenable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenable_id { get; set; } 

        [JsonProperty("kandji_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kandji_id { get; set; } 

        [JsonProperty("criticality_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Criticality_description { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_id { get; set; } 

        [JsonProperty("is_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_template { get; set; } 

        [JsonProperty("aws_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Aws_id { get; set; } 

        [JsonProperty("manageengine_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manageengine_id { get; set; } 

        [JsonProperty("manageengine_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manageengine_customer_id { get; set; } 

        [JsonProperty("lastchangeofvaluedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastchangeofvaluedate { get; set; } 

        [JsonProperty("commissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Commissiondate { get; set; } 

        [JsonProperty("first_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? First_user_id { get; set; } 

        [JsonProperty("changebackupexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changebackupexists { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("virima_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Virima_id { get; set; } 

        [JsonProperty("service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Service_guid { get; set; } 

        [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_name { get; set; } 

        [JsonProperty("lansweeperid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeperid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Device42Webhook
    {
        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User { get; set; } 

        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Device42WebhookData? Data { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Device42WebhookData
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DeviceApplications
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; } 

        [JsonProperty("did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Did { get; set; } 

        [JsonProperty("bundledesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bundledesc { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("lastused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastused { get; set; } 

        [JsonProperty("install_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Install_date { get; set; } 

        [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snowid { get; set; } 

        [JsonProperty("licence_required", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Licence_required { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_name { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Moduleid { get; set; } 

        [JsonProperty("new_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users>? New_users { get; set; } 

        [JsonProperty("new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device>? New_devices { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DeviceChange
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } 

        [JsonProperty("field_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_desc { get; set; } 

        [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_id { get; set; } 

        [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_site { get; set; } 

        [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_number { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("old_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Old_value { get; set; } 

        [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_value { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("software_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Software_id { get; set; } 

        [JsonProperty("software_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Software_user_id { get; set; } 

        [JsonProperty("software_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Software_user_name { get; set; } 

        [JsonProperty("old_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_site { get; set; } 

        [JsonProperty("new_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_site { get; set; } 

        [JsonProperty("customfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customfield_id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DeviceMeterReading
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("recurringinvoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurringinvoice_line_id { get; set; } 

        [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_id { get; set; } 

        [JsonProperty("meter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meter_name { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("reading_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reading_type { get; set; } 

        [JsonProperty("pack_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pack_id { get; set; } 

        [JsonProperty("reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reading { get; set; } 

        [JsonProperty("previous_reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Previous_reading { get; set; } 

        [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reason { get; set; } 

        [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewed { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DeviceUserCount
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Device_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("changeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Changeguid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inventory_number { get; set; } 

        [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field { get; set; } 

        [JsonProperty("key_field2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field2 { get; set; } 

        [JsonProperty("key_field3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field3 { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_id { get; set; } 

        [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_name { get; set; } 

        [JsonProperty("business_owner_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_site { get; set; } 

        [JsonProperty("business_owner_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_client { get; set; } 

        [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Business_owner_cab_id { get; set; } 

        [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner_cab_name { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_id { get; set; } 

        [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_name { get; set; } 

        [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technical_owner_cab_id { get; set; } 

        [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner_cab_name { get; set; } 

        [JsonProperty("intune_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_default_site { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Warranty_end { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("is_primary_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_primary_asset { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("lansweeper_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_parent_id { get; set; } 

        [JsonProperty("child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_id { get; set; } 

        [JsonProperty("sibling_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sibling_id { get; set; } 

        [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contract_value { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_contract_id { get; set; } 

        [JsonProperty("supplier_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_contract_ref { get; set; } 

        [JsonProperty("supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_sla_id { get; set; } 

        [JsonProperty("supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_priority_id { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Fields { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relationship_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("default_contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Default_contract_value { get; set; } 

        [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemstock_id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("stock_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Stock_date { get; set; } 

        [JsonProperty("non_consignable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Non_consignable { get; set; } 

        [JsonProperty("reserved_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved_salesorder_id { get; set; } 

        [JsonProperty("reserved_salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reserved_salesorder_line_id { get; set; } 

        [JsonProperty("matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_field { get; set; } 

        [JsonProperty("device42_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42_id { get; set; } 

        [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42_url { get; set; } 

        [JsonProperty("related_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_services { get; set; } 

        [JsonProperty("technical_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Technical_owner { get; set; } 

        [JsonProperty("business_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Business_owner { get; set; } 

        [JsonProperty("primary_asset_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Primary_asset_chart_json { get; set; } 

        [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Criticality { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("device_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_number { get; set; } 

        [JsonProperty("assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assettype_guid { get; set; } 

        [JsonProperty("warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Warranty_start { get; set; } 

        [JsonProperty("labour_warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Labour_warranty_start { get; set; } 

        [JsonProperty("labour_warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Labour_warranty_end { get; set; } 

        [JsonProperty("parent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Parent_guid { get; set; } 

        [JsonProperty("child_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Child_guid { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Third_party_id { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sla_name { get; set; } 

        [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority_name { get; set; } 

        [JsonProperty("latest_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Latest_contract_ref { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("ncentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_url { get; set; } 

        [JsonProperty("ncentral_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_remote_url { get; set; } 

        [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Contract_end_date { get; set; } 

        [JsonProperty("atera_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_id { get; set; } 

        [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_id { get; set; } 

        [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_url { get; set; } 

        [JsonProperty("connectwise_control_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_control_url { get; set; } 

        [JsonProperty("ninjarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmm_id { get; set; } 

        [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_url { get; set; } 

        [JsonProperty("ninja_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_remote_url { get; set; } 

        [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_url { get; set; } 

        [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncroid { get; set; } 

        [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_url { get; set; } 

        [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsequence { get; set; } 

        [JsonProperty("service_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_ids { get; set; } 

        [JsonProperty("bulkcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulkcreated { get; set; } 

        [JsonProperty("bulkbillingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulkbillingperiod { get; set; } 

        [JsonProperty("asset_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_field { get; set; } 

        [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_alternate_id { get; set; } 

        [JsonProperty("syncro_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_id { get; set; } 

        [JsonProperty("domotz_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domotz_id { get; set; } 

        [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_id { get; set; } 

        [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_id { get; set; } 

        [JsonProperty("auvik_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_device_id { get; set; } 

        [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_url { get; set; } 

        [JsonProperty("allowallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowallstatus { get; set; } 

        [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeStatus>? Allowed_status { get; set; } 

        [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_id { get; set; } 

        [JsonProperty("addigy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_id { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_url { get; set; } 

        [JsonProperty("liongard_environmnet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_environmnet_id { get; set; } 

        [JsonProperty("liongard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_id { get; set; } 

        [JsonProperty("kaseya_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_id { get; set; } 

        [JsonProperty("iskaseyaagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iskaseyaagent { get; set; } 

        [JsonProperty("kaseyavsa_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyavsa_url { get; set; } 

        [JsonProperty("teamviewerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerid { get; set; } 

        [JsonProperty("serialization_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serialization_user { get; set; } 

        [JsonProperty("zabbix_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_id { get; set; } 

        [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_url { get; set; } 

        [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stockbin_name { get; set; } 

        [JsonProperty("issue_consignment_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Issue_consignment_line_id { get; set; } 

        [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_name { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_url { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_details_id { get; set; } 

        [JsonProperty("nable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nable_id { get; set; } 

        [JsonProperty("connectwisecontrolid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisecontrolid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_id { get; set; } 

        [JsonProperty("workspace_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_url { get; set; } 

        [JsonProperty("intune_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intune_id { get; set; } 

        [JsonProperty("supplier_purchasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Supplier_purchasedate { get; set; } 

        [JsonProperty("logicmonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_id { get; set; } 

        [JsonProperty("barracudarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Barracudarmm_id { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sla_id { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("icinga_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_id { get; set; } 

        [JsonProperty("related_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Related_service_name { get; set; } 

        [JsonProperty("related_service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Related_service_count { get; set; } 

        [JsonProperty("connectwisermm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisermm_id { get; set; } 

        [JsonProperty("xensam_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_id { get; set; } 

        [JsonProperty("asset_type_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_type_priority { get; set; } 

        [JsonProperty("snipeit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snipeit_id { get; set; } 

        [JsonProperty("prometheus_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_id { get; set; } 

        [JsonProperty("dynatrace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynatrace_id { get; set; } 

        [JsonProperty("vmworkspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vmworkspace_id { get; set; } 

        [JsonProperty("tanium_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tanium_id { get; set; } 

        [JsonProperty("tenable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenable_id { get; set; } 

        [JsonProperty("kandji_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kandji_id { get; set; } 

        [JsonProperty("criticality_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Criticality_description { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_id { get; set; } 

        [JsonProperty("is_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_template { get; set; } 

        [JsonProperty("aws_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Aws_id { get; set; } 

        [JsonProperty("manageengine_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manageengine_id { get; set; } 

        [JsonProperty("manageengine_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manageengine_customer_id { get; set; } 

        [JsonProperty("lastchangeofvaluedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastchangeofvaluedate { get; set; } 

        [JsonProperty("commissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Commissiondate { get; set; } 

        [JsonProperty("first_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? First_user_id { get; set; } 

        [JsonProperty("changebackupexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changebackupexists { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("virima_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Virima_id { get; set; } 

        [JsonProperty("service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Service_guid { get; set; } 

        [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_name { get; set; } 

        [JsonProperty("lansweeperid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeperid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DistributionLists
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Desc { get; set; } 

        [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_from { get; set; } 

        [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox_replyto { get; set; } 

        [JsonProperty("dynamic_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dynamic_members { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users>? Users { get; set; } 

        [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DistributionListsUser>? Members { get; set; } 

        [JsonProperty("addtheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users>? Addtheseusers { get; set; } 

        [JsonProperty("removetheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Users>? Removetheseusers { get; set; } 

        [JsonProperty("users_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Users_count { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("mailbox_from_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox_from_address { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_url { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DlFilterDetails>? Filters { get; set; } 

        [JsonProperty("linked_campaigns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MailCampaign>? Linked_campaigns { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DistributionListsLog
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("distributionlists_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Distributionlists_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsubject { get; set; } 

        [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailbody { get; set; } 

        [JsonProperty("action_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action_desc { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DistributionListsUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("distributionlists_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Distributionlists_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("phone_extn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone_extn { get; set; } 

        [JsonProperty("phone_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone_mobile { get; set; } 

        [JsonProperty("phone_mobile2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone_mobile2 { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DlFilterDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? List_id { get; set; } 

        [JsonProperty("filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_name { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type { get; set; } 

        [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_value { get; set; } 

        [JsonProperty("filter_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Filter_values { get; set; } 

        [JsonProperty("filter_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Filter_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Downtime
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("fault_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fault_summary { get; set; } 

        [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service { get; set; } 

        [JsonProperty("service_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_desc { get; set; } 

        [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workdays { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("ended", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ended { get; set; } 

        [JsonProperty("calculated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calculated { get; set; } 

        [JsonProperty("allday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allday { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Dynamics365CRMFieldMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("halo_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_table { get; set; } 

        [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamics_table { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

        [JsonProperty("synctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Synctype { get; set; } 

        [JsonProperty("idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Idfield { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_name { get; set; } 

        [JsonProperty("child_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Dynamics365CRMSubTable>? Child_mappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Field_mappings { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Dynamics365CRMSubTable
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamics_table { get; set; } 

        [JsonProperty("entityname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entityname { get; set; } 

        [JsonProperty("parentidfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parentidfield { get; set; } 

        [JsonProperty("child_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Child_field_mappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DynatraceDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicesite { get; set; } 

        [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicesite_name { get; set; } 

        [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_devicetype { get; set; } 

        [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_devicetypename { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetimportidentifier_fieldname { get; set; } 

        [JsonProperty("host_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Host_fieldmappings { get; set; } 

        [JsonProperty("service_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Service_fieldmappings { get; set; } 

        [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete_devices { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

        [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_update_device_type { get; set; } 

        [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_move_site { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroupname { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

        [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_username { get; set; } 

        [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_password { get; set; } 

        [JsonProperty("webhook_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_salt { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_iterations { get; set; } 

        [JsonProperty("enable_alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_alerts { get; set; } 

        [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_type { get; set; } 

        [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_type_name { get; set; } 

        [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_user { get; set; } 

        [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_user_name { get; set; } 

        [JsonProperty("new_webhook_password_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_webhook_password_method { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DynatraceEntity
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DynatraceRelationship
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class DynatraceWebhook
    {
        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; } 

        [JsonProperty("problemID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemID { get; set; } 

        [JsonProperty("problemTitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemTitle { get; set; } 

        [JsonProperty("problemSeverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemSeverity { get; set; } 

        [JsonProperty("problemImpact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemImpact { get; set; } 

        [JsonProperty("problemURL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemURL { get; set; } 

        [JsonProperty("impactedEntities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DynatraceEntity>? ImpactedEntities { get; set; } 

        [JsonProperty("impactedEntityNames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImpactedEntityNames { get; set; } 

        [JsonProperty("problemDetailsHTML", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemDetailsHTML { get; set; } 

        [JsonProperty("problemDetailsText", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemDetailsText { get; set; } 

        [JsonProperty("detailsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DetailsId { get; set; } 

    }