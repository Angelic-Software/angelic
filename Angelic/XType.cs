using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class XType
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
    public int? Assetgroup_id { get; set; } 

    [JsonProperty("assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Assetgroup_guid { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetgroup_name { get; set; } 

    [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Keyfield_id { get; set; } 

    [JsonProperty("keyfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield_name { get; set; } 

    [JsonProperty("keyfield2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Keyfield2_id { get; set; } 

    [JsonProperty("keyfield2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield2_name { get; set; } 

    [JsonProperty("keyfield3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Keyfield3_id { get; set; } 

    [JsonProperty("keyfield3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield3_name { get; set; } 

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
    public bool? Show_to_users { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TypeInfo>? Fields { get; set; } 

    [JsonProperty("field_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Field>? Field_list { get; set; } 

    [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_code { get; set; } 

    [JsonProperty("defaultsequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultsequence { get; set; } 

    [JsonProperty("tagprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tagprefix { get; set; } 

    [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Column_profile_id { get; set; } 

    [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Column_profile_guid { get; set; } 

    [JsonProperty("columnprofileoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Columnprofileoverride_name { get; set; } 

    [JsonProperty("enableresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableresourcebooking { get; set; } 

    [JsonProperty("resourcebooking_workdays_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resourcebooking_workdays_id { get; set; } 

    [JsonProperty("resourcebooking_workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resourcebooking_workdays_name { get; set; } 

    [JsonProperty("resourcebooking_allow_asset_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resourcebooking_allow_asset_selection { get; set; } 

    [JsonProperty("resourcebooking_asset_restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resourcebooking_asset_restriction_type { get; set; } 

    [JsonProperty("resourcebooking_min_hours_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Resourcebooking_min_hours_advance { get; set; } 

    [JsonProperty("resourcebooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Resourcebooking_max_days_advance { get; set; } 

    [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingType>? Bookingtypes { get; set; } 

    [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<BookingTypeTimeslot>? Timeslots { get; set; } 

    [JsonProperty("timeslot_bookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timeslot_bookingtype { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("linkedcontracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linkedcontracttype { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fiid { get; set; } 

    [JsonProperty("fiid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Fiid_guid { get; set; } 

    [JsonProperty("finame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Finame { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_icon { get; set; } 

    [JsonProperty("xtype_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeRole>? Xtype_roles { get; set; } 

    [JsonProperty("asset_details_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_details_tab_display { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? Tab_config { get; set; } 

    [JsonProperty("resourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resourcebookingtype { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeStatus>? Allowed_status { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_status { get; set; } 

    [JsonProperty("businessowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Businessowner_visibility { get; set; } 

    [JsonProperty("technicalowner_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technicalowner_visibility { get; set; } 

    [JsonProperty("sla_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sla_visibility { get; set; } 

    [JsonProperty("priority_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority_visibility { get; set; } 

    [JsonProperty("status_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status_visibility { get; set; } 

    [JsonProperty("services_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Services_visibility { get; set; } 

    [JsonProperty("dependencies_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dependencies_visibility { get; set; } 

    [JsonProperty("notes_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notes_visibility { get; set; } 

    [JsonProperty("visibility_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Visibility_level { get; set; } 

    [JsonProperty("resourcebooking_site_selection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resourcebooking_site_selection_type { get; set; } 

    [JsonProperty("booking_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Site_List>? Booking_sites { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("newticket_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newticket_priority { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("licence_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licence_visibility { get; set; } 

    [JsonProperty("allow_all_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_all_view { get; set; } 

    [JsonProperty("criticality_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Criticality_visibility { get; set; } 

    [JsonProperty("is_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_service { get; set; } 

    [JsonProperty("is_businessapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_businessapp { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_category_id { get; set; } 

    [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_category_name { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSite_List>? Services { get; set; } 

    [JsonProperty("field_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldRoleRestriction>? Field_restrictions { get; set; } 

}