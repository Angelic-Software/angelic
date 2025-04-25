using System.CodeDom.Compiler;
using Angelic.Configuration.CustomField;
using Angelic.Configuration.Integrations.Quickbooks;
using Angelic.Configuration.Integrations.Snow;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Area;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AreaList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ToplevelId { get; set; } 

    [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ToplevelName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("confirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Confirmemail { get; set; } 

    [JsonProperty("actionemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionemail { get; set; } 

    [JsonProperty("clearemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clearemail { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromAddressOverride { get; set; } 

    [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideOrgLogo { get; set; } 

    [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgName { get; set; } 

    [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? OverrideOrgAddress { get; set; } 

    [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgPhone { get; set; } 

    [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgEmail { get; set; } 

    [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgWebsite { get; set; } 

    [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgPortalurl { get; set; } 

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxOverride { get; set; } 

    [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMailboxId { get; set; } 

    [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Calldate { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceTaxCode { get; set; } 

    [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayTaxCode { get; set; } 

    [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractTaxCode { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? SiteFields { get; set; } 

    [JsonProperty("pritech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pritech { get; set; } 

    [JsonProperty("sectech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sectech { get; set; } 

    [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Accountmanagertech { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartynhdapiurl { get; set; } 

    [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xeroid { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; } 

    [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OppsTicketCount { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("regmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Regmanagertech { get; set; } 

    [JsonProperty("logmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Logmanagertech { get; set; } 

    [JsonProperty("salesreptech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesreptech { get; set; } 

    [JsonProperty("accountownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Accountownertech { get; set; } 

    [JsonProperty("cxmleadtech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cxmleadtech { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantId { get; set; } 

    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsid { get; set; } 

    [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Excludefrominvoicesync { get; set; } 

    [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Gficlientid { get; set; } 

    [JsonProperty("overridepdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridepdftemplateinvoice { get; set; } 

    [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridepdftemplateinvoiceName { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowTenantId { get; set; } 

    [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoice { get; set; } 

    [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientToInvoiceName { get; set; } 

    [JsonProperty("invoiceduedaysextraclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoiceduedaysextraclient { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItglueId { get; set; } 

    [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clientcurrency { get; set; } 

    [JsonProperty("sentinel_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelSubscriptionId { get; set; } 

    [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelWorkspaceName { get; set; } 

    [JsonProperty("sentinel_resource_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelResourceGroupName { get; set; } 

    [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SentinelTenantId { get; set; } 

    [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelTenantName { get; set; } 

    [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultCurrencyCode { get; set; } 

    [JsonProperty("client_to_invoice_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceRecurring { get; set; } 

    [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientToInvoiceRecurringName { get; set; } 

    [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaAzureTenant>? AzureTenants { get; set; } 

    [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantId { get; set; } 

    [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowId { get; set; } 

    [JsonProperty("snowLicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SnowLicenseAbstract>? SnowLicences { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyId { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; } 

    [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cautomateid { get; set; } 

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyId { get; set; } 

    [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stopped { get; set; } 

    [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Customertype { get; set; } 

    [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? CustomerRelationship { get; set; } 

    [JsonProperty("customer_relationship_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerRelationshipList { get; set; } 

    [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServicenowValidated { get; set; } 

    [JsonProperty("sentinel_default_user_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SentinelDefaultUserOverride { get; set; } 

    [JsonProperty("sentinel_default_user_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelDefaultUserOverrideName { get; set; } 

    [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JiraValidated { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TicketInvoicesForEachSite { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVip { get; set; } 

    [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountownertechName { get; set; } 

    [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Taxable { get; set; } 

    [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuickBooksDetails? QuickbooksDetails { get; set; } 

    [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PercentageToSurvey { get; set; } 

    [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingPlanText { get; set; } 

    [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridepdftemplatequote { get; set; } 

    [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridepdftemplatequoteName { get; set; } 

    [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AvalaraTenant { get; set; } 

    [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DueDateType { get; set; } 

    [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ToplevelQuoteCurrency { get; set; } 

    [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAccount { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Importtypeid { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importtype { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}