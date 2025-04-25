using System.CodeDom.Compiler;
using Angelic.Appointments;
using Angelic.Configuration.TeamsAndAgents.Agents;
using Newtonsoft.Json;

namespace Angelic.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Team
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
    public int? TicketCount { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DepartmentName { get; set; } 

    [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgTeamName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideColumnId { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamphotopath { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAgentsInTreeIfNoTickets { get; set; } 

    [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimesheetApprover { get; set; } 

    [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimesheetApproverName { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConcurrentLicLimit { get; set; } 

    [JsonProperty("workinghoursbeforealert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Workinghoursbeforealert { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("addtoallagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addtoallagents { get; set; } 

    [JsonProperty("allowlivechat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowlivechat { get; set; } 

    [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RtId { get; set; } 

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxOverride { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentSection>? Agents { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrganisationId { get; set; } 

    [JsonProperty("cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CannedText>? CannedText { get; set; } 

    [JsonProperty("templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestList>? Templates { get; set; } 

    [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallCategory1 { get; set; } 

    [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory1 { get; set; } 

    [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallCategory2 { get; set; } 

    [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory2 { get; set; } 

    [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallCategory3 { get; set; } 

    [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory3 { get; set; } 

    [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallCategory4 { get; set; } 

    [JsonProperty("includeinloadbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includeinloadbalance { get; set; } 

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory4 { get; set; } 

    [JsonProperty("override_column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideColumnName { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("_canupdate2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate2 { get; set; } 

    [JsonProperty("main_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainEmailAddress { get; set; } 

    [JsonProperty("phone_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; } 

    [JsonProperty("alternative_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlternativeName { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("dontsendsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendsurvey { get; set; } 

    [JsonProperty("team_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamNote { get; set; } 

    [JsonProperty("booking_workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BookingWorkdayId { get; set; } 

    [JsonProperty("booking_workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BookingWorkdayName { get; set; } 

    [JsonProperty("recurring_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AppointmentList>? RecurringShifts { get; set; } 

    [JsonProperty("third_party_migration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyMigrationId { get; set; } 

    [JsonProperty("enable_teams_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTeamsShifts { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DepartmentGuid { get; set; } 

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Homescreendashboardid { get; set; } 

    [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Homescreendashboardname { get; set; } 

}