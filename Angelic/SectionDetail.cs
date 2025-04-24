using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SectionDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("forrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forrequests { get; set; } 

    [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Foropps { get; set; } 

    [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forprojects { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_count { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Department_id { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Department_name { get; set; } 

    [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Org_team_name { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_column_id { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamphotopath { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_modified { get; set; } 

    [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_agents_in_tree_if_no_tickets { get; set; } 

    [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timesheet_approver { get; set; } 

    [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timesheet_approver_name { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Concurrent_lic_limit { get; set; } 

    [JsonProperty("workinghoursbeforealert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Workinghoursbeforealert { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailaddress { get; set; } 

    [JsonProperty("addtoallagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addtoallagents { get; set; } 

    [JsonProperty("allowlivechat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowlivechat { get; set; } 

    [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rtid { get; set; } 

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailbox_override { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentSection>? Agents { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Organisation_id { get; set; } 

    [JsonProperty("cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CannedText>? Cannedtext { get; set; } 

    [JsonProperty("templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequest_List>? Templates { get; set; } 

    [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category1 { get; set; } 

    [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category1 { get; set; } 

    [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category2 { get; set; } 

    [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category2 { get; set; } 

    [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category3 { get; set; } 

    [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category3 { get; set; } 

    [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category4 { get; set; } 

    [JsonProperty("includeinloadbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includeinloadbalance { get; set; } 

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

    [JsonProperty("override_column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Override_column_name { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _canupdate { get; set; } 

    [JsonProperty("_canupdate2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _canupdate2 { get; set; } 

    [JsonProperty("main_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Main_email_address { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone_number { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; } 

    [JsonProperty("alternative_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alternative_name { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("dontsendsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendsurvey { get; set; } 

    [JsonProperty("team_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_note { get; set; } 

    [JsonProperty("booking_workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Booking_workday_id { get; set; } 

    [JsonProperty("booking_workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Booking_workday_name { get; set; } 

    [JsonProperty("recurring_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Appointment_List>? Recurring_shifts { get; set; } 

    [JsonProperty("third_party_migration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_migration_id { get; set; } 

    [JsonProperty("enable_teams_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_teams_shifts { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Department_guid { get; set; } 

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Homescreendashboardid { get; set; } 

    [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Homescreendashboardname { get; set; } 

}