using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class BookingType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssettypeId { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("duration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationType { get; set; } 

        [JsonProperty("duration_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationMins { get; set; } 

        [JsonProperty("duration_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationDays { get; set; } 

        [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentType { get; set; } 

        [JsonProperty("customslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Timeslot>? Customslots { get; set; } 

        [JsonProperty("messagehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messagehtml { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_before", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourcebookingBufferMinutesBefore { get; set; } 

        [JsonProperty("resourcebooking_buffer_minutes_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourcebookingBufferMinutesAfter { get; set; } 

        [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TypeName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

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
        public int? EntityId { get; set; } 

        [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EntityType { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

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
        public string? Warning { get; set; } 

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
        public int? ServiceId { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextRetryDate { get; set; } 

        [JsonProperty("last_attempt_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastAttemptDate { get; set; } 

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
        public string? RequestBody { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FaultId { get; set; } 

        [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionnumber { get; set; } 

        [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DistributionList { get; set; } 

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
        public string? TenantId { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientId { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewClientSecret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRefreshToken { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TokenExpiry { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("redirect_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RedirectUrl { get; set; } 

        [JsonProperty("authorization_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuthorizationCode { get; set; } 

        [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchangecodefortoken { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disconnect { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authcode { get; set; } 

        [JsonProperty("environment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCentralEnvironment? Environment { get; set; } 

        [JsonProperty("environment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EnvironmentName { get; set; } 

        [JsonProperty("environment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EnvironmentType { get; set; } 

        [JsonProperty("web_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebServiceUrl { get; set; } 

        [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Country { get; set; } 

        [JsonProperty("company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCentralCompany? Company { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyId { get; set; } 

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyName { get; set; } 

        [JsonProperty("company_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyVersion { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientTopLevel { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientTopLevelName { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? ClientMappings { get; set; } 

        [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? ItemGroupMappings { get; set; } 

        [JsonProperty("item_default_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemDefaultGroup { get; set; } 

        [JsonProperty("item_default_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultGroupName { get; set; } 

        [JsonProperty("default_sales_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSalesAccount { get; set; } 

        [JsonProperty("default_sales_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSalesAccountName { get; set; } 

        [JsonProperty("default_purchase_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultPurchaseAccount { get; set; } 

        [JsonProperty("default_purchase_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultPurchaseAccountName { get; set; } 

        [JsonProperty("enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSync { get; set; } 

        [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncEntities { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

        [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMessage { get; set; } 

        [JsonProperty("default_invoice_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultInvoiceItem { get; set; } 

        [JsonProperty("default_invoice_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultInvoiceItemName { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GraphHost { get; set; } 

        [JsonProperty("sync_inv_groups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncInvGroups { get; set; } 

        [JsonProperty("use_advanced_cost_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAdvancedCostEndpoint { get; set; } 

        [JsonProperty("group_increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupIncrement { get; set; } 

        [JsonProperty("line_increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LineIncrement { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

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