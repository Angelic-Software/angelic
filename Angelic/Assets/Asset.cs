using System.CodeDom.Compiler;
using Angelic.Configuration;
using Angelic.Configuration.CustomFields;
using Angelic.Configuration.Integrations.Lansweeper;
using Angelic.Configuration.Integrations.Snow;
using Angelic.Contracts;
using Angelic.Items;
using Angelic.PurchaseOrders;
using Angelic.Tickets;
using Angelic.Users;
using Newtonsoft.Json;
using Guid = System.Guid;

namespace Angelic.Assets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Asset 
{

    [JsonProperty("os_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OsOverride { get; set; } 

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
    public int? ReservedSalesorderId { get; set; } 

    [JsonProperty("reserved_salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReservedSalesorderLineId { get; set; } 

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

    [JsonProperty("ascendant_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AscendantCount { get; set; } 

    [JsonProperty("ascendant_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? AscendantAssets { get; set; } 

    [JsonProperty("descendant_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DescendantCount { get; set; } 

    [JsonProperty("descendant_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? DescendantAssets { get; set; } 

    [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCount { get; set; } 

    [JsonProperty("user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserCount { get; set; } 

    [JsonProperty("licence_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceCount { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("pingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pingservice { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Guid { get; set; } 

    [JsonProperty("import_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ImportGuid { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("contractvaluecurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Contractvaluecurrent { get; set; } 

    [JsonProperty("contractvalueprior", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Contractvalueprior { get; set; } 

    [JsonProperty("warranty_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WarrantyNote { get; set; } 

    [JsonProperty("goodsin_po_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GoodsinPoId { get; set; } 

    [JsonProperty("issue_consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IssueConsignmentId { get; set; } 

    [JsonProperty("supplier_expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SupplierExpirydate { get; set; } 

    [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierReference { get; set; } 

    [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyIdString { get; set; } 

    [JsonProperty("supplierheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplierheaderid { get; set; } 

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseorderLineId { get; set; } 

    [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamviewerpassword { get; set; } 

    [JsonProperty("commissioned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Commissioned { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kaseyaid { get; set; } 

    [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? Children { get; set; } 

    [JsonProperty("parent_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? ParentAssets { get; set; } 

    [JsonProperty("child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? ChildAssets { get; set; } 

    [JsonProperty("hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? Hierarchy { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; } 

    [JsonProperty("clone_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CloneCount { get; set; } 

    [JsonProperty("_dontaddnewfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontaddnewfields { get; set; } 

    [JsonProperty("_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontupdatetype { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlaName { get; set; } 

    [JsonProperty("supplier_sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierSlaName { get; set; } 

    [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PriorityName { get; set; } 

    [JsonProperty("supplier_priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierPriorityName { get; set; } 

    [JsonProperty("clone_inventory_numbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CloneInventoryNumbers { get; set; } 

    [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsClone { get; set; } 

    [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractHeaderList>? Contracts { get; set; } 

    [JsonProperty("scheduled_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestList>? ScheduledTickets { get; set; } 

    [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteGuid { get; set; } 

    [JsonProperty("sqlimport_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlimportUser { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlimportId { get; set; } 

    [JsonProperty("software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetApplications>? Software { get; set; } 

    [JsonProperty("businesscentral_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinesscentralId { get; set; } 

    [JsonProperty("intune_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntuneId { get; set; } 

    [JsonProperty("intune_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneConnectionid { get; set; } 

    [JsonProperty("azure_userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureUserid { get; set; } 

    [JsonProperty("azure_userprincipalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureUserprincipalname { get; set; } 

    [JsonProperty("stockdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ItemStock? Stockdetails { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetgroupName { get; set; } 

    [JsonProperty("prtg_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrtgId { get; set; } 

    [JsonProperty("prtg_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrtgDetailsId { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? Services { get; set; } 

    [JsonProperty("datto_site_uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoSiteUid { get; set; } 

    [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ateraid { get; set; } 

    [JsonProperty("items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketItem>? ItemsIssued { get; set; } 

    [JsonProperty("lansweeper_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperId { get; set; } 

    [JsonProperty("lansweeper_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperUrl { get; set; } 

    [JsonProperty("lansweeper_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LansweeperSoftware>? LansweeperSoftware { get; set; } 

    [JsonProperty("dlastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dlastupdate { get; set; } 

    [JsonProperty("createdfrompurchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PurchaseOrder? Createdfrompurchaseorder { get; set; } 

    [JsonProperty("stockdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Stockdate { get; set; } 

    [JsonProperty("item_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemCost { get; set; } 

    [JsonProperty("old_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OldSoftwareVersion { get; set; } 

    [JsonProperty("new_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSoftwareVersion { get; set; } 

    [JsonProperty("user_role_breakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetUserCount>? UserRoleBreakdown { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItglueId { get; set; } 

    [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AreaGuid { get; set; } 

    [JsonProperty("jamf_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JamfId { get; set; } 

    [JsonProperty("jamf_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JamfType { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("bookmarked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bookmarked { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OnholdTicketCount { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalTicketCount { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenedThismonthCount { get; set; } 

    [JsonProperty("domotz_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzAgentid { get; set; } 

    [JsonProperty("domotz_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzId { get; set; } 

    [JsonProperty("domotz_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzTypeId { get; set; } 

    [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowClientId { get; set; } 

    [JsonProperty("deactivate_child_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeactivateChildDevices { get; set; } 

    [JsonProperty("auvik_network_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikNetworkId { get; set; } 

    [JsonProperty("parent_third_party_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ParentThirdPartyIds { get; set; } 

    [JsonProperty("snowUsers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SnowComputerUserAbstract>? SnowUsers { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? TabConfig { get; set; } 

    [JsonProperty("qualys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QualysId { get; set; } 

    [JsonProperty("assettype_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AssetType? AssetTypeConfig { get; set; } 

    [JsonProperty("passportal_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalClientId { get; set; } 

    [JsonProperty("addigy_policy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddigyPolicyId { get; set; } 

    [JsonProperty("addigy_applications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AddigyApplication>? AddigyApplications { get; set; } 

    [JsonProperty("addigy_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? AddigyUsers { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("isassetdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isassetdetails { get; set; } 

    [JsonProperty("domotz_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DomotzAgent { get; set; } 

    [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Liongardid { get; set; } 

    [JsonProperty("iskaseyaagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iskaseyaagent { get; set; } 

    [JsonProperty("_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Donotvalidate { get; set; } 

    [JsonProperty("datto_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoRemoteUrl { get; set; } 

    [JsonProperty("qualys_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QualysHostAssetSoftwareHostAssetSoftware>? QualysSoftware { get; set; } 

    [JsonProperty("xtypeunamecanedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RtPermission>? Xtypeunamecanedit { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdpartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("ethernetMacAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EthernetMacAddress { get; set; } 

    [JsonProperty("physicalMemoryInBytes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhysicalMemoryInBytes { get; set; } 

    [JsonProperty("azureTenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantId { get; set; } 

    [JsonProperty("services_hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSite>? ServicesHierarchy { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Validateonly { get; set; } 

    [JsonProperty("copy_unmapped_info_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyUnmappedInfoFields { get; set; } 

    [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserEmail { get; set; } 

    [JsonProperty("lansweeper_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LansweeperRelation>? LansweeperRelations { get; set; } 

    [JsonProperty("kbs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KbEntryList>? Kbs { get; set; } 

    [JsonProperty("site_external_link_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteExternalLinkId { get; set; } 

    [JsonProperty("workspace_orgunitpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceOrgunitpath { get; set; } 

    [JsonProperty("sibling_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? SiblingAssets { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; } 

    [JsonProperty("icinga_hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IcingaHostname { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("new_access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? NewAccessControl { get; set; } 

    [JsonProperty("jamf_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JamfDetailsId { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("is_stock_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsStockChange { get; set; } 

    [JsonProperty("parent_third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentThirdPartyId { get; set; } 

    [JsonProperty("is_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsReturn { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValue