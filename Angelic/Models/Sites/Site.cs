using System.CodeDom.Compiler;
using Angelic.Models.Clients;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Integrations.Microsoft.Dynamics365.BusinessCentral;
using Angelic.Models.ExternalLinks;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Sites;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Site
{
    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsId { get; set; } 

    [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsFirstName { get; set; } 

    [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsLastName { get; set; } 

    [JsonProperty("accountsemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsEmailAddress { get; set; } 

    [JsonProperty("accountsccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsCcEmailAddress { get; set; } 

    [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsBccEmailAddress { get; set; } 

    [JsonProperty("sitephonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Sitephonenumberint { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientSiteName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } 

    [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceAddressIsDelivery { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsStockLocation { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

    [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityInStock { get; set; } 

    [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemSerialisedAssetsInStock { get; set; } 

    [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityReserved { get; set; } 

    [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityReservedOnOrder { get; set; } 

    [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityAvailable { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Text { get; set; } 

    [JsonProperty("globx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Globx { get; set; } 

    [JsonProperty("globy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Globy { get; set; } 

    [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Style { get; set; } 

    [JsonProperty("inuseby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InUseby { get; set; } 

    [JsonProperty("upwho", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Upwho { get; set; } 

    [JsonProperty("uptimestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Uptimestamp { get; set; } 

    [JsonProperty("xrefsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Xrefsite { get; set; } 

    [JsonProperty("zoffsetx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Zoffsetx { get; set; } 

    [JsonProperty("zoffsety", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Zoffsety { get; set; } 

    [JsonProperty("zoomx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Zoomx { get; set; } 

    [JsonProperty("zoomy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Zoomy { get; set; } 

    [JsonProperty("smallx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Smallx { get; set; } 

    [JsonProperty("smally", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Smally { get; set; } 

    [JsonProperty("bigx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bigx { get; set; } 

    [JsonProperty("bigy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bigy { get; set; } 

    [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ldapstring { get; set; } 

    [JsonProperty("emaildomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailDomain { get; set; } 

    [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deliverby { get; set; } 

    [JsonProperty("isinvoicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInvoicesite { get; set; } 

    [JsonProperty("refnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Refnumber { get; set; } 

    [JsonProperty("defaultdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Defaultdelivery { get; set; } 

    [JsonProperty("seriousnesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seriousnesslevel { get; set; } 

    [JsonProperty("geocoord1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Geocoord1 { get; set; } 

    [JsonProperty("geocoord2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Geocoord2 { get; set; } 

    [JsonProperty("todomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Todomain { get; set; } 

    [JsonProperty("defaultstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultStocklocation { get; set; } 

    [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stopped { get; set; } 

    [JsonProperty("sitetimeoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitetimeoffset { get; set; } 

    [JsonProperty("sitedateformat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitedateformat { get; set; } 

    [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisclaimerMatchString { get; set; } 

    [JsonProperty("emailsubjectprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubjectprefix { get; set; } 

    [JsonProperty("regionaldirector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Regionaldirector { get; set; } 

    [JsonProperty("facilitiesmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Facilitiesmanager { get; set; } 

    [JsonProperty("actguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActGuid { get; set; } 

    [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamViewerPassword { get; set; } 

    [JsonProperty("contractlastchecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Contractlastchecked { get; set; } 

    [JsonProperty("maincontact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MaincontactName { get; set; } 

    [JsonProperty("wildcardref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Wildcardref { get; set; } 

    [JsonProperty("monthlyreportlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Monthlyreportlastrun { get; set; } 

    [JsonProperty("monthlyreportinclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportinclude { get; set; } 

    [JsonProperty("monthlyreportemailmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportemailmanager { get; set; } 

    [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AccountManagerTech { get; set; } 

    [JsonProperty("monthlyreportemaildirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportemaildirect { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LanguageId { get; set; } 

    [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LanguageName { get; set; } 

    [JsonProperty("snowname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snowname { get; set; } 

    [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedOrganisationId { get; set; } 

    [JsonProperty("slocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Slocked { get; set; } 

    [JsonProperty("newsite_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSiteContactName { get; set; } 

    [JsonProperty("newsite_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSiteContactemail { get; set; } 

    [JsonProperty("newsite_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSiteContacttitle { get; set; } 

    [JsonProperty("newsite_web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewSiteWebAccessLevel { get; set; } 

    [JsonProperty("newsite_sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewSiteSendwelcomeemail { get; set; } 

    [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? DeliveryAddress { get; set; } 

    [JsonProperty("invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? InvoiceAddress { get; set; } 

    [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PopupNote>? PopupNotes { get; set; } 

    [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReassignAllToUser { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? Fields { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OnholdTicketCount { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalTicketCount { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenedThisMonthCount { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Guid { get; set; } 

    [JsonProperty("sitecontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteContact>? Sitecontacts { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CAutomateId { get; set; } 

    [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NinjaRmmId { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("_isxero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isxero { get; set; } 

    [JsonProperty("_match_first_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchFirstSite { get; set; } 

    [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowid { get; set; } 

    [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNhServerEmailDefault { get; set; } 

    [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device42Id { get; set; } 

    [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoId { get; set; } 

    [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoAlternateId { get; set; } 

    [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoUrl { get; set; } 

    [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseId { get; set; } 

    [JsonProperty("azuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantid { get; set; } 

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoTaskId { get; set; } 

    [JsonProperty("pagerdutywildcard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pagerdutywildcard { get; set; } 

    [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AteraId { get; set; } 

    [JsonProperty("slastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SlaStupdate { get; set; } 

    [JsonProperty("site_service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteServiceTaxCode { get; set; } 

    [JsonProperty("site_prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SitePrepayTaxCode { get; set; } 

    [JsonProperty("site_contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteContractTaxCode { get; set; } 

    [JsonProperty("site_item_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteItemTaxCodeName { get; set; } 

    [JsonProperty("site_service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteServiceTaxCodeName { get; set; } 

    [JsonProperty("site_contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteContractTaxCodeName { get; set; } 

    [JsonProperty("site_prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SitePrepayTaxCodeName { get; set; } 

    [JsonProperty("site_sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteSalesTaxCode { get; set; } 

    [JsonProperty("site_purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SitePurchaseTaxCode { get; set; } 

    [JsonProperty("site_purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SitePurchaseTaxCodeName { get; set; } 

    [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncroId { get; set; } 

    [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyClientName { get; set; } 

    [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikId { get; set; } 

    [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaqListHead>? FaqLists { get; set; } 

    [JsonProperty("all_faqlists_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllFaqListsAllowed { get; set; } 

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotId { get; set; } 

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalId { get; set; } 

    [JsonProperty("import_site_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportSiteMapping { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("issitedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSitedetails { get; set; } 

    [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HuduUrl { get; set; } 

    [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiongardId { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; } 

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SurchargeId { get; set; } 

    [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCode { get; set; } 

    [JsonProperty("region_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RegionCode { get; set; } 

    [JsonProperty("stockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StockBin>? Stockbins { get; set; } 

    [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NCentralDetailsId { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; } 

    [JsonProperty("hasitemsinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasitemsinstock { get; set; } 

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontFireAutomations { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlImportId { get; set; } 

    [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchingValue { get; set; } 

    [JsonProperty("lapsafe_default_installation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LapsafeDefaultInstallationName { get; set; } 

    [JsonProperty("lapsafe_default_installation_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? LapsafeDefaultInstallationObj { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ExternalLinks { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabs>? ExtraTabs { get; set; } 

    [JsonProperty("businesscentral_area_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessCentralAreaCompanyId { get; set; } 

    [JsonProperty("businesscentral_billing_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BusinessCentralCustomer? BusinessCentralBillingClient { get; set; } 

    [JsonProperty("_convert_phonenumbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConvertPhoneNumbers { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("authrocket_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthrocketLocale { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? SiteFields { get; set; } 

    [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gfisiteid { get; set; } 

    [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine1 { get; set; } 

    [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine2 { get; set; } 

    [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine3 { get; set; } 

    [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine4 { get; set; } 

    [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine5 { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItGlueId { get; set; } 

    [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientItGlueId { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? CustomButtons { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockbinName { get; set; } 

    [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCodeName { get; set; } 

    [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RegionCodeName { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LapsafeDefaultInstallation { get; set; } 

    [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaincontactId { get; set; } 

    [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteItemTaxCode { get; set; } 

}