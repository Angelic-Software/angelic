using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Assets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("changeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Changeguid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InventoryNumber { get; set; } 

    [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField { get; set; } 

    [JsonProperty("key_field2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField2 { get; set; } 

    [JsonProperty("key_field3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField3 { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessOwnerId { get; set; } 

    [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerName { get; set; } 

    [JsonProperty("business_owner_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerSite { get; set; } 

    [JsonProperty("business_owner_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerClient { get; set; } 

    [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessOwnerCabId { get; set; } 

    [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerCabName { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalOwnerId { get; set; } 

    [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechnicalOwnerName { get; set; } 

    [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalOwnerCabId { get; set; } 

    [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechnicalOwnerCabName { get; set; } 

    [JsonProperty("intune_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneDefaultSite { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeId { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeName { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? WarrantyEnd { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("is_primary_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrimaryAsset { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; } 

    [JsonProperty("lansweeper_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperParentId { get; set; } 

    [JsonProperty("child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildId { get; set; } 

    [JsonProperty("sibling_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SiblingId { get; set; } 

    [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractValue { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractRef { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierContractId { get; set; } 

    [JsonProperty("supplier_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierContractRef { get; set; } 

    [JsonProperty("supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierSlaId { get; set; } 

    [JsonProperty("supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierPriorityId { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? Fields { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelationshipId { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("default_contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultContractValue { get; set; } 

    [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemstockId { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("stock_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StockDate { get; set; } 

    [JsonProperty("non_consignable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NonConsignable { get; set; } 

    [JsonProperty("reserved_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReservedSalesOrderId { get; set; } 

    [JsonProperty("reserved_salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReservedSalesOrderLineId { get; set; } 

    [JsonProperty("matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchingField { get; set; } 

    [JsonProperty("device42_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device42Id { get; set; } 

    [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Device42Url { get; set; } 

    [JsonProperty("related_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedServices { get; set; } 

    [JsonProperty("technical_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechnicalOwner { get; set; } 

    [JsonProperty("business_owner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwner { get; set; } 

    [JsonProperty("primary_asset_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrimaryAssetChartJson { get; set; } 

    [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Criticality { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("device_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceNumber { get; set; } 

    [JsonProperty("assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AssetTypeGuid { get; set; } 

    [JsonProperty("warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? WarrantyStart { get; set; } 

    [JsonProperty("labour_warranty_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LabourWarrantyStart { get; set; } 

    [JsonProperty("labour_warranty_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LabourWarrantyEnd { get; set; } 

    [JsonProperty("parent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ParentGuid { get; set; } 

    [JsonProperty("child_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ChildGuid { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusId { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyId { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlaName { get; set; } 

    [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PriorityName { get; set; } 

    [JsonProperty("latest_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LatestContractRef { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("ncentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NcentralUrl { get; set; } 

    [JsonProperty("ncentral_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NcentralRemoteUrl { get; set; } 

    [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContractEndDate { get; set; } 

    [JsonProperty("atera_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AteraId { get; set; } 

    [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomateId { get; set; } 

    [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomateUrl { get; set; } 

    [JsonProperty("connectwise_control_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectwiseControlUrl { get; set; } 

    [JsonProperty("ninjarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NinjarmmId { get; set; } 

    [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaUrl { get; set; } 

    [JsonProperty("ninja_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaRemoteUrl { get; set; } 

    [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncroUrl { get; set; } 

    [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Syncroid { get; set; } 

    [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItglueUrl { get; set; } 

    [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultsequence { get; set; } 

    [JsonProperty("service_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceIds { get; set; } 

    [JsonProperty("bulkcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bulkcreated { get; set; } 

    [JsonProperty("bulkbillingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bulkbillingperiod { get; set; } 

    [JsonProperty("asset_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetField { get; set; } 

    [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoAlternateId { get; set; } 

    [JsonProperty("syncro_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncroId { get; set; } 

    [JsonProperty("domotz_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DomotzId { get; set; } 

    [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowId { get; set; } 

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalId { get; set; } 

    [JsonProperty("auvik_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikDeviceId { get; set; } 

    [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikUrl { get; set; } 

    [JsonProperty("allowallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowallstatus { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeStatus>? AllowedStatus { get; set; } 

    [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoId { get; set; } 

    [JsonProperty("addigy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddigyId { get; set; } 

    [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LiongardUrl { get; set; } 

    [JsonProperty("liongard_environmnet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiongardEnvironmnetId { get; set; } 

    [JsonProperty("liongard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LiongardId { get; set; } 

    [JsonProperty("kaseya_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; } 

    [JsonProperty("iskaseyaagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iskaseyaagent { get; set; } 

    [JsonProperty("kaseyavsa_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyavsaUrl { get; set; } 

    [JsonProperty("teamviewerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamviewerid { get; set; } 

    [JsonProperty("serialization_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SerializationUser { get; set; } 

    [JsonProperty("zabbix_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZabbixId { get; set; } 

    [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZabbixUrl { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockbinName { get; set; } 

    [JsonProperty("issue_consignment_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IssueConsignmentLineId { get; set; } 

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemName { get; set; } 

    [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoUrl { get; set; } 

    [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NcentralDetailsId { get; set; } 

    [JsonProperty("nable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NableId { get; set; } 

    [JsonProperty("connectwisecontrolid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connectwisecontrolid { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceId { get; set; } 

    [JsonProperty("workspace_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceUrl { get; set; } 

    [JsonProperty("intune_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntuneId { get; set; } 

    [JsonProperty("supplier_purchasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SupplierPurchasedate { get; set; } 

    [JsonProperty("logicmonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogicmonitorId { get; set; } 

    [JsonProperty("barracudarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BarracudarmmId { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("icinga_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IcingaId { get; set; } 

    [JsonProperty("related_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedServiceName { get; set; } 

    [JsonProperty("related_service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelatedServiceCount { get; set; } 

    [JsonProperty("connectwisermm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectwisermmId { get; set; } 

    [JsonProperty("xensam_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XensamId { get; set; } 

    [JsonProperty("asset_type_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypePriority { get; set; } 

    [JsonProperty("snipeit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnipeitId { get; set; } 

    [JsonProperty("prometheus_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrometheusId { get; set; } 

    [JsonProperty("dynatrace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DynatraceId { get; set; } 

    [JsonProperty("vmworkspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VmworkspaceId { get; set; } 

    [JsonProperty("tanium_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaniumId { get; set; } 

    [JsonProperty("tenable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenableId { get; set; } 

    [JsonProperty("kandji_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KandjiId { get; set; } 

    [JsonProperty("criticality_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CriticalityDescription { get; set; } 

    [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikId { get; set; } 

    [JsonProperty("is_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsTemplate { get; set; } 

    [JsonProperty("aws_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsId { get; set; } 

    [JsonProperty("manageengine_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ManageengineId { get; set; } 

    [JsonProperty("manageengine_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ManageengineCustomerId { get; set; } 

    [JsonProperty("lastchangeofvaluedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastchangeofvaluedate { get; set; } 

    [JsonProperty("commissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Commissiondate { get; set; } 

    [JsonProperty("first_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FirstUserId { get; set; } 

    [JsonProperty("changebackupexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Changebackupexists { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isbatch { get; set; } 

    [JsonProperty("virima_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VirimaId { get; set; } 

    [JsonProperty("service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServiceGuid { get; set; } 

    [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceName { get; set; } 

    [JsonProperty("lansweeperid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lansweeperid { get; set; } 

}