using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BookingType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("duration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration_type { get; set; } 

        [JsonProperty("duration_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration_mins { get; set; } 

        [JsonProperty("duration_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration_days { get; set; } 

        [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_type { get; set; } 

        [JsonProperty("customslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Timeslot>? Customslots { get; set; } 

        [JsonProperty("messagehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messagehtml { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_before", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebooking_buffer_minutes_before { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Resourcebooking_buffer_minutes_after { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BookingTypeTimeslot
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LongIdNameKeyPair>? Resources { get; set; } 

        [JsonProperty("bookedResourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BookedResourceId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Bookmark
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_type { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("bookmarked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bookmarked { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BudgetType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("defaultrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Defaultrate { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BulkEmail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("serviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serviceid { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_id { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Next_retry_date { get; set; } 

        [JsonProperty("last_attempt_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_attempt_date { get; set; } 

        [JsonProperty("mailcampaignid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailcampaignid { get; set; } 

        [JsonProperty("mailcampaignemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailcampaignemailid { get; set; } 

        [JsonProperty("mailboxfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxfrom { get; set; } 

        [JsonProperty("mailboxreplyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailboxreplyto { get; set; } 

        [JsonProperty("trace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Trace>? Trace { get; set; } 

        [JsonProperty("request_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Request_body { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fault_id { get; set; } 

        [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionnumber { get; set; } 

        [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Distribution_list { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BusinessCentralCompany
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("systemVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SystemVersion { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; } 

        [JsonProperty("businessProfileId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessProfileId { get; set; } 

        [JsonProperty("systemCreatedAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SystemCreatedAt { get; set; } 

        [JsonProperty("systemCreatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SystemCreatedBy { get; set; } 

        [JsonProperty("systemModifiedAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SystemModifiedAt { get; set; } 

        [JsonProperty("systemModifiedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SystemModifiedBy { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BusinessCentralCustomer
    {
        [JsonProperty("odataetag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Odataetag { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Number { get; set; } 

        [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("addressLine1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddressLine1 { get; set; } 

        [JsonProperty("addressLine2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddressLine2 { get; set; } 

        [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? City { get; set; } 

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; } 

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country { get; set; } 

        [JsonProperty("postalCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PostalCode { get; set; } 

        [JsonProperty("phoneNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; } 

        [JsonProperty("salespersonCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalespersonCode { get; set; } 

        [JsonProperty("balanceDue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? BalanceDue { get; set; } 

        [JsonProperty("creditLimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreditLimit { get; set; } 

        [JsonProperty("taxLiable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxLiable { get; set; } 

        [JsonProperty("taxAreaId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaxAreaId { get; set; } 

        [JsonProperty("taxAreaDisplayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaxAreaDisplayName { get; set; } 

        [JsonProperty("taxRegistrationNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaxRegistrationNumber { get; set; } 

        [JsonProperty("currencyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrencyId { get; set; } 

        [JsonProperty("currencyCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrencyCode { get; set; } 

        [JsonProperty("paymentTermsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PaymentTermsId { get; set; } 

        [JsonProperty("shipmentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ShipmentMethodId { get; set; } 

        [JsonProperty("paymentMethodId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PaymentMethodId { get; set; } 

        [JsonProperty("blocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Blocked { get; set; } 

        [JsonProperty("lastModifiedDateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModifiedDateTime { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BusinessCentralDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("redirect_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_url { get; set; } 

        [JsonProperty("authorization_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authorization_code { get; set; } 

        [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecodefortoken { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _authcode { get; set; } 

        [JsonProperty("environment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCentralEnvironment? Environment { get; set; } 

        [JsonProperty("environment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Environment_name { get; set; } 

        [JsonProperty("environment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Environment_type { get; set; } 

        [JsonProperty("web_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Web_service_url { get; set; } 

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country { get; set; } 

        [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCentralCompany? Company { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_id { get; set; } 

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_name { get; set; } 

        [JsonProperty("company_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Company_version { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_top_level { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

        [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

        [JsonProperty("item_default_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_default_group { get; set; } 

        [JsonProperty("item_default_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_group_name { get; set; } 

        [JsonProperty("default_sales_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_sales_account { get; set; } 

        [JsonProperty("default_sales_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_sales_account_name { get; set; } 

        [JsonProperty("default_purchase_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_purchase_account { get; set; } 

        [JsonProperty("default_purchase_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_purchase_account_name { get; set; } 

        [JsonProperty("enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_sync { get; set; } 

        [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sync_entities { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_message { get; set; } 

        [JsonProperty("default_invoice_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_invoice_item { get; set; } 

        [JsonProperty("default_invoice_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_invoice_item_name { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("sync_inv_groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_inv_groups { get; set; } 

        [JsonProperty("use_advanced_cost_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_advanced_cost_endpoint { get; set; } 

        [JsonProperty("group_increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_increment { get; set; } 

        [JsonProperty("line_increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_increment { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BusinessCentralEnvironment
    {
        [JsonProperty("aadTenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AadTenantId { get; set; } 

        [JsonProperty("applicationFamily", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApplicationFamily { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("countryCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CountryCode { get; set; } 

        [JsonProperty("webServiceUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebServiceUrl { get; set; } 

        [JsonProperty("webClientLoginUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebClientLoginUrl { get; set; } 

    }