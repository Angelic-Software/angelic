using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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