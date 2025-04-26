using System.CodeDom.Compiler;
using Angelic.Attachments;
using Angelic.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Users;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UsersList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SiteId { get; set; } 

    [JsonProperty("site_id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteIdInt { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Firstname { get; set; } 

    [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Surname { get; set; } 

    [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initials { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("phonenumber_preferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhonenumberPreferred { get; set; } 

    [JsonProperty("sitephonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sitephonenumber { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("homenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Homenumber { get; set; } 

    [JsonProperty("mobilenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobilenumber { get; set; } 

    [JsonProperty("mobilenumber2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobilenumber2 { get; set; } 

    [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fax { get; set; } 

    [JsonProperty("telpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Telpref { get; set; } 

    [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActivedirectoryDn { get; set; } 

    [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OnpremiseActivedirectoryDn { get; set; } 

    [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContainerDn { get; set; } 

    [JsonProperty("login", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Login { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimportantcontact { get; set; } 

    [JsonProperty("other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other1 { get; set; } 

    [JsonProperty("other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other2 { get; set; } 

    [JsonProperty("other3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other3 { get; set; } 

    [JsonProperty("other4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other4 { get; set; } 

    [JsonProperty("other5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Other5 { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("neversendemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Neversendemails { get; set; } 

    [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultCurrencyCode { get; set; } 

    [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteGuid { get; set; } 

    [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AreaGuid { get; set; } 

    [JsonProperty("site_cautomate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteCautomateGuid { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("linked_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedAgentId { get; set; } 

    [JsonProperty("covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CoveredByContract { get; set; } 

    [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractValue { get; set; } 

    [JsonProperty("software_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SoftwareRoleName { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelationshipId { get; set; } 

    [JsonProperty("user_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeRole>? UserRelationships { get; set; } 

    [JsonProperty("uddevsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uddevsite { get; set; } 

    [JsonProperty("uddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uddevnum { get; set; } 

    [JsonProperty("uduserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uduserid { get; set; } 

    [JsonProperty("userdevicerolecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserDevicerolecount { get; set; } 

    [JsonProperty("site_hubspot_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteHubspotGuid { get; set; } 

    [JsonProperty("isserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isserviceaccount { get; set; } 

    [JsonProperty("ignoreautomatedbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoreautomatedbilling { get; set; } 

    [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimportantcontact2 { get; set; } 

    [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connectwiseid { get; set; } 

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskid { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

    [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleList { get; set; } 

    [JsonProperty("sitetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sitetimezone { get; set; } 

    [JsonProperty("client_account_manager_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientAccountManagerId { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; } 

    [JsonProperty("client_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClientTaxable { get; set; } 

    [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridepdftemplatequote { get; set; } 

    [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridepdftemplatequoteName { get; set; } 

    [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContractEndDate { get; set; } 

    [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OktaId { get; set; } 

    [JsonProperty("azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureId { get; set; } 

    [JsonProperty("user_with_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserWithClientsite { get; set; } 

    [JsonProperty("client_automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientAutomaticCallscriptId { get; set; } 

    [JsonProperty("neversendmarketingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Neversendmarketingemails { get; set; } 

    [JsonProperty("is_prospect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsProspect { get; set; } 

    [JsonProperty("whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhatsappNumber { get; set; } 

    [JsonProperty("azureoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azureoid { get; set; } 

    [JsonProperty("date_of_birth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateOfBirth { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}