using System.CodeDom.Compiler;
using Angelic.Models.Appointments;
using Angelic.Models.Clients;
using Angelic.Models.Configuration.Custom.CustomTabs;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.Configuration.Tickets.TicketTypes.Rules;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketType
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
    public bool? CanCreate { get; set; } 

    [JsonProperty("agentscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentScanSelect { get; set; } 

    [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequestType { get; set; } 

    [JsonProperty("allowattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAttachments { get; set; } 

    [JsonProperty("copyattachmentstochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyAttachmentsToChild { get; set; } 

    [JsonProperty("copyattachmentstorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyAttachmentsToRelated { get; set; } 

    [JsonProperty("is_sprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSprint { get; set; } 

    [JsonProperty("fieldidlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? FieldIdList { get; set; } 

    [JsonProperty("enduserscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndUsersCanSelect { get; set; } 

    [JsonProperty("anonymouscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AnonymousCanSelect { get; set; } 

    [JsonProperty("hasmandatorytechfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasMandatoryTechFields { get; set; } 

    [JsonProperty("hasmandatoryuserfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasMandatoryUserFields { get; set; } 

    [JsonProperty("statusafteruserupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterUserUpdate { get; set; } 

    [JsonProperty("statusafteruserupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusAfterUserUpdateGuid { get; set; } 

    [JsonProperty("statusaftersupplierupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterSupplierUpdate { get; set; } 

    [JsonProperty("statusaftersupplierupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusAfterSupplierUpdateGuid { get; set; } 

    [JsonProperty("closedrequestswithupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosedRequestsWithUpdates { get; set; } 

    [JsonProperty("pendingrequestswithupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PendingRequestsWithUpdates { get; set; } 

    [JsonProperty("portalcanreopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalCanReopen { get; set; } 

    [JsonProperty("closedrequestswithupdatesincpending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Closedrequestswithupdatesincpending { get; set; } 

    [JsonProperty("includeinmobiledbsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeInMobileDbSync { get; set; } 

    [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowId { get; set; } 

    [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkflowGuid { get; set; } 

    [JsonProperty("always_bcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlwaysBcc { get; set; } 

    [JsonProperty("reopenedstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReopenedStatus { get; set; } 

    [JsonProperty("reopenedstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ReopenedStatusGuid { get; set; } 

    [JsonProperty("closedrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosedRequestsEmailId { get; set; } 

    [JsonProperty("closedrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ClosedRequestsEmailGuid { get; set; } 

    [JsonProperty("pendingrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PendingRequestsEmailId { get; set; } 

    [JsonProperty("pendingrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? PendingRequestsEmailGuid { get; set; } 

    [JsonProperty("closedrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClosedRequestsEmailName { get; set; } 

    [JsonProperty("pendingrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PendingRequestsEmailName { get; set; } 

    [JsonProperty("closeduserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ClosedUserUpdateHours { get; set; } 

    [JsonProperty("pendinguserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PendingUserUpdateHours { get; set; } 

    [JsonProperty("webannouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebAnnouncement { get; set; } 

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
    public bool? DefaultExcludeFromSla { get; set; } 

    [JsonProperty("default_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowForUsers { get; set; } 

    [JsonProperty("default_sendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendAck { get; set; } 

    [JsonProperty("default_sendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSendEmail { get; set; } 

    [JsonProperty("default_matchedkbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMatchedKbId { get; set; } 

    [JsonProperty("default_kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultKbName { get; set; } 

    [JsonProperty("default_kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultKbAccessibleForEndUser { get; set; } 

    [JsonProperty("allowall_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllActions { get; set; } 

    [JsonProperty("allowall_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllTeam { get; set; } 

    [JsonProperty("allowed_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedTeams>? AllowedTeams { get; set; } 

    [JsonProperty("allowed_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Restriction>? AllowedActions { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllStatus { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeStatus>? AllowedStatus { get; set; } 

    [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory1 { get; set; } 

    [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory1 { get; set; } 

    [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory2 { get; set; } 

    [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory2 { get; set; } 

    [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory3 { get; set; } 

    [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory3 { get; set; } 

    [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory4 { get; set; } 

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
    public int? AcknowledgementTemplate { get; set; } 

    [JsonProperty("acknowledgementtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AcknowledgementTemplateGuid { get; set; } 

    [JsonProperty("acknowledgementtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AcknowledgementTemplateName { get; set; } 

    [JsonProperty("acknowledgementtemplateooh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AcknowledgementTemplateOoh { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AcknowledgementTemplateOohGuid { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AcknowledgementTemplateOohName { get; set; } 

    [JsonProperty("dontsendslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendSlaReminders { get; set; } 

    [JsonProperty("dontusependingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUsePendingClosure { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupId { get; set; } 

    [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DatabaseLookupName { get; set; } 

    [JsonProperty("applydefaultsontypechangebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyDefaultsOnTypeChangeBool { get; set; } 

    [JsonProperty("apply_workflow_on_type_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyWorkflowOnTypeChange { get; set; } 

    [JsonProperty("allowtickettypetobechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowTicketTypeToBeChild { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Fields { get; set; } 

    [JsonProperty("default_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultEstimate { get; set; } 

    [JsonProperty("mustclosechildbeforeclosurebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MustCloseChildBeforeClosureBool { get; set; } 

    [JsonProperty("default_sendremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendRemoteInvite { get; set; } 

    [JsonProperty("logtimeindays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LogTimeInDays { get; set; } 

    [JsonProperty("logtimeindaysincrement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? LogTimeInDaysIncrement { get; set; } 

    [JsonProperty("usetimeslotsforstartandtargettimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTimeslotsForStartAndTargetTimes { get; set; } 

    [JsonProperty("childticketcolumnsoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildTicketColumnsOverride { get; set; } 

    [JsonProperty("childticketcolumnsoverride_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ChildTicketColumnsOverrideGuid { get; set; } 

    [JsonProperty("childticketcolumnsoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChildTicketColumnsOverrideName { get; set; } 

    [JsonProperty("showunborntab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUnbornTab { get; set; } 

    [JsonProperty("allowcustomiseunborn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowCustomiseUnborn { get; set; } 

    [JsonProperty("inform_account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InformAccountManager { get; set; } 

    [JsonProperty("statusaftertechupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterTechUpdate { get; set; } 

    [JsonProperty("statusaftertechupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusAfterTechUpdateGuid { get; set; } 

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
    public ICollection<AllowedClients>? AllowedClients { get; set; } 

    [JsonProperty("closedrequestreplylimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosedRequestReplyLimit { get; set; } 

    [JsonProperty("pendingrequestreplylimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PendingRequestReplyLimit { get; set; } 

    [JsonProperty("alluserscanviewit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllUserScanViewIt { get; set; } 

    [JsonProperty("alluserscanview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AllUserScanView { get; set; } 

    [JsonProperty("thisentitycanbevotedfor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ThisEntityCanBeVotedFor { get; set; } 

    [JsonProperty("show_vote_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowVoteComment { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideWithTheFollowingTemplateWhenLoggingManually { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? OverrideWithTheFollowingTemplateWhenLoggingManuallyGuid { get; set; } 

    [JsonProperty("editservstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EditServStatus { get; set; } 

    [JsonProperty("appointmentdefaultbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentDefaultBody { get; set; } 

    [JsonProperty("appointmentdefaultbody_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AppointmentDefaultBodyGuid { get; set; } 

    [JsonProperty("appointmentdefaultbody_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppointmentDefaultBodyName { get; set; } 

    [JsonProperty("setrelatedservicesfromassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SetRelatedServicesFromAssets { get; set; } 

    [JsonProperty("default_sendtosoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSendToSoc { get; set; } 

    [JsonProperty("default_soctargettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSocTargetType { get; set; } 

    [JsonProperty("default_soctargetid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSocTargetId { get; set; } 

    [JsonProperty("default_soctargetname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSocTargetName { get; set; } 

    [JsonProperty("soc_default_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? SocDefaultTarget { get; set; } 

    [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForwardInboundUpdates { get; set; } 

    [JsonProperty("default_appointment_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentSummary { get; set; } 

    [JsonProperty("default_appointment_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentDetails { get; set; } 

    [JsonProperty("displayonquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisplayOnQuickTime { get; set; } 

    [JsonProperty("statusafterapproverupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterApproverUpdate { get; set; } 

    [JsonProperty("statusafterapproverupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusAfterApproverUpdateGuid { get; set; } 

    [JsonProperty("display_audit_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisplayAuditTab { get; set; } 

    [JsonProperty("overwrite_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverwriteShowForUsers { get; set; } 

    [JsonProperty("default_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? DefaultServices { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("showdownvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDownvote { get; set; } 

    [JsonProperty("addactionstolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddActionsToLinked { get; set; } 

    [JsonProperty("addnoteonlytolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddNoteOnlyToLinked { get; set; } 

    [JsonProperty("dontconfirm_updateparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontConfirmUpdateParent { get; set; } 

    [JsonProperty("default_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultImpact { get; set; } 

    [JsonProperty("default_risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultRiskLevel { get; set; } 

    [JsonProperty("default_justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultJustification { get; set; } 

    [JsonProperty("default_impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultImpactDescription { get; set; } 

    [JsonProperty("default_riskleveldescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultRiskLevelDescription { get; set; } 

    [JsonProperty("default_testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTestPlan { get; set; } 

    [JsonProperty("default_backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultBackoutPlan { get; set; } 

    [JsonProperty("default_communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCommunicationPlan { get; set; } 

    [JsonProperty("default_changeinformation_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultChangeInformationHtml { get; set; } 

    [JsonProperty("isbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBillable { get; set; } 

    [JsonProperty("items_are_billable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemsAreBillable { get; set; } 

    [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultResourceType { get; set; } 

    [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultResourceTypeName { get; set; } 

    [JsonProperty("defaultlisttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultListType { get; set; } 

    [JsonProperty("defaulttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTab { get; set; } 

    [JsonProperty("defaultsync_to_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSyncToSentinel { get; set; } 

    [JsonProperty("adduserupdatestochildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddUserUpdatesToChildren { get; set; } 

    [JsonProperty("default_targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTargetDate { get; set; } 

    [JsonProperty("allowed_resourcebooking_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedTeams>? AllowedResourceBookingTeams { get; set; } 

    [JsonProperty("defaultresourcetype_name_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultResourceTypeNameAgent { get; set; } 

    [JsonProperty("agentresourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentResourceBookingType { get; set; } 

    [JsonProperty("userbookfromportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserBookFromPortal { get; set; } 

    [JsonProperty("defaultresourcetype_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultResourceTypeAgent { get; set; } 

    [JsonProperty("defaultagentresourcebookingduration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAgentResourceBookingDurationId { get; set; } 

    [JsonProperty("rtdefaultagentresourcebookingduration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RtDefaultAgentResourceBookingDurationName { get; set; } 

    [JsonProperty("showotheropenticketsinnewtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOtherOpenTicketsInNewTab { get; set; } 

    [JsonProperty("showopenusertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenUserTickets { get; set; } 

    [JsonProperty("showopensitetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenSiteTickets { get; set; } 

    [JsonProperty("showopenclienttickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenClientTickets { get; set; } 

    [JsonProperty("showopendevicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenDeviceTickets { get; set; } 

    [JsonProperty("showuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUserFeed { get; set; } 

    [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateServiceStatus { get; set; } 

    [JsonProperty("default_servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultServiceStatusNote { get; set; } 

    [JsonProperty("attendeesenduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttendeesEndUser { get; set; } 

    [JsonProperty("showautomationstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAutomationsTab { get; set; } 

    [JsonProperty("showbillingtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowBillingTab { get; set; } 

    [JsonProperty("showsuggestionstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSuggestionsTab { get; set; } 

    [JsonProperty("showoppcontacttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOppContactTab { get; set; } 

    [JsonProperty("showactivestatuskanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowActiveStatusKanban { get; set; } 

    [JsonProperty("ganttgrandchildview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GanttGrandChildView { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("submitlabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubmitLabelOverride { get; set; } 

    [JsonProperty("allowall_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllAppointmentTypes { get; set; } 

    [JsonProperty("include_appointments_scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeAppointmentsScheduledHours { get; set; } 

    [JsonProperty("ticketlinktype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketLinkType { get; set; } 

    [JsonProperty("allowed_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedAppointmentTypes>? AllowedAppointmentTypes { get; set; } 

    [JsonProperty("allowall_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllIframeCustomTabs { get; set; } 

    [JsonProperty("allowed_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedIframeCustomTabs>? AllowedIframeCustomTabs { get; set; } 

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
    public bool? ShowDescendantWarningOptions { get; set; } 

    [JsonProperty("statusafterresourcebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterResourceBook { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentStatusAfterAllChildClosed { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentStatusAfterAllChildClosedName { get; set; } 

    [JsonProperty("allowlogonbehalfof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AllowLogonBehalfOf { get; set; } 

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
    public string? NewRequestMessage { get; set; } 

    [JsonProperty("allow_anonymous_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonymousLogging { get; set; } 

    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublishedId { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

    [JsonProperty("add_ack_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddAckAttachments { get; set; } 

    [JsonProperty("defaultpagerdutyservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPagerDutyService { get; set; } 

    [JsonProperty("defaultpagerdutyservice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPagerDutyServiceName { get; set; } 

    [JsonProperty("defaultsidebarcollapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSidebarCollapsed { get; set; } 

    [JsonProperty("logonbehalflabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogOnBehalfLabelOverride { get; set; } 

    [JsonProperty("tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabDisplay { get; set; } 

    [JsonProperty("sprint_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SprintTicketTypeId { get; set; } 

    [JsonProperty("sprint_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SprintTicketTypeName { get; set; } 

    [JsonProperty("usemilestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseMilestones { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? TabConfig { get; set; } 

    [JsonProperty("enableusermentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableUserMentions { get; set; } 

    [JsonProperty("sladontclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SlaDontClose { get; set; } 

    [JsonProperty("pendingdontclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PendingDontClose { get; set; } 

    [JsonProperty("minattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinAttachments { get; set; } 

    [JsonProperty("enableforecasting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableForecasting { get; set; } 

    [JsonProperty("make_cc_followers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MakeCcFollowers { get; set; } 

    [JsonProperty("default_kanban_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultKanbanView { get; set; } 

    [JsonProperty("showgeneralsurveyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowGeneralSurveyFields { get; set; } 

    [JsonProperty("default_send_to_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultSendToPagerDuty { get; set; } 

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
    public int? TodoListPortalVisibility { get; set; } 

    [JsonProperty("legacy_print_request_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LegacyPrintRequestDetails { get; set; } 

    [JsonProperty("legacy_print_service_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LegacyPrintServiceForm { get; set; } 

    [JsonProperty("default_appt_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultApptType { get; set; } 

    [JsonProperty("show_child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowChildAssets { get; set; } 

    [JsonProperty("hide_anon_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAnonPhoneNumber { get; set; } 

    [JsonProperty("showconfirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowConfirmEmail { get; set; } 

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
    public bool? ShowOpenSupplierTickets { get; set; } 

    [JsonProperty("allowall_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllSuggestionFaqLists { get; set; } 

    [JsonProperty("allowed_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedSuggestionFaqLists>? AllowedSuggestionFaqLists { get; set; } 

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
    public int? DefaultServiceNowType { get; set; } 

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
    public bool? ContinueAutoRelease { get; set; } 

    [JsonProperty("do_ai_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoAiSurvey { get; set; } 

    [JsonProperty("enduserscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndUsersCanLog { get; set; } 

    [JsonProperty("anonymouscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AnonymousCanLog { get; set; } 

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
    public TicketTypeLoadBalanceSchedule? LoadBalanceSchedule { get; set; } 

    [JsonProperty("allowall_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllChildTicketTypes { get; set; } 

    [JsonProperty("allowed_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AllowedChildTicketType>? AllowedChildTicketTypes { get; set; } 

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
    public bool? HideUserDetails { get; set; } 

    [JsonProperty("allowanonattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonAttachments { get; set; } 

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
    public ICollection<StringIdNameKeyPair>? KanbanStatusChoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KanbanStatusChoiceList { get; set; } 

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
    public string? OverrideWithTheFollowingTemplateWhenLoggingManuallyName { get; set; } 

    [JsonProperty("default_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPriority { get; set; } 

    [JsonProperty("visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Visible { get; set; } 

}