using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RequestType
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
    public Guid? Default_sla_guid { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_name { get; set; } 

    [JsonProperty("jira_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jira_issue_type { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_count { get; set; } 

    [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cancreate { get; set; } 

    [JsonProperty("agentscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agentscanselect { get; set; } 

    [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itilrequesttype { get; set; } 

    [JsonProperty("allowattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowattachments { get; set; } 

    [JsonProperty("copyattachmentstochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstochild { get; set; } 

    [JsonProperty("copyattachmentstorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstorelated { get; set; } 

    [JsonProperty("is_sprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_sprint { get; set; } 

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
    public Guid? Statusafteruserupdate_guid { get; set; } 

    [JsonProperty("statusaftersupplierupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusaftersupplierupdate { get; set; } 

    [JsonProperty("statusaftersupplierupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Statusaftersupplierupdate_guid { get; set; } 

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
    public int? Workflow_id { get; set; } 

    [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Workflow_guid { get; set; } 

    [JsonProperty("always_bcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Always_bcc { get; set; } 

    [JsonProperty("reopenedstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reopenedstatus { get; set; } 

    [JsonProperty("reopenedstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Reopenedstatus_guid { get; set; } 

    [JsonProperty("closedrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Closedrequestsemailid { get; set; } 

    [JsonProperty("closedrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Closedrequestsemailguid { get; set; } 

    [JsonProperty("pendingrequestsemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pendingrequestsemailid { get; set; } 

    [JsonProperty("pendingrequestsemailguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Pendingrequestsemailguid { get; set; } 

    [JsonProperty("closedrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Closedrequestsemail_name { get; set; } 

    [JsonProperty("pendingrequestsemail_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pendingrequestsemail_name { get; set; } 

    [JsonProperty("closeduserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Closeduserupdatehours { get; set; } 

    [JsonProperty("pendinguserupdatehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Pendinguserupdatehours { get; set; } 

    [JsonProperty("webannouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webannouncement { get; set; } 

    [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chargerate { get; set; } 

    [JsonProperty("initial_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Initial_status { get; set; } 

    [JsonProperty("initial_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Initial_status_guid { get; set; } 

    [JsonProperty("default_team_to_agents_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_team_to_agents_default { get; set; } 

    [JsonProperty("default_sla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sla { get; set; } 

    [JsonProperty("default_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_category_1 { get; set; } 

    [JsonProperty("default_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_category_2 { get; set; } 

    [JsonProperty("default_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_category_3 { get; set; } 

    [JsonProperty("default_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_category_4 { get; set; } 

    [JsonProperty("default_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_summary { get; set; } 

    [JsonProperty("default_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_details { get; set; } 

    [JsonProperty("default_details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_details_html { get; set; } 

    [JsonProperty("default_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_excludefromsla { get; set; } 

    [JsonProperty("default_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_showforusers { get; set; } 

    [JsonProperty("default_sendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sendack { get; set; } 

    [JsonProperty("default_sendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_sendemail { get; set; } 

    [JsonProperty("default_matchedkbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_matchedkbid { get; set; } 

    [JsonProperty("default_kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_kb_name { get; set; } 

    [JsonProperty("default_kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_kb_accessible_for_enduser { get; set; } 

    [JsonProperty("allowall_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_actions { get; set; } 

    [JsonProperty("allowall_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_team { get; set; } 

    [JsonProperty("allowed_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionRequestType>? Allowed_teams { get; set; } 

    [JsonProperty("allowed_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Restriction>? Allowed_actions { get; set; } 

    [JsonProperty("allowall_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_status { get; set; } 

    [JsonProperty("allowed_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RequestTypeStatus>? Allowed_status { get; set; } 

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

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_process_id { get; set; } 

    [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Approval_process_guid { get; set; } 

    [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approval_process_name { get; set; } 

    [JsonProperty("from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? From_mailbox_id { get; set; } 

    [JsonProperty("hide_respond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_respond { get; set; } 

    [JsonProperty("close_kb_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Close_kb_action { get; set; } 

    [JsonProperty("default_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_product_id { get; set; } 

    [JsonProperty("default_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_product_name { get; set; } 

    [JsonProperty("default_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_budgettype_id { get; set; } 

    [JsonProperty("default_budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_budgettype_name { get; set; } 

    [JsonProperty("email_start_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_start_tag_override { get; set; } 

    [JsonProperty("email_end_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_end_tag_override { get; set; } 

    [JsonProperty("acknowledgementtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Acknowledgementtemplate { get; set; } 

    [JsonProperty("acknowledgementtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Acknowledgementtemplate_guid { get; set; } 

    [JsonProperty("acknowledgementtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Acknowledgementtemplate_name { get; set; } 

    [JsonProperty("acknowledgementtemplateooh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Acknowledgementtemplateooh { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Acknowledgementtemplateooh_guid { get; set; } 

    [JsonProperty("acknowledgementtemplateooh_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Acknowledgementtemplateooh_name { get; set; } 

    [JsonProperty("dontsendslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendslareminders { get; set; } 

    [JsonProperty("dontusependingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontusependingclosure { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Database_lookup_id { get; set; } 

    [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Database_lookup_name { get; set; } 

    [JsonProperty("applydefaultsontypechangebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applydefaultsontypechangebool { get; set; } 

    [JsonProperty("apply_workflow_on_type_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Apply_workflow_on_type_change { get; set; } 

    [JsonProperty("allowtickettypetobechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowtickettypetobechild { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RequestTypeField>? Fields { get; set; } 

    [JsonProperty("default_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Default_estimate { get; set; } 

    [JsonProperty("mustclosechildbeforeclosurebool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mustclosechildbeforeclosurebool { get; set; } 

    [JsonProperty("default_sendremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sendremoteinvite { get; set; } 

    [JsonProperty("logtimeindays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Logtimeindays { get; set; } 

    [JsonProperty("logtimeindaysincrement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Logtimeindaysincrement { get; set; } 

    [JsonProperty("usetimeslotsforstartandtargettimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usetimeslotsforstartandtargettimes { get; set; } 

    [JsonProperty("childticketcolumnsoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Childticketcolumnsoverride { get; set; } 

    [JsonProperty("childticketcolumnsoverride_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Childticketcolumnsoverride_guid { get; set; } 

    [JsonProperty("childticketcolumnsoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Childticketcolumnsoverride_name { get; set; } 

    [JsonProperty("showunborntab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showunborntab { get; set; } 

    [JsonProperty("allowcustomiseunborn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowcustomiseunborn { get; set; } 

    [JsonProperty("inform_account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inform_account_manager { get; set; } 

    [JsonProperty("statusaftertechupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusaftertechupdate { get; set; } 

    [JsonProperty("statusaftertechupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Statusaftertechupdate_guid { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdftemplate_id { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pdftemplate_name { get; set; } 

    [JsonProperty("quote_pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quote_pdftemplate_id { get; set; } 

    [JsonProperty("quote_pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quote_pdftemplate_name { get; set; } 

    [JsonProperty("maximumRestrictedPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaximumRestrictedPriority { get; set; } 

    [JsonProperty("auto_respond_logged_manually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_respond_logged_manually { get; set; } 

    [JsonProperty("autoCloseHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoCloseHours { get; set; } 

    [JsonProperty("allowed_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaRequestType>? Allowed_clients { get; set; } 

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
    public bool? Show_vote_comment { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overridewiththefollowingtemplatewhenloggingmanually { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanually_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Overridewiththefollowingtemplatewhenloggingmanually_guid { get; set; } 

    [JsonProperty("editservstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Editservstatus { get; set; } 

    [JsonProperty("appointmentdefaultbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Appointmentdefaultbody { get; set; } 

    [JsonProperty("appointmentdefaultbody_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Appointmentdefaultbody_guid { get; set; } 

    [JsonProperty("appointmentdefaultbody_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Appointmentdefaultbody_name { get; set; } 

    [JsonProperty("setrelatedservicesfromassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Setrelatedservicesfromassets { get; set; } 

    [JsonProperty("default_sendtosoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sendtosoc { get; set; } 

    [JsonProperty("default_soctargettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_soctargettype { get; set; } 

    [JsonProperty("default_soctargetid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_soctargetid { get; set; } 

    [JsonProperty("default_soctargetname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_soctargetname { get; set; } 

    [JsonProperty("soc_default_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Soc_default_target { get; set; } 

    [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forwardinboundupdates { get; set; } 

    [JsonProperty("default_appointment_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_appointment_summary { get; set; } 

    [JsonProperty("default_appointment_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_appointment_details { get; set; } 

    [JsonProperty("displayonquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Displayonquicktime { get; set; } 

    [JsonProperty("statusafterapproverupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafterapproverupdate { get; set; } 

    [JsonProperty("statusafterapproverupdate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Statusafterapproverupdate_guid { get; set; } 

    [JsonProperty("display_audit_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Display_audit_tab { get; set; } 

    [JsonProperty("overwrite_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Overwrite_showforusers { get; set; } 

    [JsonProperty("default_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSite_List>? Default_services { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("showdownvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showdownvote { get; set; } 

    [JsonProperty("addactionstolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addactionstolinked { get; set; } 

    [JsonProperty("addnoteonlytolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addnoteonlytolinked { get; set; } 

    [JsonProperty("dontconfirm_updateparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontconfirm_updateparent { get; set; } 

    [JsonProperty("default_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_impact { get; set; } 

    [JsonProperty("default_risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_risklevel { get; set; } 

    [JsonProperty("default_justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_justification { get; set; } 

    [JsonProperty("default_impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_impactdescription { get; set; } 

    [JsonProperty("default_riskleveldescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_riskleveldescription { get; set; } 

    [JsonProperty("default_testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_testplan { get; set; } 

    [JsonProperty("default_backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_backoutplan { get; set; } 

    [JsonProperty("default_communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_communicationplan { get; set; } 

    [JsonProperty("default_changeinformation_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_changeinformation_html { get; set; } 

    [JsonProperty("isbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isbillable { get; set; } 

    [JsonProperty("items_are_billable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Items_are_billable { get; set; } 

    [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultresourcetype { get; set; } 

    [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultresourcetype_name { get; set; } 

    [JsonProperty("defaultlisttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultlisttype { get; set; } 

    [JsonProperty("defaulttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaulttab { get; set; } 

    [JsonProperty("defaultsync_to_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Defaultsync_to_sentinel { get; set; } 

    [JsonProperty("adduserupdatestochildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Adduserupdatestochildren { get; set; } 

    [JsonProperty("default_targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_targetdate { get; set; } 

    [JsonProperty("allowed_resourcebooking_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionRequestType>? Allowed_resourcebooking_teams { get; set; } 

    [JsonProperty("defaultresourcetype_name_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultresourcetype_name_agent { get; set; } 

    [JsonProperty("agentresourcebookingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agentresourcebookingtype { get; set; } 

    [JsonProperty("userbookfromportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Userbookfromportal { get; set; } 

    [JsonProperty("defaultresourcetype_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultresourcetype_agent { get; set; } 

    [JsonProperty("defaultagentresourcebookingduration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultagentresourcebookingduration_id { get; set; } 

    [JsonProperty("rtdefaultagentresourcebookingduration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Rtdefaultagentresourcebookingduration_name { get; set; } 

    [JsonProperty("showotheropenticketsinnewtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showotheropenticketsinnewtab { get; set; } 

    [JsonProperty("showopenusertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showopenusertickets { get; set; } 

    [JsonProperty("showopensitetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showopensitetickets { get; set; } 

    [JsonProperty("showopenclienttickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showopenclienttickets { get; set; } 

    [JsonProperty("showopendevicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showopendevicetickets { get; set; } 

    [JsonProperty("showuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showuserfeed { get; set; } 

    [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Updateservicestatus { get; set; } 

    [JsonProperty("default_servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_servicestatusnote { get; set; } 

    [JsonProperty("attendeesenduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attendeesenduser { get; set; } 

    [JsonProperty("showautomationstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showautomationstab { get; set; } 

    [JsonProperty("showbillingtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showbillingtab { get; set; } 

    [JsonProperty("showsuggestionstab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showsuggestionstab { get; set; } 

    [JsonProperty("showoppcontacttab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showoppcontacttab { get; set; } 

    [JsonProperty("showactivestatuskanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showactivestatuskanban { get; set; } 

    [JsonProperty("ganttgrandchildview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ganttgrandchildview { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("submitlabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Submitlabeloverride { get; set; } 

    [JsonProperty("allowall_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_appointment_types { get; set; } 

    [JsonProperty("include_appointments_scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include_appointments_scheduled_hours { get; set; } 

    [JsonProperty("ticketlinktype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticketlinktype { get; set; } 

    [JsonProperty("allowed_appointment_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AppointmentTypeRequestType>? Allowed_appointment_types { get; set; } 

    [JsonProperty("allowall_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_iframe_customtabs { get; set; } 

    [JsonProperty("allowed_iframe_customtabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IframeTabRequestType>? Allowed_iframe_customtabs { get; set; } 

    [JsonProperty("default_sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_sync_to_salesforce { get; set; } 

    [JsonProperty("salesforce_default_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesforce_default_stage { get; set; } 

    [JsonProperty("show_add_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_add_note { get; set; } 

    [JsonProperty("auto_delete_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_delete_data { get; set; } 

    [JsonProperty("auto_delete_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_delete_days { get; set; } 

    [JsonProperty("show_child_tasks_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Show_child_tasks_type { get; set; } 

    [JsonProperty("pin_important_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pin_important_actions { get; set; } 

    [JsonProperty("showdecendantwarningoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showdecendantwarningoptions { get; set; } 

    [JsonProperty("statusafterresourcebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafterresourcebook { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentstatusafterallchildclosed { get; set; } 

    [JsonProperty("parentstatusafterallchildclosed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Parentstatusafterallchildclosed_name { get; set; } 

    [JsonProperty("allowlogonbehalfof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Allowlogonbehalfof { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("auto_create_appt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_create_appt { get; set; } 

    [JsonProperty("hide_anon_contact_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_anon_contact_info { get; set; } 

    [JsonProperty("ticket_created_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_created_override { get; set; } 

    [JsonProperty("newrequestmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Newrequestmessage { get; set; } 

    [JsonProperty("allow_anonymous_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_anonymous_logging { get; set; } 

    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Published_id { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Cors_whitelist_list { get; set; } 

    [JsonProperty("add_ack_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Add_ack_attachments { get; set; } 

    [JsonProperty("defaultpagerdutyservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultpagerdutyservice { get; set; } 

    [JsonProperty("defaultpagerdutyservice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultpagerdutyservice_name { get; set; } 

    [JsonProperty("defaultsidebarcollapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Defaultsidebarcollapsed { get; set; } 

    [JsonProperty("logonbehalflabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logonbehalflabeloverride { get; set; } 

    [JsonProperty("tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_display { get; set; } 

    [JsonProperty("sprint_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sprint_tickettype_id { get; set; } 

    [JsonProperty("sprint_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sprint_tickettype_name { get; set; } 

    [JsonProperty("usemilestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usemilestones { get; set; } 

    [JsonProperty("tab_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabConfig>? Tab_config { get; set; } 

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
    public bool? Make_cc_followers { get; set; } 

    [JsonProperty("default_kanban_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_kanban_view { get; set; } 

    [JsonProperty("showgeneralsurveyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showgeneralsurveyfields { get; set; } 

    [JsonProperty("default_send_to_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_send_to_pagerduty { get; set; } 

    [JsonProperty("completion_status_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Completion_status_type { get; set; } 

    [JsonProperty("show_project_task_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_project_task_dates { get; set; } 

    [JsonProperty("auto_forward_email_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_forward_email_updates { get; set; } 

    [JsonProperty("default_is_sensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_is_sensitive { get; set; } 

    [JsonProperty("process_open_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Process_open_tickets { get; set; } 

    [JsonProperty("todolistportalvisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Todolistportalvisibility { get; set; } 

    [JsonProperty("legacy_print_request_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Legacy_print_request_details { get; set; } 

    [JsonProperty("legacy_print_service_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Legacy_print_service_form { get; set; } 

    [JsonProperty("default_appt_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_appt_type { get; set; } 

    [JsonProperty("show_child_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_child_assets { get; set; } 

    [JsonProperty("hide_anon_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_anon_phonenumber { get; set; } 

    [JsonProperty("showconfirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showconfirmemail { get; set; } 

    [JsonProperty("ticket_status_after_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_status_after_appointment { get; set; } 

    [JsonProperty("max_open_per_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_open_per_user { get; set; } 

    [JsonProperty("max_total_per_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_total_per_user { get; set; } 

    [JsonProperty("max_open_per_user_reached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Max_open_per_user_reached { get; set; } 

    [JsonProperty("max_total_per_user_reached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Max_total_per_user_reached { get; set; } 

    [JsonProperty("milestone_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Milestone_billing { get; set; } 

    [JsonProperty("showopensuppliertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showopensuppliertickets { get; set; } 

    [JsonProperty("allowall_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_suggestion_faqlists { get; set; } 

    [JsonProperty("allowed_suggestion_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaqRequestType>? Allowed_suggestion_faqlists { get; set; } 

    [JsonProperty("startdate_validation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Startdate_validation { get; set; } 

    [JsonProperty("startdate_validation_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Startdate_validation_days { get; set; } 

    [JsonProperty("targetdate_validation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Targetdate_validation { get; set; } 

    [JsonProperty("targetdate_validation_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Targetdate_validation_days { get; set; } 

    [JsonProperty("auto_contributor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Auto_contributor { get; set; } 

    [JsonProperty("allow_teams_chat_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_teams_chat_creation { get; set; } 

    [JsonProperty("teams_chat_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teams_chat_default_name { get; set; } 

    [JsonProperty("show_teams_chats_as_tabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_teams_chats_as_tabs { get; set; } 

    [JsonProperty("default_servicenow_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_servicenow_type { get; set; } 

    [JsonProperty("enable_task_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_task_dependencies { get; set; } 

    [JsonProperty("exclude_from_sales_mailbox_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exclude_from_sales_mailbox_match { get; set; } 

    [JsonProperty("lapsafe_status_after_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lapsafe_status_after_webhook { get; set; } 

    [JsonProperty("lapsafe_status_after_webhook_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Lapsafe_status_after_webhook_guid { get; set; } 

    [JsonProperty("show_status_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_status_on_portal { get; set; } 

    [JsonProperty("allow_slack_channel_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_slack_channel_creation { get; set; } 

    [JsonProperty("slack_channel_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Slack_channel_default_name { get; set; } 

    [JsonProperty("show_slack_channels_as_tabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_slack_channels_as_tabs { get; set; } 

    [JsonProperty("slack_channel_access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slack_channel_access_type { get; set; } 

    [JsonProperty("slack_channel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slack_channel_workspace { get; set; } 

    [JsonProperty("slack_channel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Slack_channel_workspace_name { get; set; } 

    [JsonProperty("hide_anon_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Hide_anon_email { get; set; } 

    [JsonProperty("continue_autorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Continue_autorelease { get; set; } 

    [JsonProperty("do_ai_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Do_ai_survey { get; set; } 

    [JsonProperty("enduserscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserscanlog { get; set; } 

    [JsonProperty("anonymouscanlog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Anonymouscanlog { get; set; } 

    [JsonProperty("generate_ai_embeddings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Generate_ai_embeddings { get; set; } 

    [JsonProperty("load_balance_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Load_balance_interval { get; set; } 

    [JsonProperty("load_balance_max_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Load_balance_max_tickets { get; set; } 

    [JsonProperty("load_balance_on_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Load_balance_on_schedule { get; set; } 

    [JsonProperty("load_balance_schedule_frequency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Load_balance_schedule_frequency { get; set; } 

    [JsonProperty("load_balance_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AssignSchedule? Load_balance_schedule { get; set; } 

    [JsonProperty("allowall_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_child_tickettypes { get; set; } 

    [JsonProperty("allowed_child_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChildRequestType>? Allowed_child_tickettypes { get; set; } 

    [JsonProperty("portal_summary_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Portal_summary_hint_is_placeholder { get; set; } 

    [JsonProperty("portal_details_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Portal_details_hint_is_placeholder { get; set; } 

    [JsonProperty("agent_summary_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agent_summary_hint_is_placeholder { get; set; } 

    [JsonProperty("agent_details_hint_is_placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agent_details_hint_is_placeholder { get; set; } 

    [JsonProperty("portal_screen_after_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Portal_screen_after_logging { get; set; } 

    [JsonProperty("show_related_of_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Show_related_of_related { get; set; } 

    [JsonProperty("show_all_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Show_all_related { get; set; } 

    [JsonProperty("hideuserdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideuserdetails { get; set; } 

    [JsonProperty("allowanonattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowanonattachments { get; set; } 

    [JsonProperty("inherit_parent_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inherit_parent_category1 { get; set; } 

    [JsonProperty("inherit_parent_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inherit_parent_category2 { get; set; } 

    [JsonProperty("inherit_parent_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inherit_parent_category3 { get; set; } 

    [JsonProperty("inherit_parent_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inherit_parent_category4 { get; set; } 

    [JsonProperty("default_is_downtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default_is_downtime { get; set; } 

    [JsonProperty("is_chat_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_chat_ticket { get; set; } 

    [JsonProperty("add_related_assets_to_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Add_related_assets_to_parent { get; set; } 

    [JsonProperty("third_party_migration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_migration_id { get; set; } 

    [JsonProperty("wait_time_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wait_time_type { get; set; } 

    [JsonProperty("default_wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Default_wait_time { get; set; } 

    [JsonProperty("wait_time_calc_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wait_time_calc_hours { get; set; } 

    [JsonProperty("project_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Project_type { get; set; } 

    [JsonProperty("kanbanstatuschoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Kanbanstatuschoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kanbanstatuschoice_list { get; set; } 

    [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_start_tag { get; set; } 

    [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_end_tag { get; set; } 

    [JsonProperty("default_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_agent { get; set; } 

    [JsonProperty("default_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_agent_name { get; set; } 

    [JsonProperty("default_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_team { get; set; } 

    [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Workflow_name { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanuallyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Overridewiththefollowingtemplatewhenloggingmanuallyname { get; set; } 

    [JsonProperty("default_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_priority { get; set; } 

    [JsonProperty("visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Visible { get; set; } 

}