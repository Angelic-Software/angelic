using System.CodeDom.Compiler;
using Angelic.Configuration.CustomFields;
using Angelic.Configuration.Integrations;
using Angelic.KeyPairs;
using Angelic.Users;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Supplier
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ToplevelId { get; set; } 

    [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ToplevelName { get; set; } 

    [JsonProperty("contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContactName { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("support_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupportEmailAddress { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailtemplateId { get; set; } 

    [JsonProperty("default_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContractId { get; set; } 

    [JsonProperty("default_contract_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContractSlaId { get; set; } 

    [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartynhdapiurl { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("contract_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractCount { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("phone_number_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber2 { get; set; } 

    [JsonProperty("phone_number_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber3 { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } 

    [JsonProperty("switchslatosupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Switchslatosupplier { get; set; } 

    [JsonProperty("emailoverduefixby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailoverduefixby { get; set; } 

    [JsonProperty("emailoverdueresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailoverdueresponse { get; set; } 

    [JsonProperty("webserviceurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webserviceurl { get; set; } 

    [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailtemplateName { get; set; } 

    [JsonProperty("accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsId { get; set; } 

    [JsonProperty("portal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalUrl { get; set; } 

    [JsonProperty("portal_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalRef { get; set; } 

    [JsonProperty("portal_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalUsername { get; set; } 

    [JsonProperty("portal_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalPassword { get; set; } 

    [JsonProperty("contact_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContactTitle { get; set; } 

    [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fax { get; set; } 

    [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailStartTag { get; set; } 

    [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailEndTag { get; set; } 

    [JsonProperty("usesnhd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usesnhd { get; set; } 

    [JsonProperty("nhdurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhdurl { get; set; } 

    [JsonProperty("nhdemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhdemailaddress { get; set; } 

    [JsonProperty("nhdpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhdpassword { get; set; } 

    [JsonProperty("parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentid { get; set; } 

    [JsonProperty("emaildomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emaildomain { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; } 

    [JsonProperty("allow_api_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowApiAccess { get; set; } 

    [JsonProperty("api_access_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAccessClientid { get; set; } 

    [JsonProperty("api_access_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAccessClientsecret { get; set; } 

    [JsonProperty("thirdpartynhdauthurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartynhdauthurl { get; set; } 

    [JsonProperty("thirdpartynhdtenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartynhdtenant { get; set; } 

    [JsonProperty("thirdpartynhdapiclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartynhdapiclientid { get; set; } 

    [JsonProperty("new_thirdpartynhdapiclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewThirdpartynhdapiclientsecret { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflowid { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowTenantId { get; set; } 

    [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KashflowTenantName { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantId { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantName { get; set; } 

    [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroId { get; set; } 

    [JsonProperty("is_xero_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsXeroArchived { get; set; } 

    [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("issupplierdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Issupplierdetails { get; set; } 

    [JsonProperty("jira_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUrl { get; set; } 

    [JsonProperty("jira_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUsername { get; set; } 

    [JsonProperty("new_jirakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewJirakey { get; set; } 

    [JsonProperty("test_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestJira { get; set; } 

    [JsonProperty("jira_servicedesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraServicedeskId { get; set; } 

    [JsonProperty("jira_servicedesk_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraServicedeskName { get; set; } 

    [JsonProperty("jira_servicedesk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraServicedesk { get; set; } 

    [JsonProperty("jira_requesttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraRequesttypeMappings { get; set; } 

    [JsonProperty("jira_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUserId { get; set; } 

    [JsonProperty("jira_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUserName { get; set; } 

    [JsonProperty("jira_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraUser { get; set; } 

    [JsonProperty("jira_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraPriorityMappings { get; set; } 

    [JsonProperty("jira_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraStatusMappings { get; set; } 

    [JsonProperty("create_jira_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateJiraWebhook { get; set; } 

    [JsonProperty("jira_webhook_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JiraWebhookCreated { get; set; } 

    [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncedToIntacct { get; set; } 

    [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctLocationId { get; set; } 

    [JsonProperty("intacct_location_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? IntacctLocationIdList { get; set; } 

    [JsonProperty("intacct_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctLocationType { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("default_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCurrencyCodeName { get; set; } 

    [JsonProperty("ignore_from_accounting_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreFromAccountingSync { get; set; } 

    [JsonProperty("intacct_default_save_loc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultSaveLoc { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowUrl { get; set; } 

    [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowLocale { get; set; } 

    [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowUsername { get; set; } 

    [JsonProperty("new_servicenowkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewServicenowkey { get; set; } 

    [JsonProperty("servicenow_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowPriorityMappings { get; set; } 

    [JsonProperty("servicenow_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowStatusMappings { get; set; } 

    [JsonProperty("servicenow_impact_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowImpactMappings { get; set; } 

    [JsonProperty("servicenow_urgency_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowUrgencyMappings { get; set; } 

    [JsonProperty("servicenow_category_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowCategoryMappings { get; set; } 

    [JsonProperty("servicenow_assignment_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowAssignmentGroup { get; set; } 

    [JsonProperty("servicenow_assignment_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowAssignmentGroupName { get; set; } 

    [JsonProperty("servicenow_assignmentgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ServicenowAssignmentgroup { get; set; } 

    [JsonProperty("servicenow_defaultuser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowDefaultuserId { get; set; } 

    [JsonProperty("servicenow_defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowDefaultuserName { get; set; } 

    [JsonProperty("servicenow_defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ServicenowDefaultuser { get; set; } 

    [JsonProperty("test_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestServicenow { get; set; } 

    [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MyobTenant { get; set; } 

    [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MyobTenantName { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseTaxCode { get; set; } 

    [JsonProperty("purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseTaxCodeName { get; set; } 

    [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncServicenowAttachments { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("servicenow_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowTeamMappings { get; set; } 

    [JsonProperty("servicenow_ticket_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicenowTicketSync { get; set; } 

    [JsonProperty("servicenow_ticket_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? ServicenowTicketSyncList { get; set; } 

    [JsonProperty("servicenow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServicenowFieldmappings { get; set; } 

    [JsonProperty("jira_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JiraWebhookUser { get; set; } 

    [JsonProperty("jira_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraWebhookUsername { get; set; } 

    [JsonProperty("supplier_invoice_due_date_extra_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierInvoiceDueDateExtraDays { get; set; } 

    [JsonProperty("is_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSupplier { get; set; } 

    [JsonProperty("is_manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsManufacturer { get; set; } 

    [JsonProperty("servicenow_authtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicenowAuthtype { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyId { get; set; } 

    [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JiraValidated { get; set; } 

    [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultCurrencyCode { get; set; } 

    [JsonProperty("supplier_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierMailboxOverride { get; set; } 

    [JsonProperty("supplier_mailbox_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierMailboxAddress { get; set; } 

    [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServicenowValidated { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; } 

    [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobile { get; set; } 

}