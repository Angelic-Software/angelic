using System.CodeDom.Compiler;
using Angelic.Appointments;
using Angelic.Areas;
using Angelic.Configuration.Custom.CustomTabs;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Tickets.TicketTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("default_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultSlaGuid { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; } 

    [JsonProperty("jira_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraIssueType { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketCount { get; set; } 

    [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cancreate { get; set; } 

    [JsonProperty("agentscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agentscanselect { get; set; } 

    [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequesttype { get; set; } 

    [JsonProperty("allowattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowattachments { get; set; } 

    [JsonProperty("copyattachmentstochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstochild { get; set; } 

    [JsonProperty("copyattachmentstorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstorelated { get; set; } 

    [JsonProperty("is_sprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSprint { get; set; } 

    [JsonProperty("fieldidlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Fieldidlist { get; set; } 

    [JsonProperty("enduserscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserscanselect { get; set; } 

    [JsonProperty("anonymouscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Anonymouscanselect { get; set; } 

    [JsonProperty("hasmandatorytechfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasmandatorytechfields { get; set; } 

    [JsonProperty("hasmandatoryuserfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasmandatoryuserfields { get; set; } 

    [JsonProperty("statusafteruserupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafteruserupdate { get; set; } 

    [JsonProperty("statusafteruserupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusafteruserupdateGuid { get; set; } 

    [JsonProperty("statusaftersupplierupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusaftersupplierupdate { get; set; } 

    [JsonProperty("statusaftersupplierupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusaftersupplierupdateGuid { get; set; } 

    [JsonProperty("closedrequestswithupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Closedrequestswithupdates { get; set; } 

    [JsonProperty("pendingrequestswithupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pendingrequestswithupdates { get; set; } 

    [JsonProperty("portalcanreopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Portalcanreopen { get; set; } 

    [JsonProperty("closedrequestswithupdatesincpending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Closedrequestswithupdatesincpending { get; set; } 

    [JsonProperty("includeinmobiledbsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includeinmobiledbsync { get; set; } 

    [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowId { get; set; } 

    [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkflowGuid { get; set; } 

    [JsonProperty("always_bcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlwaysBcc { get; set; } 

    [JsonProperty("reopenedstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reopenedstatus { get; set; } 

    [JsonProperty("reopenedstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ReopenedstatusGuid { get; set; } 

    [JsonProperty("closedrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Closedrequestsemailid { get; set; } 

    [JsonProperty("closedrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Closedrequestsemailguid { get; set; } 

    [JsonProperty("pendingrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pendingrequestsemailid { get; set; } 

    [JsonProperty("pendingrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Pendingrequestsemailguid { get; set; } 

    [JsonProperty("closedrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClosedrequestsemailName { get; set; } 

    [JsonProperty("pendingrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PendingrequestsemailName { get; set; } 

    [JsonProperty("closeduserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Closeduserupdatehours { get; set; } 

    [JsonProperty("pendinguserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Pendinguserupdatehours { get; set; } 

    [JsonProperty("webannouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webannouncement { get; set; } 

    [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRate { get; set; } 

    [JsonProperty("initial_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InitialStatus { get; set; } 

    [JsonProperty("initial_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? InitialStatusGuid { get; set; } 

    [JsonProperty("default_team_to_agents_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultTeamToAgentsDefault { get; set; } 

    [JsonProperty("default_sla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSla { get; set; } 

    [JsonProperty("default_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCategory1 { get; set; } 

    [JsonProperty("default_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCategory2 { get; set; } 

    [JsonProperty("default_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCategory3 { get; set; } 

    [JsonProperty("default_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCategory4 { get; set; } 

    [JsonProperty("default_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSummary { get; set; } 

    [JsonProperty("default_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultDetails { get; set; } 

    [JsonProperty("default_details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultDetailsHtml { get; set; } 

    [JsonProperty("default_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultExcludefromsla { get; set; } 

    [JsonProperty("default_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowForusers { get; set; } 

    [JsonProperty("default_sendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendack { get; set; } 

    [JsonProperty("default_sendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSendemail { get; set; } 

    [JsonProperty("default_matchedkbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMatchedkbid { get; set; } 

    [JsonProperty("default_kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultKbName { get; set; } 

    [JsonProperty("default_kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultKbAccessibleForEnduser { get; set; } 

    [JsonProperty("allowall_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallActions { get; set; } 

    [JsonProperty("allowall_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallTeam { get; set; } 

    [JsonProperty("allowed_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionRequestType>? AllowedTeams { get; set; } 

    [JsonProperty("allowed_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Restriction>? AllowedActions { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallStatus { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeStatus>? AllowedStatus { get; set; } 

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

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory4 { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalProcessId { get; set; } 

    [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ApprovalProcessGuid { get; set; } 

    [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalProcessName { get; set; } 

    [JsonProperty("from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FromMailboxId { get; set; } 

    [JsonProperty("hide_respond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideRespond { get; set; } 

    [JsonProperty("close_kb_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CloseKbAction { get; set; } 

    [JsonProperty("default_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultProductId { get; set; } 

    [JsonProperty("default_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultProductName { get; set; } 

    [JsonProperty("default_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultBudgetTypeId { get; set; } 

    [JsonProperty("default_budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultBudgetTypeName { get; set; } 

    [JsonProperty("email_start_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailStartTagOverride { get; set; } 

    [JsonProperty("email_end_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailEndTagOverride { get; set; } 

    [JsonProperty("acknowledgementtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Acknowledgementtemplate { get; set; } 

    [JsonProperty("acknowledgementtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AcknowledgementtemplateGuid { get; set; } 

    [JsonProperty("acknowledgementtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AcknowledgementtemplateName { get; set; } 

    [JsonProperty("acknowledgementtemplateooh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Acknowledgementtemplateooh { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AcknowledgementtemplateoohGuid { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AcknowledgementtemplateoohName { get; set; } 

    [JsonProperty("dontsendslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendslareminders { get; set; } 

    [JsonProperty("dontusependingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontusependingclosure { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupId { get; set; } 

    [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DatabaseLookupName { get; set; } 

    [JsonProperty("applydefaultsontypechangebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applydefaultsontypechangebool { get; set; } 

    [JsonProperty("apply_workflow_on_type_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyWorkflowOnTypeChange { get; set; } 

    [JsonProperty("allowtickettypetobechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowtickettypetobechild { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Fields { get; set; } 

    [JsonProperty("default_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultEstimate { get; set; } 

    [JsonProperty("mustclosechildbeforeclosurebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mustclosechildbeforeclosurebool { get; set; } 

    [JsonProperty("default_sendremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendremoteinvite { get; set; } 

    [JsonProperty("logtimeindays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Logtimeindays { get; set; } 

    [JsonProperty("logtimeindaysincrement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Logtimeindaysincrement { get; set; } 

    [JsonProperty("usetimeslotsforstartandtargettimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usetimeslotsforstartandtargettimes { get; set; } 

    [JsonProperty("childticketcolumnsoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Childticketcolumnsoverride { get; set; } 

    [JsonProperty("childticketcolumnsoverride_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ChildticketcolumnsoverrideGuid { get; set; } 

    [JsonProperty("childticketcolumnsoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChildticketcolumnsoverrideName { get; set; } 

    [JsonProperty("showunborntab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showunborntab { get; set; } 

    [JsonProperty("allowcustomiseunborn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowcustomiseunborn { get; set; } 

    [JsonProperty("inform_account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InformAccountManager { get; set; } 

    [JsonProperty("statusaftertechupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusaftertechupdate { get; set; } 

    [JsonProperty("statusaftertechupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusaftertechupdateGuid { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTemplateName { get; set; } 

    [JsonProperty("quote_pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotePdfTemplateId { get; set; } 

    [JsonProperty("quote_pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuotePdfTemplateName { get; set; } 

    [JsonProperty("maximumRestrictedPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaximumRestrictedPriority { get; set; } 

    [JsonProperty("auto_respond_logged_manually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoRespondLoggedManually { get; set; } 

    [JsonProperty("autoCloseHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoCloseHours { get; set; } 

    [JsonProperty("allowed_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaRequestType>? AllowedClients { get; set; } 

    [JsonProperty("closedrequestreplylimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Closedrequestreplylimit { get; set; } 

    [JsonProperty("pendingrequestreplylimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pendingrequestreplylimit { get; set; } 

    [JsonProperty("alluserscanviewit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alluserscanviewit { get; set; } 

    [JsonProperty("alluserscanview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alluserscanview { get; set; } 

    [JsonProperty("thisentitycanbevotedfor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Thisentitycanbevotedfor { get; set; } 

    [JsonProperty("show_vote_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowVoteComment { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridewiththefollowingtemplatewhenloggingmanually { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? OverridewiththefollowingtemplatewhenloggingmanuallyGuid { get; set; } 

    [JsonProperty("editservstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Editservstatus { get; set; } 

    [JsonProperty("appointmentdefaultbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Appointmentdefaultbody { get; set; } 

    [JsonProperty("appointmentdefaultbody_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AppointmentdefaultbodyGuid { get; set; } 

    [JsonProperty("appointmentdefaultbody_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppointmentdefaultbodyName { get; set; } 

    [JsonProperty("setrelatedservicesfromassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Setrelatedservicesfromassets { get; set; } 

    [JsonProperty("default_sendtosoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendtosoc { get; set; } 

    [JsonProperty("default_soctargettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSoctargettype { get; set; } 

    [JsonProperty("default_soctargetid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSoctargetid { get; set; } 

    [JsonProperty("default_soctargetname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSoctargetname { get; set; } 

    [JsonProperty("soc_default_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? SocDefaultTarget { get; set; } 

    [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forwardinboundupdates { get; set; } 

    [JsonProperty("default_appointment_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentSummary { get; set; } 

    [JsonProperty("default_appointment_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentDetails { get; set; } 

    [JsonProperty("displayonquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Displayonquicktime { get; set; } 

    [JsonProperty("statusafterapproverupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafterapproverupdate { get; set; } 

    [JsonProperty("statusafterapproverupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusafterapproverupdateGuid { get; set; } 

    [JsonProperty("display_audit_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisplayAuditTab { get; set; } 

    [JsonProperty("overwrite_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverwriteShowForusers { get; set; } 

    [JsonProperty("default_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? DefaultServices { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("showdownvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showdownvote { get; set; } 

    [JsonProperty("addactionstolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addactionstolinked { get; set; } 

    [JsonProperty("addnoteonlytolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addnoteonlytolinked { get; set; } 

    [JsonProperty("dontconfirm_updateparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontconfirmUpdateparent { get; set; } 

    [JsonProperty("default_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultImpact { get; set; } 

    [JsonProperty("default_risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultRisklevel { get; set; } 

    [JsonProperty("default_justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultJustification { get; set; } 

    [JsonProperty("default_impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultImpactdescription { get; set; } 

    [JsonProperty("default_riskleveldescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultRiskleveldescription { get; set; } 

    [JsonProperty("default_testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTestplan { get; set; } 

    [JsonProperty("default_backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultBackoutplan { get; set; } 

    [JsonProperty("default_communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCommunicationplan { get; set; } 

    [JsonProperty("default_changeinformation_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultChangeinformationHtml { get; set; } 

    [JsonProperty("isbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isbillable { get; set; } 

    [JsonProperty("items_are_billable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemsAreBillable { get; set; } 

    [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultresourcetype { get; set; } 

    [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultresourcetypeName { get; set; } 

    [JsonProperty("defaultlisttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultlisttype { get; set; } 

    [JsonProperty("defaulttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaulttab { get; set; } 

    [JsonProperty("defaultsync_to_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultsyncToSentinel { get; set; } 

    [JsonProperty("adduserupdatestochildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Adduserupdatestochildren { get; set; } 

    [JsonProperty("default_targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTargetDate { get; set; } 

    [JsonProperty("allowed_resourcebooking_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionRequestType>? AllowedResourcebookingTeams { get; set; } 

    [JsonProperty("defaultresourcetype_name_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultresourcetypeNameAgent { get; set; } 

    [JsonProperty("agentresourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agentresourcebookingtype { get; set; } 

    [JsonProperty("userbookfromportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Userbookfromportal { get; set; } 

    [JsonProperty("defaultresourcetype_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultresourcetypeAgent { get; set; } 

    [JsonProperty("defaultagentresourcebookingduration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultagentresourcebookingdurationId { get; set; } 

    [JsonProperty("rtdefaultagentresourcebookingduration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RtdefaultagentresourcebookingdurationName { get; set; } 

    [JsonProperty("showotheropenticketsinnewtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOtheropenticketsinnewtab { get; set; } 

    [JsonProperty("showopenusertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenusertickets { get; set; } 

    [JsonProperty("showopensitetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpensitetickets { get; set; } 

    [JsonProperty("showopenclienttickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenclienttickets { get; set; } 

    [JsonProperty("showopendevicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpendevicetickets { get; set; } 

    [JsonProperty("showuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showuserfeed { get; set; } 

    [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Updateservicestatus { get; set; } 

    [JsonProperty("default_servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultServicestatusnote { get; set; } 

    [JsonProperty("attendeesenduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attendeesenduser { get; set; } 

    [JsonProperty("showautomationstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAutomationstab { get; set; } 

    [JsonProperty("showbillingtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showbillingtab { get; set; } 

    [JsonProperty("showsuggestionstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showsuggestionstab { get; set; } 

    [JsonProperty("showoppcontacttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOppcontacttab { get; set; } 

    [JsonProperty("showactivestatuskanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowActivestatuskanban { get; set; } 

    [JsonProperty("ganttgrandchildview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ganttgrandchildview { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("submitlabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Submitlabeloverride { get; set; } 

    [JsonProperty("allowall_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallAppointmentTypes { get; set; } 

    [JsonProperty("include_appointments_scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeAppointmentsScheduledHours { get; set; } 

    [JsonProperty("ticketlinktype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticketlinktype { get; set; } 

    [JsonProperty("allowed_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AppointmentTypeTicketType>? AllowedAppointmentTypes { get; set; } 

    [JsonProperty("allowall_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallIframeCustomtabs { get; set; } 

    [JsonProperty("allowed_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IframeTabRequestType>? AllowedIframeCustomtabs { get; set; } 

    [JsonProperty("default_sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSyncToSalesforce { get; set; } 

    [JsonProperty("salesforce_default_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesforceDefaultStage { get; set; } 

    [JsonProperty("show_add_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAddNote { get; set; } 

    [JsonProperty("auto_delete_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoDeleteData { get; set; } 

    [JsonProperty("auto_delete_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoDeleteDays { get; set; } 

    [JsonProperty("show_child_tasks_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowChildTasksType { get; set; } 

    [JsonProperty("pin_important_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PinImportantActions { get; set; } 

    [JsonProperty("showdecendantwarningoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showdecendantwarningoptions { get; set; } 

    [JsonProperty("statusafterresourcebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafterresourcebook { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentstatusafterallchildclosed { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentstatusafterallchildclosedName { get; set; } 

    [JsonProperty("allowlogonbehalfof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Allowlogonbehalfof { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("auto_create_appt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoCreateAppt { get; set; } 

    [JsonProperty("hide_anon_contact_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAnonContactInfo { get; set; } 

    [JsonProperty("ticket_created_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketCreatedOverride { get; set; } 

    [JsonProperty("newrequestmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Newrequestmessage { get; set; } 

    [JsonProperty("allow_anonymous_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonymousLogging { get; set; } 

    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublishedId { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

    [JsonProperty("add_ack_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddAckAttachments { get; set; } 

    [JsonProperty("defaultpagerdutyservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultpagerdutyservice { get; set; } 

    [JsonProperty("defaultpagerdutyservice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultpagerdutyserviceName { get; set; } 

    [JsonProperty("defaultsidebarcollapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Defaultsidebarcollapsed { get; set; } 

    [JsonProperty("logonbehalflabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logonbehalflabeloverride { get; set; } 

    [JsonProperty("tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabDisplay { get; set; } 

    [JsonProperty("sprint_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SprintTicketTypeId { get; set; } 

    [JsonProperty("sprint_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SprintTicketTypeName { get; set; } 

    [JsonProperty("usemilestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usemilestones { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? TabConfig { get; set; } 

    [JsonProperty("enableusermentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableusermentions { get; set; } 

    [JsonProperty("sladontclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sladontclose { get; set; } 

    [JsonProperty("pendingdontclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pendingdontclose { get; set; } 

    [JsonProperty("minattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Minattachments { get; set; } 

    [JsonProperty("enableforecasting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableforecasting { get; set; } 

    [JsonProperty("make_cc_followers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MakeCcFollowers { get; set; } 

    [JsonProperty("default_kanban_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultKanbanView { get; set; } 

    [JsonProperty("showgeneralsurveyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showgeneralsurveyfields { get; set; } 

    [JsonProperty("default_send_to_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSendToPagerduty { get; set; } 

    [JsonProperty("completion_status_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CompletionStatusType { get; set; } 

    [JsonProperty("show_project_task_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowProjectTaskDates { get; set; } 

    [JsonProperty("auto_forward_email_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoForwardEmailUpdates { get; set; } 

    [JsonProperty("default_is_sensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultIsSensitive { get; set; } 

    [JsonProperty("process_open_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProcessOpenTickets { get; set; } 

    [JsonProperty("todolistportalvisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Todolistportalvisibility { get; set; } 

    [JsonProperty("legacy_print_request_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LegacyPrintRequestDetails { get; set; } 

    [JsonProperty("legacy_print_service_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LegacyPrintServiceForm { get; set; } 

    [JsonProperty("default_appt_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultApptType { get; set; } 

    [JsonProperty("show_child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowChildAssets { get; set; } 

    [JsonProperty("hide_anon_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAnonPhonenumber { get; set; } 

    [JsonProperty("showconfirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowConfirmemail { get; set; } 

    [JsonProperty("ticket_status_after_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketStatusAfterAppointment { get; set; } 

    [JsonProperty("max_open_per_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxOpenPerUser { get; set; } 

    [JsonProperty("max_total_per_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxTotalPerUser { get; set; } 

    [JsonProperty("max_open_per_user_reached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MaxOpenPerUserReached { get; set; } 

    [JsonProperty("max_total_per_user_reached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MaxTotalPerUserReached { get; set; } 

    [JsonProperty("milestone_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MilestoneBilling { get; set; } 

    [JsonProperty("showopensuppliertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpensuppliertickets { get; set; } 

    [JsonProperty("allowall_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallSuggestionFaqlists { get; set; } 

    [JsonProperty("allowed_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaqRequestType>? AllowedSuggestionFaqlists { get; set; } 

    [JsonProperty("startdate_validation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartDateValidation { get; set; } 

    [JsonProperty("startdate_validation_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartDateValidationDays { get; set; } 

    [JsonProperty("targetdate_validation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetDateValidation { get; set; } 

    [JsonProperty("targetdate_validation_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetDateValidationDays { get; set; } 

    [JsonProperty("auto_contributor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoContributor { get; set; } 

    [JsonProperty("allow_teams_chat_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowTeamsChatCreation { get; set; } 

    [JsonProperty("teams_chat_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamsChatDefaultName { get; set; } 

    [JsonProperty("show_teams_chats_as_tabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTeamsChatsAsTabs { get; set; } 

    [JsonProperty("default_servicenow_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultServicenowType { get; set; } 

    [JsonProperty("enable_task_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTaskDependencies { get; set; } 

    [JsonProperty("exclude_from_sales_mailbox_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeFromSalesMailboxMatch { get; set; } 

    [JsonProperty("lapsafe_status_after_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LapsafeStatusAfterWebhook { get; set; } 

    [JsonProperty("lapsafe_status_after_webhook_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? LapsafeStatusAfterWebhookGuid { get; set; } 

    [JsonProperty("show_status_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowStatusOnPortal { get; set; } 

    [JsonProperty("allow_slack_channel_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowSlackChannelCreation { get; set; } 

    [JsonProperty("slack_channel_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlackChannelDefaultName { get; set; } 

    [JsonProperty("show_slack_channels_as_tabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSlackChannelsAsTabs { get; set; } 

    [JsonProperty("slack_channel_access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlackChannelAccessType { get; set; } 

    [JsonProperty("slack_channel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlackChannelWorkspace { get; set; } 

    [JsonProperty("slack_channel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlackChannelWorkspaceName { get; set; } 

    [JsonProperty("hide_anon_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HideAnonEmail { get; set; } 

    [JsonProperty("continue_autorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ContinueAutorelease { get; set; } 

    [JsonProperty("do_ai_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoAiSurvey { get; set; } 

    [JsonProperty("enduserscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserscanlog { get; set; } 

    [JsonProperty("anonymouscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Anonymouscanlog { get; set; } 

    [JsonProperty("generate_ai_embeddings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GenerateAiEmbeddings { get; set; } 

    [JsonProperty("load_balance_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadBalanceInterval { get; set; } 

    [JsonProperty("load_balance_max_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadBalanceMaxTickets { get; set; } 

    [JsonProperty("load_balance_on_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LoadBalanceOnSchedule { get; set; } 

    [JsonProperty("load_balance_schedule_frequency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadBalanceScheduleFrequency { get; set; } 

    [JsonProperty("load_balance_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AssignSchedule? LoadBalanceSchedule { get; set; } 

    [JsonProperty("allowall_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowallChildTicketTypes { get; set; } 

    [JsonProperty("allowed_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChildRequestType>? AllowedChildTicketTypes { get; set; } 

    [JsonProperty("portal_summary_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalSummaryHintIsPlaceholder { get; set; } 

    [JsonProperty("portal_details_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalDetailsHintIsPlaceholder { get; set; } 

    [JsonProperty("agent_summary_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentSummaryHintIsPlaceholder { get; set; } 

    [JsonProperty("agent_details_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentDetailsHintIsPlaceholder { get; set; } 

    [JsonProperty("portal_screen_after_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalScreenAfterLogging { get; set; } 

    [JsonProperty("show_related_of_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowRelatedOfRelated { get; set; } 

    [JsonProperty("show_all_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowAllRelated { get; set; } 

    [JsonProperty("hideuserdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideuserdetails { get; set; } 

    [JsonProperty("allowanonattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowanonattachments { get; set; } 

    [JsonProperty("inherit_parent_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InheritParentCategory1 { get; set; } 

    [JsonProperty("inherit_parent_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InheritParentCategory2 { get; set; } 

    [JsonProperty("inherit_parent_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InheritParentCategory3 { get; set; } 

    [JsonProperty("inherit_parent_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InheritParentCategory4 { get; set; } 

    [JsonProperty("default_is_downtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultIsDowntime { get; set; } 

    [JsonProperty("is_chat_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsChatTicket { get; set; } 

    [JsonProperty("add_related_assets_to_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddRelatedAssetsToParent { get; set; } 

    [JsonProperty("third_party_migration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyMigrationId { get; set; } 

    [JsonProperty("wait_time_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WaitTimeType { get; set; } 

    [JsonProperty("default_wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultWaitTime { get; set; } 

    [JsonProperty("wait_time_calc_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WaitTimeCalcHours { get; set; } 

    [JsonProperty("project_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProjectType { get; set; } 

    [JsonProperty("kanbanstatuschoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Kanbanstatuschoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KanbanstatuschoiceList { get; set; } 

    [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailStartTag { get; set; } 

    [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailEndTag { get; set; } 

    [JsonProperty("default_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAgent { get; set; } 

    [JsonProperty("default_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAgentName { get; set; } 

    [JsonProperty("default_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTeam { get; set; } 

    [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkflowName { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanuallyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Overridewiththefollowingtemplatewhenloggingmanuallyname { get; set; } 

    [JsonProperty("default_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPriority { get; set; } 

    [JsonProperty("visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Visible { get; set; } 

}