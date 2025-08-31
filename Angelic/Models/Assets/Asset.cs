using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Assets;
using Angelic.Models.Configuration.Assets.AssetTypes;
using Angelic.Models.Configuration.Assets.SoftwareLicensing;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Custom.CustomTabs;
using Angelic.Models.Configuration.Integrations.Addigy;
using Angelic.Models.Configuration.Integrations.Dynatrace;
using Angelic.Models.Configuration.Integrations.Lansweeper;
using Angelic.Models.Configuration.Integrations.Qualys;
using Angelic.Models.Configuration.Integrations.Snow;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.Configuration.Tickets.Templates;
using Angelic.Models.Contracts;
using Angelic.Models.ExternalLinks;
using Angelic.Models.Items;
using Angelic.Models.KnowledgeBase;
using Angelic.Models.PurchaseOrders;
using Angelic.Models.Tickets;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Assets;

/// <summary>
/// This class is the data structure for assets that are recorded on Halo.
/// SQL database table name: DEVICE.
/// </summary>
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
[Table("DEVICE")]
public class Asset
{
    [JsonProperty("os_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OsOverride { get; set; }

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("changeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ChangeGuid { get; set; }

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

    [JsonProperty("technical_owner_cab_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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
    public ICollection<CustomButton>? CustomButtons { get; set; }

    [JsonProperty("default_contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultContractValue { get; set; }

    [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemStockId { get; set; }

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; }

    [JsonProperty("stock_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StockDateWithUnderscore { get; set; }

    [JsonProperty("non_consignable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NonConsignable { get; set; }

    [JsonProperty("reserved_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReservedSalesOrderId { get; set; }

    [JsonProperty("reserved_salesorder_line_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("primary_asset_chart_json", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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
    public int? PingService { get; set; }

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Guid { get; set; }

    [JsonProperty("import_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ImportGuid { get; set; }

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; }

    [JsonProperty("contractvaluecurrent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractValueCurrent { get; set; }

    [JsonProperty("contractvalueprior", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractValuePrior { get; set; }

    [JsonProperty("warranty_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WarrantyNote { get; set; }

    [JsonProperty("goodsin_po_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GoodsInPoId { get; set; }

    [JsonProperty("issue_consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IssueConsignmentId { get; set; }

    [JsonProperty("supplier_expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SupplierExpiryDate { get; set; }

    [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierReference { get; set; }

    [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyIdString { get; set; }

    [JsonProperty("supplierheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierHeaderId { get; set; }

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderLineId { get; set; }

    [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamViewerPassword { get; set; }

    [JsonProperty("commissioned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Commissioned { get; set; }

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; }

    [JsonProperty("children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? Children { get; set; }

    [JsonProperty("parent_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? ParentAssets { get; set; }

    [JsonProperty("child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? ChildAssets { get; set; }

    [JsonProperty("hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? Hierarchy { get; set; }

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; }

    [JsonProperty("clone_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CloneCount { get; set; }

    [JsonProperty("_dontaddnewfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontAddNewFields { get; set; }

    [JsonProperty("_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateType { get; set; }

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
    public ICollection<TemplateList>? ScheduledTickets { get; set; }

    [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteGuid { get; set; }

    [JsonProperty("sqlimport_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlImportUser { get; set; }

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlImportId { get; set; }

    [JsonProperty("software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetApplications>? Software { get; set; }

    [JsonProperty("businesscentral_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessCentralId { get; set; }

    [JsonProperty("intune_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntuneId { get; set; }

    [JsonProperty("intune_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneConnectionId { get; set; }

    [JsonProperty("azure_userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureUserid { get; set; }

    [JsonProperty("azure_userprincipalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureUserPrincipalName { get; set; }

    [JsonProperty("stockdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ItemStock? StockDetails { get; set; }

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetGroupName { get; set; }

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
    public string? AteraId { get; set; }

    [JsonProperty("items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketItem>? ItemsIssued { get; set; }

    [JsonProperty("lansweeper_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperIdWithUnderscore { get; set; }

    [JsonProperty("lansweeper_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperUrl { get; set; }

    [JsonProperty("lansweeper_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LansweeperSoftware>? LansweeperSoftware { get; set; }

    [JsonProperty("dlastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DLastUpdate { get; set; }

    [JsonProperty("createdfrompurchaseorder", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public PurchaseOrder? CreatedFromPurchaseOrder { get; set; }

    [JsonProperty("stockdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StockDate { get; set; }

    [JsonProperty("item_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemCost { get; set; }

    [JsonProperty("old_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OldSoftwareVersion { get; set; }

    [JsonProperty("new_software_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSoftwareVersion { get; set; }

    [JsonProperty("user_role_breakdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetUserCount>? UserRoleBreakdown { get; set; }

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItGlueId { get; set; }

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
    public int? OpenedThisMonthCount { get; set; }

    [JsonProperty("domotz_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzAgentId { get; set; }

    [JsonProperty("domotz_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzId { get; set; }

    [JsonProperty("domotz_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DomotzTypeId { get; set; }

    [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowClientId { get; set; }

    [JsonProperty("deactivate_child_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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
    public bool? IsAssetDetails { get; set; }

    [JsonProperty("domotz_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DomotzAgent { get; set; }

    [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiongardId { get; set; }

    [JsonProperty("iskaseyaagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsKaseyaAgent { get; set; }

    [JsonProperty("_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotValidate { get; set; }

    [JsonProperty("datto_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoRemoteUrl { get; set; }

    [JsonProperty("qualys_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QualysHostAssetSoftwareHostAssetSoftware>? QualysSoftware { get; set; }

    [JsonProperty("xtypeunamecanedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetEditingPermissions>? XTypeUnameCanEdit { get; set; }

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ExternalLinks { get; set; }

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; }

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; }

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
    public bool? ValidateOnly { get; set; }

    [JsonProperty("copy_unmapped_info_fields", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyUnmappedInfoFields { get; set; }

    [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserEmail { get; set; }

    [JsonProperty("lansweeper_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LansweeperRelation>? LansweeperRelations { get; set; }

    [JsonProperty("kbs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KbArticleList>? Kbs { get; set; }

    [JsonProperty("site_external_link_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteExternalLinkId { get; set; }

    [JsonProperty("workspace_orgunitpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceOrgUnitPath { get; set; }

    [JsonProperty("sibling_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? SiblingAssets { get; set; }

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

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; }

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrintHtml { get; set; }

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; }

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontFireAutomations { get; set; }

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; }

    [JsonProperty("asset_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetChartJson { get; set; }

    [JsonProperty("lansweeper_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperSiteId { get; set; }

    [JsonProperty("thirdparty_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyClientId { get; set; }

    [JsonProperty("syncro_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncroAssetType { get; set; }

    [JsonProperty("dynatrace_to_relations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DynatraceRelationship>? DynatraceToRelations { get; set; }

    [JsonProperty("dynatrace_from_relations", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DynatraceRelationship>? DynatraceFromRelations { get; set; }

    [JsonProperty("open_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenIncidentCount { get; set; }

    [JsonProperty("open_change_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenChangeCount { get; set; }

    [JsonProperty("thirdparty_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyTypeId { get; set; }

    [JsonProperty("is_stock_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsStockSite { get; set; }

    [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchingValue { get; set; }

    [JsonProperty("related_service_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedServiceNames { get; set; }

    [JsonProperty("parent_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentAssetNames { get; set; }

    [JsonProperty("child_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChildAssetNames { get; set; }

    [JsonProperty("sibling_asset_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiblingAssetNames { get; set; }

    [JsonProperty("related_kb_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedKbNames { get; set; }

    [JsonProperty("licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceList>? Licences { get; set; }

    [JsonProperty("add_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceList>? AddLicences { get; set; }

    [JsonProperty("licences_hierarchy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceList>? LicencesHierarchy { get; set; }

    [JsonProperty("sqlimport_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlImportAccountsId { get; set; }

    [JsonProperty("created_from_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedFromTemplate { get; set; }

    [JsonProperty("sqlimport_did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlImportDid { get; set; }

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabs>? ExtraTabs { get; set; }

    [JsonProperty("linked_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ServSite? LinkedService { get; set; }

    [JsonProperty("is_linked_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsLinkedService { get; set; }

    [JsonProperty("runbook_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RunbookButtonId { get; set; }

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

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyId { get; set; }

    [JsonProperty("latest_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LatestContractRef { get; set; }

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; }

    [JsonProperty("ncentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NCentralUrl { get; set; }

    [JsonProperty("ncentral_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NCentralRemoteUrl { get; set; }

    [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContractEndDate { get; set; }

    [JsonProperty("atera_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AteraIdWithUnderscore { get; set; }

    [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomateId { get; set; }

    [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomateUrl { get; set; }

    [JsonProperty("connectwise_control_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseControlUrl { get; set; }

    [JsonProperty("ninjarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NinjaRmmId { get; set; }

    [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaUrl { get; set; }

    [JsonProperty("ninja_remote_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaRemoteUrl { get; set; }

    [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncroUrl { get; set; }

    [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncroId { get; set; }

    [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItGlueUrl { get; set; }

    [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSequence { get; set; }

    [JsonProperty("service_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceIds { get; set; }

    [JsonProperty("bulkcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BulkCreated { get; set; }

    [JsonProperty("bulkbillingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BulkBillingPeriod { get; set; }

    [JsonProperty("asset_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetField { get; set; }

    [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoAlternateId { get; set; }

    [JsonProperty("syncro_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncroIdWithUnderscore { get; set; }

    [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowId { get; set; }

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalId { get; set; }

    [JsonProperty("auvik_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikDeviceId { get; set; }

    [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikUrl { get; set; }

    [JsonProperty("allowallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllStatus { get; set; }

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeStatus>? AllowedStatus { get; set; }

    [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoId { get; set; }

    [JsonProperty("addigy_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddigyId { get; set; }

    [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LiongardUrl { get; set; }

    [JsonProperty("liongard_environmnet_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiongardEnvironmentId { get; set; }

    [JsonProperty("liongard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LiongardIdWithUnderscore { get; set; }

    [JsonProperty("kaseya_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaIdWithUnderscore { get; set; }

    [JsonProperty("kaseyavsa_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaVsaUrl { get; set; }

    [JsonProperty("teamviewerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamViewerId { get; set; }

    [JsonProperty("serialization_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SerializationUser { get; set; }

    [JsonProperty("zabbix_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZabbixId { get; set; }

    [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZabbixUrl { get; set; }

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockbinName { get; set; }

    [JsonProperty("issue_consignment_line_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? IssueConsignmentLineId { get; set; }

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemName { get; set; }

    [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoUrl { get; set; }

    [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NCentralDetailsId { get; set; }

    [JsonProperty("nable_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NAbleId { get; set; }

    [JsonProperty("connectwisecontrolid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseControlId { get; set; }

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; }

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; }

    [JsonProperty("workspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceId { get; set; }

    [JsonProperty("workspace_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceUrl { get; set; }

    [JsonProperty("supplier_purchasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SupplierPurchaseDate { get; set; }

    [JsonProperty("logicmonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogicMonitorId { get; set; }

    [JsonProperty("barracudarmm_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BarracudaRmmId { get; set; }

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
    public string? ConnectWiseRmmId { get; set; }

    [JsonProperty("xensam_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XensamId { get; set; }

    [JsonProperty("asset_type_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypePriority { get; set; }

    [JsonProperty("snipeit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnipeItId { get; set; }

    [JsonProperty("prometheus_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrometheusId { get; set; }

    [JsonProperty("dynatrace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DynatraceId { get; set; }

    [JsonProperty("vmworkspace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VmWorkspaceId { get; set; }

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
    public string? ManageEngineId { get; set; }

    [JsonProperty("manageengine_customer_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ManageEngineCustomerId { get; set; }

    [JsonProperty("lastchangeofvaluedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastChangeOfValueDate { get; set; }

    [JsonProperty("commissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CommissionDate { get; set; }

    [JsonProperty("first_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FirstUserId { get; set; }

    [JsonProperty("changebackupexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChangeBackupExists { get; set; }

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBatch { get; set; }

    [JsonProperty("virima_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VirimaId { get; set; }

    [JsonProperty("service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServiceGuid { get; set; }

    [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceName { get; set; }

    [JsonProperty("lansweeperid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperId { get; set; }
}