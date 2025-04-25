using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.Dynamics365.BusinessCentral;

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
    public ICollection<ExternalLinkList>? ClientMappings { get; set; } 

    [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ItemGroupMappings { get; set; } 

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