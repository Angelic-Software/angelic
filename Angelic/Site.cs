using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Site
{
    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsid { get; set; } 

    [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsfirstname { get; set; } 

    [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountslastname { get; set; } 

    [JsonProperty("accountsemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsemailaddress { get; set; } 

    [JsonProperty("accountsccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsccemailaddress { get; set; } 

    [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsbccemailaddress { get; set; } 

    [JsonProperty("sitephonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Sitephonenumberint { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Client_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clientsite_name { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sla_id { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; } 

    [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invoice_address_isdelivery { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isstocklocation { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

    [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_in_stock { get; set; } 

    [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_serialised_assets_in_stock { get; set; } 

    [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_reserved { get; set; } 

    [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_reserved_on_order { get; set; } 

    [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_available { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Text { get; set; } 

    [JsonProperty("globx", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Globx { get; set; } 

    [JsonProperty("globy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Globy { get; set; } 

    [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Style { get; set; } 

    [JsonProperty("inuseby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inuseby { get; set; } 

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
    public string? Emaildomain { get; set; } 

    [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deliverby { get; set; } 

    [JsonProperty("isinvoicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isinvoicesite { get; set; } 

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
    public int? Defaultstocklocation { get; set; } 

    [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stopped { get; set; } 

    [JsonProperty("sitetimeoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitetimeoffset { get; set; } 

    [JsonProperty("sitedateformat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitedateformat { get; set; } 

    [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Disclaimermatchstring { get; set; } 

    [JsonProperty("emailsubjectprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubjectprefix { get; set; } 

    [JsonProperty("regionaldirector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Regionaldirector { get; set; } 

    [JsonProperty("facilitiesmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Facilitiesmanager { get; set; } 

    [JsonProperty("actguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Actguid { get; set; } 

    [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamviewerpassword { get; set; } 

    [JsonProperty("contractlastchecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Contractlastchecked { get; set; } 

    [JsonProperty("maincontact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Maincontact_name { get; set; } 

    [JsonProperty("wildcardref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Wildcardref { get; set; } 

    [JsonProperty("monthlyreportlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Monthlyreportlastrun { get; set; } 

    [JsonProperty("monthlyreportinclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportinclude { get; set; } 

    [JsonProperty("monthlyreportemailmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportemailmanager { get; set; } 

    [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Accountmanagertech { get; set; } 

    [JsonProperty("monthlyreportemaildirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Monthlyreportemaildirect { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Language_id { get; set; } 

    [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Language_name { get; set; } 

    [JsonProperty("snowname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snowname { get; set; } 

    [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_organisation_id { get; set; } 

    [JsonProperty("slocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Slocked { get; set; } 

    [JsonProperty("newsite_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Newsite_contactname { get; set; } 

    [JsonProperty("newsite_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Newsite_contactemail { get; set; } 

    [JsonProperty("newsite_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Newsite_contacttitle { get; set; } 

    [JsonProperty("newsite_web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newsite_web_access_level { get; set; } 

    [JsonProperty("newsite_sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newsite_sendwelcomeemail { get; set; } 

    [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Delivery_address { get; set; } 

    [JsonProperty("invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Invoice_address { get; set; } 

    [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaPopup>? Popup_notes { get; set; } 

    [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _reassign_all_to_user { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? Fields { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_ticket_count { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Onhold_ticket_count { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_ticket_count { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Opened_thismonth_count { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Guid { get; set; } 

    [JsonProperty("sitecontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteContact>? Sitecontacts { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cautomateid { get; set; } 

    [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ninjarmmid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("_isxero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isxero { get; set; } 

    [JsonProperty("_match_first_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _match_first_site { get; set; } 

    [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicenowid { get; set; } 

    [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isnhserveremaildefault { get; set; } 

    [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device42id { get; set; } 

    [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datto_id { get; set; } 

    [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Datto_alternate_id { get; set; } 

    [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datto_url { get; set; } 

    [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connectwiseid { get; set; } 

    [JsonProperty("azuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Azuretenantid { get; set; } 

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskid { get; set; } 

    [JsonProperty("pagerdutywildcard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pagerdutywildcard { get; set; } 

    [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ateraid { get; set; } 

    [JsonProperty("slastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Slastupdate { get; set; } 

    [JsonProperty("site_service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_service_tax_code { get; set; } 

    [JsonProperty("site_prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_prepay_tax_code { get; set; } 

    [JsonProperty("site_contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_contract_tax_code { get; set; } 

    [JsonProperty("site_item_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_item_tax_code_name { get; set; } 

    [JsonProperty("site_service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_service_tax_code_name { get; set; } 

    [JsonProperty("site_contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_contract_tax_code_name { get; set; } 

    [JsonProperty("site_prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_prepay_tax_code_name { get; set; } 

    [JsonProperty("site_sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_sales_tax_code { get; set; } 

    [JsonProperty("site_purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_purchase_tax_code { get; set; } 

    [JsonProperty("site_purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_purchase_tax_code_name { get; set; } 

    [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Syncroid { get; set; } 

    [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_client_name { get; set; } 

    [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Auvik_id { get; set; } 

    [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FAQListHead>? Faqlists { get; set; } 

    [JsonProperty("all_faqlists_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? All_faqlists_allowed { get; set; } 

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hubspot_id { get; set; } 

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Passportal_id { get; set; } 

    [JsonProperty("import_site_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_site_mapping { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("issitedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Issitedetails { get; set; } 

    [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hudu_url { get; set; } 

    [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Liongardid { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kaseyaid { get; set; } 

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Surchargeid { get; set; } 

    [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country_code { get; set; } 

    [JsonProperty("region_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Region_code { get; set; } 

    [JsonProperty("stockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StockBin>? Stockbins { get; set; } 

    [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ncentral_details_id { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_details_id { get; set; } 

    [JsonProperty("hasitemsinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasitemsinstock { get; set; } 

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dont_fire_automations { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sqlimport_id { get; set; } 

    [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Matching_value { get; set; } 

    [JsonProperty("lapsafe_default_installation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lapsafe_default_installation_name { get; set; } 

    [JsonProperty("lapsafe_default_installation_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Lapsafe_default_installation_obj { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? External_links { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("businesscentral_area_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Businesscentral_area_company_id { get; set; } 

    [JsonProperty("businesscentral_billing_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public BusinessCentralCustomer? Businesscentral_billing_client { get; set; } 

    [JsonProperty("_convert_phonenumbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _convert_phonenumbers { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("authrocket_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authrocket_locale { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? Site_fields { get; set; } 

    [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gfisiteid { get; set; } 

    [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line1 { get; set; } 

    [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line2 { get; set; } 

    [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line3 { get; set; } 

    [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line4 { get; set; } 

    [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line5 { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itglue_id { get; set; } 

    [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_itglue_id { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stockbin_name { get; set; } 

    [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country_code_name { get; set; } 

    [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Region_code_name { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lapsafe_default_installation { get; set; } 

    [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Maincontact_id { get; set; } 

    [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_item_tax_code { get; set; } 

}