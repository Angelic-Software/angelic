using System.CodeDom.Compiler;
using Angelic.Models.Configuration.BookingTypes;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Custom.CustomFields.Restrictions;
using Angelic.Models.Configuration.Custom.CustomTabs;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.Sites;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Assets.AssetTypes;

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
    public int? AssetGroupId { get; set; } 

    [JsonProperty("assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AssetGroupGuid { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetGroupName { get; set; } 

    [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KeyFieldId { get; set; } 

    [JsonProperty("keyfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyFieldName { get; set; } 

    [JsonProperty("keyfield2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KeyField2Id { get; set; } 

    [JsonProperty("keyfield2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField2Name { get; set; } 

    [JsonProperty("keyfield3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KeyField3Id { get; set; } 

    [JsonProperty("keyfield3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField3Name { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Manufacturer { get; set; } 

    [JsonProperty("supplier1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier1 { get; set; } 

    [JsonProperty("itemno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemNo { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("useteamviewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTeamViewer { get; set; } 

    [JsonProperty("accountscode1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsCode1 { get; set; } 

    [JsonProperty("accountscode2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsCode2 { get; set; } 

    [JsonProperty("weeklycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? WeeklyCost { get; set; } 

    [JsonProperty("monthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MonthlyCost { get; set; } 

    [JsonProperty("quarterlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuarterlyCost { get; set; } 

    [JsonProperty("sixmonthlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SixMonthlyCost { get; set; } 

    [JsonProperty("yearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? YearlyCost { get; set; } 

    [JsonProperty("twoyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TwoYearlyCost { get; set; } 

    [JsonProperty("threeyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ThreeYearlyCost { get; set; } 

    [JsonProperty("fouryearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? FourYearlyCost { get; set; } 

    [JsonProperty("fiveyearlycost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? FiveYearlyCost { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; } 

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
    public int? DefaultSequence { get; set; } 

    [JsonProperty("tagprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TagPrefix { get; set; } 

    [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColumnProfileId { get; set; } 

    [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ColumnProfileGuid { get; set; } 

    [JsonProperty("columnprofileoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColumnProfileOverrideName { get; set; } 

    [JsonProperty("enableresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableResourceBooking { get; set; } 

    [JsonProperty("resourcebooking_workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourceBookingWorkdaysId { get; set; } 

    [JsonProperty("resourcebooking_workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResourceBookingWorkdaysName { get; set; } 

    [JsonProperty("resourcebooking_allow_asset_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResourceBookingAllowAssetSelection { get; set; } 

    [JsonProperty("resourcebooking_asset_restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourceBookingAssetRestrictionType { get; set; } 

    [JsonProperty("resourcebooking_min_hours_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ResourceBookingMinHoursAdvance { get; set; } 

    [JsonProperty("resourcebooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ResourceBookingMaxDaysAdvance { get; set; } 

    [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingType>? BookingTypes { get; set; } 

    [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingTypeTimeslot>? Timeslots { get; set; } 

    [JsonProperty("timeslot_bookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeslotBookingType { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("linkedcontracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedContractType { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FiId { get; set; } 

    [JsonProperty("fiid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FiIdGuid { get; set; } 

    [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FiName { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("xtype_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeRole>? XTypeRoles { get; set; } 

    [JsonProperty("asset_details_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetDetailsTabDisplay { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? TabConfig { get; set; } 

    [JsonProperty("resourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResourceBookingType { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeStatus>? AllowedStatus { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllStatus { get; set; } 

    [JsonProperty("businessowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessOwnerVisibility { get; set; } 

    [JsonProperty("technicalowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalOwnerVisibility { get; set; } 

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
    public int? ResourceBookingSiteSelectionType { get; set; } 

    [JsonProperty("booking_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteList>? BookingSites { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("newticket_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewTicketPriority { get; set; } 

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
    public bool? IsBusinessApp { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCategoryId { get; set; } 

    [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceCategoryName { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? Services { get; set; } 

    [JsonProperty("field_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldRoleRestriction>? FieldRestrictions { get; set; } 

}