using System.CodeDom.Compiler;
using Angelic.Configuration.CustomField;
using Newtonsoft.Json;

namespace Angelic.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AssetType
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetgroupId { get; set; } 

    [JsonProperty("assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AssetgroupGuid { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetgroupName { get; set; } 

    [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KeyfieldId { get; set; } 

    [JsonProperty("keyfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyfieldName { get; set; } 

    [JsonProperty("keyfield2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Keyfield2Id { get; set; } 

    [JsonProperty("keyfield2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield2Name { get; set; } 

    [JsonProperty("keyfield3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Keyfield3Id { get; set; } 

    [JsonProperty("keyfield3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield3Name { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Manufacturer { get; set; } 

    [JsonProperty("supplier1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier1 { get; set; } 

    [JsonProperty("itemno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itemno { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("useteamviewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useteamviewer { get; set; } 

    [JsonProperty("accountscode1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountscode1 { get; set; } 

    [JsonProperty("accountscode2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountscode2 { get; set; } 

    [JsonProperty("weeklycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Weeklycost { get; set; } 

    [JsonProperty("monthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Monthlycost { get; set; } 

    [JsonProperty("quarterlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quarterlycost { get; set; } 

    [JsonProperty("sixmonthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Sixmonthlycost { get; set; } 

    [JsonProperty("yearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Yearlycost { get; set; } 

    [JsonProperty("twoyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Twoyearlycost { get; set; } 

    [JsonProperty("threeyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Threeyearlycost { get; set; } 

    [JsonProperty("fouryearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Fouryearlycost { get; set; } 

    [JsonProperty("fiveyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Fiveyearlycost { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kaseyaid { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("show_to_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowToUsers { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TypeInfo>? Fields { get; set; } 

    [JsonProperty("field_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Field>? FieldList { get; set; } 

    [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemCode { get; set; } 

    [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultsequence { get; set; } 

    [JsonProperty("tagprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tagprefix { get; set; } 

    [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColumnProfileId { get; set; } 

    [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ColumnProfileGuid { get; set; } 

    [JsonProperty("columnprofileoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColumnprofileoverrideName { get; set; } 

    [JsonProperty("enableresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableresourcebooking { get; set; } 

    [JsonProperty("resourcebooking_workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourcebookingWorkdaysId { get; set; } 

    [JsonProperty("resourcebooking_workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResourcebookingWorkdaysName { get; set; } 

    [JsonProperty("resourcebooking_allow_asset_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResourcebookingAllowAssetSelection { get; set; } 

    [JsonProperty("resourcebooking_asset_restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourcebookingAssetRestrictionType { get; set; } 

    [JsonProperty("resourcebooking_min_hours_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ResourcebookingMinHoursAdvance { get; set; } 

    [JsonProperty("resourcebooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ResourcebookingMaxDaysAdvance { get; set; } 

    [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingType>? Bookingtypes { get; set; } 

    [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingTypeTimeslot>? Timeslots { get; set; } 

    [JsonProperty("timeslot_bookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeslotBookingtype { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("linkedcontracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linkedcontracttype { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fiid { get; set; } 

    [JsonProperty("fiid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FiidGuid { get; set; } 

    [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Finame { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("xtype_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeRole>? XtypeRoles { get; set; } 

    [JsonProperty("asset_details_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetDetailsTabDisplay { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? TabConfig { get; set; } 

    [JsonProperty("resourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resourcebookingtype { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeStatus>? AllowedStatus { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallStatus { get; set; } 

    [JsonProperty("businessowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessownerVisibility { get; set; } 

    [JsonProperty("technicalowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalownerVisibility { get; set; } 

    [JsonProperty("sla_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaVisibility { get; set; } 

    [JsonProperty("priority_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityVisibility { get; set; } 

    [JsonProperty("status_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusVisibility { get; set; } 

    [JsonProperty("services_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicesVisibility { get; set; } 

    [JsonProperty("dependencies_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DependenciesVisibility { get; set; } 

    [JsonProperty("notes_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotesVisibility { get; set; } 

    [JsonProperty("visibility_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? VisibilityLevel { get; set; } 

    [JsonProperty("resourcebooking_site_selection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourcebookingSiteSelectionType { get; set; } 

    [JsonProperty("booking_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteList>? BookingSites { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("newticket_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewticketPriority { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("licence_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceVisibility { get; set; } 

    [JsonProperty("allow_all_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllView { get; set; } 

    [JsonProperty("criticality_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CriticalityVisibility { get; set; } 

    [JsonProperty("is_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsService { get; set; } 

    [JsonProperty("is_businessapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBusinessapp { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCategoryId { get; set; } 

    [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceCategoryName { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? Services { get; set; } 

    [JsonProperty("field_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldRoleRestriction>? FieldRestrictions { get; set; } 

}