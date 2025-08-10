using System.CodeDom.Compiler;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.KeyPairs;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class ActionOutcome
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome { get; set; } 

        [JsonProperty("buttonname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Buttonname { get; set; } 

        [JsonProperty("labellong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Labellong { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidden { get; set; } 

        [JsonProperty("systemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Systemid { get; set; } 

        [JsonProperty("dontshowscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontShowScreen { get; set; } 

        [JsonProperty("respondtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Respondtype { get; set; } 

        [JsonProperty("update_parent_attachment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateParentAttachmentType { get; set; } 

        [JsonProperty("sendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SendEmail { get; set; } 

        [JsonProperty("sendsms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendsms { get; set; } 

        [JsonProperty("actionvisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actionvisibility { get; set; } 

        [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildTemplateId { get; set; } 

        [JsonProperty("createchildticketortemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createchildticketortemplate { get; set; } 

        [JsonProperty("child_ticket_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildTicketTypeId { get; set; } 

        [JsonProperty("tfstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tfstype { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("translate_before_sending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TranslateBeforeSending { get; set; } 

        [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ColourType { get; set; } 

        [JsonProperty("child_template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChildTemplateGuid { get; set; } 

        [JsonProperty("child_ticket_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChildTicketTypeGuid { get; set; } 

        [JsonProperty("newstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStatus { get; set; } 

        [JsonProperty("newstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewStatusGuid { get; set; } 

        [JsonProperty("slaholdischecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SlaHoldischecked { get; set; } 

        [JsonProperty("userdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDesc { get; set; } 

        [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailTemplateId { get; set; } 

        [JsonProperty("emailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? EmailTemplateGuid { get; set; } 

        [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailTemplateName { get; set; } 

        [JsonProperty("slareleaseischecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SlaReleaseischecked { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeRate { get; set; } 

        [JsonProperty("defaultuserdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultUserdef { get; set; } 

        [JsonProperty("defaultmanhrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultManhrs { get; set; } 

        [JsonProperty("defaultnonbill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultNonbill { get; set; } 

        [JsonProperty("securitylevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Securitylevel { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalProcessId { get; set; } 

        [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ApprovalProcessGuid { get; set; } 

        [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApprovalProcessName { get; set; } 

        [JsonProperty("hidefromuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFromuser { get; set; } 

        [JsonProperty("fieldvisible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldvisible { get; set; } 

        [JsonProperty("hotkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hotkey { get; set; } 

        [JsonProperty("buttonimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Buttonimage { get; set; } 

        [JsonProperty("hidesendemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideSendEmail { get; set; } 

        [JsonProperty("hidesendsms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideSendsms { get; set; } 

        [JsonProperty("hidecloserequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideCloserequest { get; set; } 

        [JsonProperty("defaultagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAgent { get; set; } 

        [JsonProperty("defaultagent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAgentName { get; set; } 

        [JsonProperty("defaultpriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPriority { get; set; } 

        [JsonProperty("defaultteam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTeam { get; set; } 

        [JsonProperty("includecc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includecc { get; set; } 

        [JsonProperty("includeto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTo { get; set; } 

        [JsonProperty("default_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultNote { get; set; } 

        [JsonProperty("mustassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustassign { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestType { get; set; } 

        [JsonProperty("requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RequestTypeGuid { get; set; } 

        [JsonProperty("mustaddnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustaddnote { get; set; } 

        [JsonProperty("worddocid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Worddocid { get; set; } 

        [JsonProperty("worddocpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Worddocpath { get; set; } 

        [JsonProperty("synctosap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToSap { get; set; } 

        [JsonProperty("child_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildTemplateName { get; set; } 

        [JsonProperty("child_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildTicketTypeName { get; set; } 

        [JsonProperty("tooverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tooverride { get; set; } 

        [JsonProperty("ccoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ccoverride { get; set; } 

        [JsonProperty("bccoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bccoverride { get; set; } 

        [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowId { get; set; } 

        [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? WorkflowGuid { get; set; } 

        [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowName { get; set; } 

        [JsonProperty("workflow_step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowStepId { get; set; } 

        [JsonProperty("workflow_step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowStepName { get; set; } 

        [JsonProperty("synctodynamics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncTodynamics { get; set; } 

        [JsonProperty("showhidecheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowHideCheckbox { get; set; } 

        [JsonProperty("showslacheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSlaCheckbox { get; set; } 

        [JsonProperty("showimportantcheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowImportantcheckbox { get; set; } 

        [JsonProperty("isimportant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImportant { get; set; } 

        [JsonProperty("showfollowcheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFollowcheckbox { get; set; } 

        [JsonProperty("follow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Follow { get; set; } 

        [JsonProperty("primaryserviceusersfollow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primaryserviceusersfollow { get; set; } 

        [JsonProperty("defaultappointmentstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAppointmentstatus { get; set; } 

        [JsonProperty("reportid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reportid { get; set; } 

        [JsonProperty("report_attach_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReportAttachPdf { get; set; } 

        [JsonProperty("report_attach_xls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReportAttachXls { get; set; } 

        [JsonProperty("report_attach_csv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReportAttachCsv { get; set; } 

        [JsonProperty("report_attach_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReportAttachJson { get; set; } 

        [JsonProperty("reportname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reportname { get; set; } 

        [JsonProperty("todo_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TodoTemplateId { get; set; } 

        [JsonProperty("todo_template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TodoTemplateGuid { get; set; } 

        [JsonProperty("todo_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TodoTemplateName { get; set; } 

        [JsonProperty("child_emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildEmailTemplateId { get; set; } 

        [JsonProperty("child_emailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChildEmailTemplateGuid { get; set; } 

        [JsonProperty("child_emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildEmailTemplateName { get; set; } 

        [JsonProperty("default_linkedticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultLinkedTicketStatus { get; set; } 

        [JsonProperty("default_linkedticket_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultLinkedTicketStatusGuid { get; set; } 

        [JsonProperty("newaction_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionSubject { get; set; } 

        [JsonProperty("newaction_subject_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionSubjectClose { get; set; } 

        [JsonProperty("newaction_emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionEmailTo { get; set; } 

        [JsonProperty("newaction_emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionEmailCc { get; set; } 

        [JsonProperty("newaction_emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionEmailBcc { get; set; } 

        [JsonProperty("newaction_emailfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionEmailFrom { get; set; } 

        [JsonProperty("newaction_emailfrom_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionEmailFromAddressOverride { get; set; } 

        [JsonProperty("newaction_projecttimebudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NewActionProjecttimebudget { get; set; } 

        [JsonProperty("newaction_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Supplier? NewActionSupplier { get; set; } 

        [JsonProperty("newaction_supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionSupplierContractId { get; set; } 

        [JsonProperty("newaction_supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionSupplierSlaId { get; set; } 

        [JsonProperty("newaction_supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionSupplierPriorityId { get; set; } 

        [JsonProperty("newaction_thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionThirdPartyNhdApiUrl { get; set; } 

        [JsonProperty("newaction_thirdpartynhdapiareaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionThirdPartyNhdApiareaid { get; set; } 

        [JsonProperty("newaction_thirdpartynhdapisupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionThirdPartyNhdApisupplierid { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? Fields { get; set; } 

        [JsonProperty("newticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public User? NewTicketUser { get; set; } 

        [JsonProperty("from_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FromActionId { get; set; } 

        [JsonProperty("to_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToTicketId { get; set; } 

        [JsonProperty("newticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTicketSummary { get; set; } 

        [JsonProperty("newticket_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTicketDetails { get; set; } 

        [JsonProperty("newticket_tickettype_hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewTicketTicketTypeHidden { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Attachments { get; set; } 

        [JsonProperty("_ticketinfoloaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketinfoloaded { get; set; } 

        [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScriptId { get; set; } 

        [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScriptName { get; set; } 

        [JsonProperty("usetimer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetimer { get; set; } 

        [JsonProperty("update_dynamic_email_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateDynamicEmailList { get; set; } 

        [JsonProperty("skip_pending_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipPendingClosure { get; set; } 

        [JsonProperty("newsummaryfromsource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewSummaryfromsource { get; set; } 

        [JsonProperty("newdetailsfromsource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newdetailsfromsource { get; set; } 

        [JsonProperty("show_email_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEmailFields { get; set; } 

        [JsonProperty("logtimeunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logtimeunits { get; set; } 

        [JsonProperty("callscreencallscript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Callscreencallscript { get; set; } 

        [JsonProperty("callscreencallscript_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CallscreencallscriptName { get; set; } 

        [JsonProperty("newaction_smsto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionSmsTo { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfTemplateId { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PdfTemplateName { get; set; } 

        [JsonProperty("excludeFromDynamicLists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFromDynamicLists { get; set; } 

        [JsonProperty("automation_runbookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AutomationRunbookid { get; set; } 

        [JsonProperty("automation_runbookname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomationRunbookname { get; set; } 

        [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntegrationMethodId { get; set; } 

        [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationMethodName { get; set; } 

        [JsonProperty("setdetailsfromnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setdetailsfromnewticket { get; set; } 

        [JsonProperty("hideactionfromcandi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideActionfromcandi { get; set; } 

        [JsonProperty("setemailbodytonote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setemailbodytonote { get; set; } 

        [JsonProperty("bccfollowers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bccfollowers { get; set; } 

        [JsonProperty("followersccbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Followersccbcc { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("showevenifnochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEvenifnochild { get; set; } 

        [JsonProperty("replytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplyType { get; set; } 

        [JsonProperty("parentdefaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentDefaultUser { get; set; } 

        [JsonProperty("parentdefaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentDefaultUsername { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("assetsearchtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetsearchtext { get; set; } 

        [JsonProperty("action_resets_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionResetsResponse { get; set; } 

        [JsonProperty("showattachmentstouser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAttachmentsToUser { get; set; } 

        [JsonProperty("customurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomUrl { get; set; } 

        [JsonProperty("defaultcat1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCat1 { get; set; } 

        [JsonProperty("defaultcat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCat2 { get; set; } 

        [JsonProperty("defaultcat3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCat3 { get; set; } 

        [JsonProperty("defaultcat4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCat4 { get; set; } 

        [JsonProperty("includeallattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAllattachments { get; set; } 

        [JsonProperty("useremailintellisense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useremailintellisense { get; set; } 

        [JsonProperty("supplieremailintellisense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplieremailintellisense { get; set; } 

        [JsonProperty("azure_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAction { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureConnectionId { get; set; } 

        [JsonProperty("azure_connection_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureConnectionName { get; set; } 

        [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureAdConnection? AzureConnection { get; set; } 

        [JsonProperty("azure_input_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AzureInputMappings { get; set; } 

        [JsonProperty("azure_output_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AzureOutputMappings { get; set; } 

        [JsonProperty("default_sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSyncToSalesforce { get; set; } 

        [JsonProperty("show_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowToUser { get; set; } 

        [JsonProperty("defaultsupplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSupplierId { get; set; } 

        [JsonProperty("defaultsupplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSupplierName { get; set; } 

        [JsonProperty("isbillingaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBillingAction { get; set; } 

        [JsonProperty("ishiddenfrominternalit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ishiddenfrominternalit { get; set; } 

        [JsonProperty("default_sync_to_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSyncToServiceNow { get; set; } 

        [JsonProperty("default_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssetType { get; set; } 

        [JsonProperty("default_asset_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultAssetTypeGuid { get; set; } 

        [JsonProperty("default_asset_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAssetTypeName { get; set; } 

        [JsonProperty("showautorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAutoRelease { get; set; } 

        [JsonProperty("workflows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Workflows { get; set; } 

        [JsonProperty("quoter_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterTemplate { get; set; } 

        [JsonProperty("apptcompletetimetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptcompletetimetype { get; set; } 

        [JsonProperty("default_asset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssetStatus { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? TicketTypes { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("travelrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Travelrate { get; set; } 

        [JsonProperty("default_sync_to_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSyncToJira { get; set; } 

        [JsonProperty("newaction_thirdpartynhdjirasupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionThirdPartyNhdjirasupplierid { get; set; } 

        [JsonProperty("allow_user_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserAttachments { get; set; } 

        [JsonProperty("default_send_to_halo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSendToHalo { get; set; } 

        [JsonProperty("tagreleasetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tagreleasetype { get; set; } 

        [JsonProperty("releaseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Releaseid { get; set; } 

        [JsonProperty("releasename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Releasename { get; set; } 

        [JsonProperty("releaseid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Releaseid2 { get; set; } 

        [JsonProperty("releasename2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Releasename2 { get; set; } 

        [JsonProperty("releaseid3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Releaseid3 { get; set; } 

        [JsonProperty("releasename3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Releasename3 { get; set; } 

        [JsonProperty("showsendtwitter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendtwitter { get; set; } 

        [JsonProperty("showsendfacebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendfacebook { get; set; } 

        [JsonProperty("lastusercontactmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastUserContactmethod { get; set; } 

        [JsonProperty("default_private_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultPrivateNote { get; set; } 

        [JsonProperty("ai_operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiOperation { get; set; } 

        [JsonProperty("ai_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? AiModel { get; set; } 

        [JsonProperty("ai_prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? AiPrompt { get; set; } 

        [JsonProperty("showsendwhatsapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendwhatsapp { get; set; } 

        [JsonProperty("default_opp_closure_cat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOppClosureCat { get; set; } 

        [JsonProperty("default_send_to_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSendToPagerduty { get; set; } 

        [JsonProperty("minattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Minattachments { get; set; } 

        [JsonProperty("defaultappointmenttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAppointmenttype { get; set; } 

        [JsonProperty("showsendsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendsurvey { get; set; } 

        [JsonProperty("sendsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendsurvey { get; set; } 

        [JsonProperty("showsendinstagram", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendinstagram { get; set; } 

        [JsonProperty("showslacheckbox_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSlaCheckboxMandatory { get; set; } 

        [JsonProperty("ai_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiPreview { get; set; } 

        [JsonProperty("ai_improve_agent_note_default_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiImproveAgentNoteDefaultOn { get; set; } 

        [JsonProperty("defaultcommunicationmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCommunicationmethod { get; set; } 

        [JsonProperty("newaction_thirdpartynhdservicenowsupplierid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionThirdPartyNhdservicenowsupplierid { get; set; } 

        [JsonProperty("related_note_visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RelatedNoteVisibility { get; set; } 

        [JsonProperty("override_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverrideFromMailboxId { get; set; } 

        [JsonProperty("override_from_mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideFromMailboxName { get; set; } 

        [JsonProperty("create_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateIssueType { get; set; } 

        [JsonProperty("show_when_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowWhenLocked { get; set; } 

        [JsonProperty("showsendgooglebusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendgooglebusiness { get; set; } 

        [JsonProperty("submitlabeloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Submitlabeloverride { get; set; } 

        [JsonProperty("default_send_jira_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSendJiraNote { get; set; } 

        [JsonProperty("config_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigType { get; set; } 

        [JsonProperty("show_on_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ShowOnParent { get; set; } 

        [JsonProperty("show_on_child", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ShowOnChild { get; set; } 

        [JsonProperty("newactiondisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActiondisplay { get; set; } 

        [JsonProperty("newactiondisplaysize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActiondisplaysize { get; set; } 

        [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeDefaultInstallation { get; set; } 

        [JsonProperty("lapsafe_default_installation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeDefaultInstallationName { get; set; } 

        [JsonProperty("lapsafe_default_installation_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? LapsafeDefaultInstallationObj { get; set; } 

        [JsonProperty("hide_header_button", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideHeaderButton { get; set; } 

        [JsonProperty("charge_rate_overrides_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeRateOverridesTicket { get; set; } 

        [JsonProperty("linked_from_variable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LinkedFromVariable { get; set; } 

        [JsonProperty("default_team_to_agents_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultTeamToAgentsDefault { get; set; } 

        [JsonProperty("do_not_allow_with_open_appointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotAllowWithOpenAppointments { get; set; } 

        [JsonProperty("new_ticket_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewTicketAttachments { get; set; } 

        [JsonProperty("run_ai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunAiInsights { get; set; } 

        [JsonProperty("sales_mailbox_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesMailboxOverrideId { get; set; } 

        [JsonProperty("hide_user_visibility_toggle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideUserVisibilityToggle { get; set; } 

        [JsonProperty("email_editing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailEditing { get; set; } 

        [JsonProperty("default_distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultDistributionList { get; set; } 

        [JsonProperty("default_distribution_list_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultDistributionListName { get; set; } 

    }