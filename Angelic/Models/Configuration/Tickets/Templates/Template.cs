using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Auditing;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.Configuration.Tickets.TicketRule;
using Angelic.Models.Invoice;
using Angelic.Models.Milestones;
using Angelic.Models.Tickets;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Templates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Template
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictionType { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoDepartmentId { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoDepartmentName { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoTeamId { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoTeamName { get; set; } 

    [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoAgentId { get; set; } 

    [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoAgentName { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleCount { get; set; } 

    [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateRule>? CreationRules { get; set; } 

    [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateToDo>? TodoList { get; set; } 

    [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTo { get; set; } 

    [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCc { get; set; } 

    [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBcc { get; set; } 

    [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubject { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCreationdate { get; set; } 

    [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCreationdateAfterEnd { get; set; } 

    [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExecutionType { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateLocked { get; set; } 

    [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OneTicketId { get; set; } 

    [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedTicketId { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalId { get; set; } 

    [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportarea { get; set; } 

    [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportareaName { get; set; } 

    [JsonProperty("users_can_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UsersCanUse { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Estimate { get; set; } 

    [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusId { get; set; } 

    [JsonProperty("status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusGuid { get; set; } 

    [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details { get; set; } 

    [JsonProperty("details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DetailsHtml { get; set; } 

    [JsonProperty("clearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clearance { get; set; } 

    [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowId { get; set; } 

    [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkflowGuid { get; set; } 

    [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkflowName { get; set; } 

    [JsonProperty("approval_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalName { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowForUsers { get; set; } 

    [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeFromSla { get; set; } 

    [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultResourcetype { get; set; } 

    [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultResourcetypeName { get; set; } 

    [JsonProperty("informlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Informlevel { get; set; } 

    [JsonProperty("scheduletype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Scheduletype { get; set; } 

    [JsonProperty("dom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dom { get; set; } 

    [JsonProperty("mon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mon { get; set; } 

    [JsonProperty("tue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tue { get; set; } 

    [JsonProperty("wed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wed { get; set; } 

    [JsonProperty("thu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Thu { get; set; } 

    [JsonProperty("fri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fri { get; set; } 

    [JsonProperty("sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sat { get; set; } 

    [JsonProperty("sun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sun { get; set; } 

    [JsonProperty("year", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Year { get; set; } 

    [JsonProperty("_clearlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Clearlastrun { get; set; } 

    [JsonProperty("daysplus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Daysplus { get; set; } 

    [JsonProperty("every", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Every { get; set; } 

    [JsonProperty("reportid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportid { get; set; } 

    [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Impact { get; set; } 

    [JsonProperty("urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Urgency { get; set; } 

    [JsonProperty("reportperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportperiod { get; set; } 

    [JsonProperty("reportsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportsite { get; set; } 

    [JsonProperty("repeat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Repeat { get; set; } 

    [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevel { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; } 

    [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBody { get; set; } 

    [JsonProperty("kbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kbid { get; set; } 

    [JsonProperty("did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Did { get; set; } 

    [JsonProperty("yeargapvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Yeargapvalue { get; set; } 

    [JsonProperty("graph", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Graph { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Table { get; set; } 

    [JsonProperty("csv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Csv { get; set; } 

    [JsonProperty("json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Json { get; set; } 

    [JsonProperty("prompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prompt { get; set; } 

    [JsonProperty("promptproceed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PromptProceed { get; set; } 

    [JsonProperty("pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pdf { get; set; } 

    [JsonProperty("sendifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendIfEmpty { get; set; } 

    [JsonProperty("copied_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CopiedFromId { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? Assets { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; } 

    [JsonProperty("itil_request_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequestType { get; set; } 

    [JsonProperty("create_on_nonworkdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateOnNonworkdays { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookId { get; set; } 

    [JsonProperty("creationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creationtype { get; set; } 

    [JsonProperty("parentticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentticketid { get; set; } 

    [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbId { get; set; } 

    [JsonProperty("kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KbName { get; set; } 

    [JsonProperty("kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? KbAccessibleForEndUser { get; set; } 

    [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forwardinboundupdates { get; set; } 

    [JsonProperty("enable_budget_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableBudgetTable { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateBudget>? Budgets { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BudgetTypeId { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BudgetTypeName { get; set; } 

    [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCclist { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSiteList>? Services { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("updateparent_status_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UpdateparentStatusClose { get; set; } 

    [JsonProperty("updateparent_target_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UpdateparentTargetCreate { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("clone_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CloneParentId { get; set; } 

    [JsonProperty("increasecontractnextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Increasecontractnextcalldate { get; set; } 

    [JsonProperty("makeinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Makeinactive { get; set; } 

    [JsonProperty("_queue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Queue { get; set; } 

    [JsonProperty("_sendnow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendnow { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("automationcriteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? Automationcriteria { get; set; } 

    [JsonProperty("isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsClone { get; set; } 

    [JsonProperty("showforusers_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowForUsersInt { get; set; } 

    [JsonProperty("forwardinboundupdates_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ForwardinboundupdatesInt { get; set; } 

    [JsonProperty("excludefromsla_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExcludeFromSlaInt { get; set; } 

    [JsonProperty("start_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartNumDaysAdded { get; set; } 

    [JsonProperty("target_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetNumDaysAdded { get; set; } 

    [JsonProperty("milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Milestone>? Milestones { get; set; } 

    [JsonProperty("sqltoselectusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sqltoselectusers { get; set; } 

    [JsonProperty("usersqllookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Usersqllookup { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotificationId { get; set; } 

    [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketAdditionalAgents>? AdditionalAgents { get; set; } 

    [JsonProperty("new_audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Audit>? NewAudits { get; set; } 

    [JsonProperty("new_changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceChange>? NewChanges { get; set; } 

    [JsonProperty("child_count_of_ticket_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildCountOfTicketToSave { get; set; } 

    [JsonProperty("ticket_id_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketIdToSave { get; set; } 

    [JsonProperty("create_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateChildTemplates { get; set; } 

    [JsonProperty("ticket_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTemplate { get; set; } 

    [JsonProperty("ticket_template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TicketTemplateGuid { get; set; } 

    [JsonProperty("ticket_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTemplateName { get; set; } 

    [JsonProperty("enable_task_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTaskDependencies { get; set; } 

    [JsonProperty("date_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateDateDependencies>? DateDependencies { get; set; } 

    [JsonProperty("upload_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UploadType { get; set; } 

    [JsonProperty("integration_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationDetailsId { get; set; } 

    [JsonProperty("integration_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationDetailsName { get; set; } 

    [JsonProperty("integration_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMapping { get; set; } 

    [JsonProperty("integration_mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMappingName { get; set; } 

    [JsonProperty("integration_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationFolder { get; set; } 

    [JsonProperty("overwrite_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverwriteFiles { get; set; } 

    [JsonProperty("create_for_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateForUserType { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestricttoDepartmentGuid { get; set; } 

    [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestricttoTeamGuid { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clients { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TicketTypeGuid { get; set; } 

    [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automationtype { get; set; } 

    [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optionalservice { get; set; } 

    [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalAgentId { get; set; } 

    [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalTeam { get; set; } 

    [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalStatusId { get; set; } 

    [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalTicketTypeId { get; set; } 

    [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OptionalCreateLocked { get; set; } 

    [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalDefaultResourcetype { get; set; } 

    [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalExcludeFromSla { get; set; } 

    [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? OptionalCustomFields { get; set; } 

    [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? OptionalAssets { get; set; } 

    [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalForwardinboundupdates { get; set; } 

    [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalShowForUsers { get; set; } 

    [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalUrgency { get; set; } 

    [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalImpact { get; set; } 

    [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalWorkflowId { get; set; } 

    [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OptionalEstimate { get; set; } 

    [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory1 { get; set; } 

    [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory2 { get; set; } 

    [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory3 { get; set; } 

    [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory4 { get; set; } 

    [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalPriorityId { get; set; } 

    [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalBudgetTypeId { get; set; } 

    [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalKbId { get; set; } 

    [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalService { get; set; } 

    [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalServiceDetailsId { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalSlaId { get; set; } 

}