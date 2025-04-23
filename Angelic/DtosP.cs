using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PDFTemplatePage
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("mainhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mainhtml { get; set; } 

        [JsonProperty("maindesign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public HtmlDesign? Maindesign { get; set; } 

        [JsonProperty("subhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subhtml { get; set; } 

        [JsonProperty("subhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subhtml2 { get; set; } 

        [JsonProperty("subhtml3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subhtml3 { get; set; } 

        [JsonProperty("istitlepage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Istitlepage { get; set; } 

        [JsonProperty("backgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Backgroundimageurl { get; set; } 

        [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content { get; set; } 

        [JsonProperty("toggle_editor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Toggle_editor { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PRTGDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("defsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defsite { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("defassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defassettype { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("assetmatchingfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetmatchingfield_name { get; set; } 

        [JsonProperty("assetmatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetmatchingfield { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegratorlasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegratorlasterror { get; set; } 

        [JsonProperty("halointegratorlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegratorlastsync { get; set; } 

        [JsonProperty("asset_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Asset_fieldmappings { get; set; } 

        [JsonProperty("enable_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_webhooks { get; set; } 

        [JsonProperty("new_webhook_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_secret { get; set; } 

        [JsonProperty("webhook_ticket_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_ticket_type_id { get; set; } 

        [JsonProperty("webhook_ticket_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_ticket_user_id { get; set; } 

        [JsonProperty("webhook_ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_ticket_user_name { get; set; } 

        [JsonProperty("webhook_ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_ticket_summary { get; set; } 

        [JsonProperty("webhook_ticket_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_ticket_details { get; set; } 

        [JsonProperty("webhook_autoclosure_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_autoclosure_status { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PagerDutyMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("serviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Serviceid { get; set; } 

        [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_name { get; set; } 

        [JsonProperty("default_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_tickettype { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("default_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_agent { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("dontsyncusertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsyncusertickets { get; set; } 

        [JsonProperty("new_webhook_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_signature { get; set; } 

        [JsonProperty("default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_user { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("default_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_description { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Parameter
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Encoding? Encoding { get; set; } 

        [JsonProperty("encodingMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ParameterEncodingMethod? EncodingMethod { get; set; } 

        [JsonProperty("alwaysQuote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlwaysQuote { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ParameterEncodingMethod
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PartsLookup
    {
        [JsonProperty("lookup_value_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Lookup_value_obj { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table_id { get; set; } 

        [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Table_name { get; set; } 

        [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_user { get; set; } 

        [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_new_password { get; set; } 

        [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_server { get; set; } 

        [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_database { get; set; } 

        [JsonProperty("sql_script", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sql_script { get; set; } 

        [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key_field { get; set; } 

        [JsonProperty("lookup_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_field { get; set; } 

        [JsonProperty("itemdesc1_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemdesc1_field { get; set; } 

        [JsonProperty("itemdesc2_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemdesc2_field { get; set; } 

        [JsonProperty("itemdesc3_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemdesc3_field { get; set; } 

        [JsonProperty("itemvalue_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itemvalue_field { get; set; } 

        [JsonProperty("matchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matchedhint { get; set; } 

        [JsonProperty("notmatchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notmatchedhint { get; set; } 

        [JsonProperty("lookuponrefresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lookuponrefresh { get; set; } 

        [JsonProperty("messagestring_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messagestring_user { get; set; } 

        [JsonProperty("messagestring_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messagestring_agent { get; set; } 

        [JsonProperty("showmessagetouseroragent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Showmessagetouseroragent { get; set; } 

        [JsonProperty("messagerequiresconfirmationuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Messagerequiresconfirmationuser { get; set; } 

        [JsonProperty("messagerequiresconfirmationagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Messagerequiresconfirmationagent { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookupField>? Fields { get; set; } 

        [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookupMapping>? Field_mappings { get; set; } 

        [JsonProperty("agent_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TechPartsLookup>? Agent_mappings { get; set; } 

        [JsonProperty("run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Run { get; set; } 

        [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_value { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PartsLookupResult? Lookup { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("lookupconnectiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookupconnectiontype { get; set; } 

        [JsonProperty("lookup_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_type { get; set; } 

        [JsonProperty("lookup_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_type_name { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Certificate_id { get; set; } 

        [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Certificate_name { get; set; } 

        [JsonProperty("allowmultipleresults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowmultipleresults { get; set; } 

        [JsonProperty("lookup_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_field_id { get; set; } 

        [JsonProperty("lookup_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_field_name { get; set; } 

        [JsonProperty("outcome_mapped_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outcome_mapped_field { get; set; } 

        [JsonProperty("outcome_mapped_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome_mapped_field_name { get; set; } 

        [JsonProperty("invert_outcome_mapped_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert_outcome_mapped_result { get; set; } 

        [JsonProperty("trigger_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trigger_type { get; set; } 

        [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Autoassign>? Rules { get; set; } 

        [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_id { get; set; } 

        [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_method_name { get; set; } 

        [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_method_value { get; set; } 

        [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_method_value_name { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PartsLookupConfirmation
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Database_lookup_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Form_id { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; } 

        [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_values { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PartsLookupField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("lookup_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_profile_id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("required", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PartsLookupMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("lookup_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookup_profile_id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("lookup_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_field { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PartsLookupResult
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_value { get; set; } 

        [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Error { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object?>? Data { get; set; } 

        [JsonProperty("field_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Field_values { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lookup_values { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popup { get; set; } 

        [JsonProperty("confirm_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Confirm_popup { get; set; } 

        [JsonProperty("data_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IDictionary<string, object>>? Data_multiple { get; set; } 

        [JsonProperty("message_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message_multiple { get; set; } 

        [JsonProperty("customfields_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ICollection<CustomField>>? Customfields_multiple { get; set; } 

        [JsonProperty("mapped_outcome_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapped_outcome_field_id { get; set; } 

        [JsonProperty("mapped_outcome_inverted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mapped_outcome_inverted { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PasswordObjectType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PdfTemplate
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("orientation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orientation { get; set; } 

        [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Margin { get; set; } 

        [JsonProperty("default_mainhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_mainhtml { get; set; } 

        [JsonProperty("default_subhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_subhtml { get; set; } 

        [JsonProperty("default_subhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_subhtml2 { get; set; } 

        [JsonProperty("default_subhtml3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_subhtml3 { get; set; } 

        [JsonProperty("includeheader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeheader { get; set; } 

        [JsonProperty("headerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Headerl { get; set; } 

        [JsonProperty("headerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Headerc { get; set; } 

        [JsonProperty("headerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Headerr { get; set; } 

        [JsonProperty("headerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Headerishtml { get; set; } 

        [JsonProperty("headerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Headerheight { get; set; } 

        [JsonProperty("headerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Headerhtml { get; set; } 

        [JsonProperty("includefooter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includefooter { get; set; } 

        [JsonProperty("footerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Footerl { get; set; } 

        [JsonProperty("footerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Footerc { get; set; } 

        [JsonProperty("footerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Footerr { get; set; } 

        [JsonProperty("footerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Footerishtml { get; set; } 

        [JsonProperty("footerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Footerheight { get; set; } 

        [JsonProperty("footerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Footerhtml { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Colour_type { get; set; } 

        [JsonProperty("backgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? Backgroundimageurl { get; set; } 

        [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; } 

        [JsonProperty("config_source_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Config_source_type { get; set; } 

        [JsonProperty("config_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? Config_url { get; set; } 

        [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportingperiod { get; set; } 

        [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? System_use { get; set; } 

        [JsonProperty("detailcolumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PdfTemplateDetail>? Detailcolumns { get; set; } 

        [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PDFTemplatePage>? Pages { get; set; } 

        [JsonProperty("is_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_preview { get; set; } 

        [JsonProperty("is_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_generate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("pdf_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdf_attachment_link { get; set; } 

        [JsonProperty("quotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuotationHeader? Quotation { get; set; } 

        [JsonProperty("salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OrderHead? Salesorder { get; set; } 

        [JsonProperty("purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SupplierOrderHeader? Purchaseorder { get; set; } 

        [JsonProperty("invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public InvoiceHeader? Invoice { get; set; } 

        [JsonProperty("contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ContractHeader? Contract { get; set; } 

        [JsonProperty("report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AnalyzerProfile? Report { get; set; } 

        [JsonProperty("consignment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ConsignmentHeader? Consignment { get; set; } 

        [JsonProperty("reports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PdfTemplateReport>? Reports { get; set; } 

        [JsonProperty("composite_report_apid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Composite_report_apid { get; set; } 

        [JsonProperty("canbeaccessedbyallusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canbeaccessedbyallusers { get; set; } 

        [JsonProperty("permissions_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserAnalyzer>? Permissions_user { get; set; } 

        [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StdRequest_List>? Schedule { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientid { get; set; } 

        [JsonProperty("licencename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licencename { get; set; } 

        [JsonProperty("library_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Library_id { get; set; } 

        [JsonProperty("image_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Image_attachment_id { get; set; } 

        [JsonProperty("pagewidthinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pagewidthinches { get; set; } 

        [JsonProperty("pageheightinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pageheightinches { get; set; } 

        [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_base64 { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("kbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KBEntry? Kbentry { get; set; } 

        [JsonProperty("showinlineimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showinlineimage { get; set; } 

        [JsonProperty("pdf_media_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_media_type { get; set; } 

        [JsonProperty("asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Device? Asset { get; set; } 

        [JsonProperty("prefix_pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prefix_pdf_attachment_id { get; set; } 

        [JsonProperty("prefixpdfappend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prefixpdfappend { get; set; } 

        [JsonProperty("iscustomised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscustomised { get; set; } 

        [JsonProperty("show_bundled_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Show_bundled_lines { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _xmlwarning { get; set; } 

        [JsonProperty("override_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_attachment_name { get; set; } 

        [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_display_type { get; set; } 

        [JsonProperty("bulkprint_asset_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Bulkprint_asset_id_list { get; set; } 

        [JsonProperty("invoicexmltemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicexmltemplate { get; set; } 

        [JsonProperty("pdftinvoicexmltemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdftinvoicexmltemplate_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PdfTemplateDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("sytemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sytemuse { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("textalign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Textalign { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PdfTemplateReport
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Report_id { get; set; } 

        [JsonProperty("report_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Report_name { get; set; } 

        [JsonProperty("report_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AnalyzerProfile? Report_data { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Permalinks
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_name { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("published_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Published_guid { get; set; } 

        [JsonProperty("access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Access_token { get; set; } 

        [JsonProperty("publishedlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Publishedlink { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Policy
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("slaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slaid { get; set; } 

        [JsonProperty("sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Sla_guid { get; set; } 

        [JsonProperty("priorityid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priorityid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("fixtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Fixtime { get; set; } 

        [JsonProperty("fixunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fixunits { get; set; } 

        [JsonProperty("enterslaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enterslaexcuse { get; set; } 

        [JsonProperty("responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Responsetime { get; set; } 

        [JsonProperty("responseunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responseunits { get; set; } 

        [JsonProperty("ishidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ishidden { get; set; } 

        [JsonProperty("fixendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fixendofday { get; set; } 

        [JsonProperty("responseendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Responseendofday { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("catprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Catprompt { get; set; } 

        [JsonProperty("workdaysoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workdaysoverride { get; set; } 

        [JsonProperty("responsestartofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Responsestartofday { get; set; } 

        [JsonProperty("responsestartofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Responsestartofdaytime { get; set; } 

        [JsonProperty("startofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Startofday { get; set; } 

        [JsonProperty("startofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Startofdaytime { get; set; } 

        [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Workdays? Workdays { get; set; } 

        [JsonProperty("setfixtostartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setfixtostartdate { get; set; } 

        [JsonProperty("setfixtotargetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setfixtotargetdate { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("enterslaresponseexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enterslaresponseexcuse { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Pop3Message
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("haloMailboxId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HaloMailboxId { get; set; } 

        [JsonProperty("incomingEmailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingEmailId { get; set; } 

        [JsonProperty("mimeMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MimeMessage? MimeMessage { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PowerShellScript
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Location { get; set; } 

        [JsonProperty("resultstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resultstring { get; set; } 

        [JsonProperty("resultpartialmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resultpartialmatch { get; set; } 

        [JsonProperty("resultstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resultstatus { get; set; } 

        [JsonProperty("resultfailedstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resultfailedstatus { get; set; } 

        [JsonProperty("customtableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customtableid { get; set; } 

        [JsonProperty("customtable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customtable_name { get; set; } 

        [JsonProperty("fieldmappings_powershell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PowerShellScriptCriteria>? Fieldmappings_powershell { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? Halointegrator_allowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_allowedclientids { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("usepowershellseven", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usepowershellseven { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PowerShellScriptCriteria
    {
        [JsonProperty("pssid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pssid { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiid { get; set; } 

        [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Finame { get; set; } 

        [JsonProperty("parametername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parametername { get; set; } 

        [JsonProperty("fiusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fiusage { get; set; } 

        [JsonProperty("filabel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filabel { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PowerShellScriptProcessing
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("pssid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pssid { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processed { get; set; } 

        [JsonProperty("failactionadded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Failactionadded { get; set; } 

        [JsonProperty("execution_parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, object?>? Execution_parameters { get; set; } 

        [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; } 

        [JsonProperty("result_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Result_message { get; set; } 

        [JsonProperty("run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Run_date { get; set; } 

        [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Script_name { get; set; } 

        [JsonProperty("_requeue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _requeue { get; set; } 

        [JsonProperty("requeued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requeued { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PrePayThreshold
    {
        [JsonProperty("asAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsAmount { get; set; } 

        [JsonProperty("newHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewHours { get; set; } 

        [JsonProperty("newAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewAmount { get; set; } 

        [JsonProperty("currentUsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CurrentUsed { get; set; } 

        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PrepayHistory
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("invoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Invoicedate { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_id { get; set; } 

        [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; } 

        [JsonProperty("expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Expirydate { get; set; } 

        [JsonProperty("expirychecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expirychecked { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("invoice_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_number { get; set; } 

        [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_to_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PrepayPeriod
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("start_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date_display { get; set; } 

        [JsonProperty("end_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date_display { get; set; } 

        [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Current { get; set; } 

        [JsonProperty("hours_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours_added { get; set; } 

        [JsonProperty("hours_expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours_expired { get; set; } 

        [JsonProperty("hours_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours_remaining { get; set; } 

        [JsonProperty("hours_used_this_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hours_used_this_period { get; set; } 

        [JsonProperty("amount_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount_added { get; set; } 

        [JsonProperty("amount_expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount_expired { get; set; } 

        [JsonProperty("amount_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount_remaining { get; set; } 

        [JsonProperty("amount_used_this_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount_used_this_period { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PresignedURLRequest
    {
        [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filename { get; set; } 

        [JsonProperty("filesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Filesize { get; set; } 

        [JsonProperty("_tempid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? _tempid { get; set; } 

        [JsonProperty("originalfilename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originalfilename { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unique_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("atfilename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atfilename { get; set; } 

        [JsonProperty("atdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atdesc { get; set; } 

        [JsonProperty("atparentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atparentid { get; set; } 

        [JsonProperty("atlinkedversionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atlinkedversionid { get; set; } 

        [JsonProperty("atnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atnote { get; set; } 

        [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_anon_upload { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetAudit
    {
        [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; } 

        [JsonProperty("createdBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetUser? CreatedBy { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetUser? UpdatedBy { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetData
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("audit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetAudit? Audit { get; set; } 

        [JsonProperty("template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetGenericObject? Template { get; set; } 

        [JsonProperty("formFields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<object>? FormFields { get; set; } 

        [JsonProperty("tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ProcessStreetTask>? Tasks { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetUser? UpdatedBy { get; set; } 

        [JsonProperty("taskTemplateGroupId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskTemplateGroupId { get; set; } 

        [JsonProperty("taskType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskType { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopped { get; set; } 

        [JsonProperty("hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; } 

        [JsonProperty("checklist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetGenericObject? Checklist { get; set; } 

        [JsonProperty("completedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetUser? CompletedBy { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetGenericObject
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetTask
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedDate { get; set; } 

        [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetUser? UpdatedBy { get; set; } 

        [JsonProperty("taskTemplateGroupId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskTemplateGroupId { get; set; } 

        [JsonProperty("taskType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskType { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopped { get; set; } 

        [JsonProperty("hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ProcessStreetWebhook
    {
        [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ProcessStreetData? Data { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class PublishProfiles
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("profile_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Profile_username { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("auth_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auth_method { get; set; } 

        [JsonProperty("basic_auth_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basic_auth_password { get; set; } 

        [JsonProperty("basic_auth_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basic_auth_salt { get; set; } 

        [JsonProperty("basic_auth_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Basic_auth_iterations { get; set; } 

        [JsonProperty("_profile_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _profile_access_token { get; set; } 

    }