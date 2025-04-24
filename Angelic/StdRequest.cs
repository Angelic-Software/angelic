using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StdRequest
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
    public int? Group_id { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restriction_type { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_department_id { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_department_name { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_team_id { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_team_name { get; set; } 

    [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_agent_id { get; set; } 

    [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_agent_name { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_count { get; set; } 

    [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestRule>? Creation_rules { get; set; } 

    [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<STDToDo>? Todo_list { get; set; } 

    [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailto { get; set; } 

    [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailcc { get; set; } 

    [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbcc { get; set; } 

    [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubject { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate { get; set; } 

    [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate_after_end { get; set; } 

    [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Execution_type { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_locked { get; set; } 

    [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? One_ticket_id { get; set; } 

    [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Created_ticket_id { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_id { get; set; } 

    [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportarea { get; set; } 

    [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reportarea_name { get; set; } 

    [JsonProperty("users_can_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Users_can_use { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority_id { get; set; } 

    [JsonProperty("estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Estimate { get; set; } 

    [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_1 { get; set; } 

    [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_2 { get; set; } 

    [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_3 { get; set; } 

    [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_4 { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status_id { get; set; } 

    [JsonProperty("status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Status_guid { get; set; } 

    [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details { get; set; } 

    [JsonProperty("details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details_html { get; set; } 

    [JsonProperty("clearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clearance { get; set; } 

    [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workflow_id { get; set; } 

    [JsonProperty("workflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Workflow_guid { get; set; } 

    [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Workflow_name { get; set; } 

    [JsonProperty("approval_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approval_name { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showforusers { get; set; } 

    [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Excludefromsla { get; set; } 

    [JsonProperty("defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultresourcetype { get; set; } 

    [JsonProperty("defaultresourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultresourcetype_name { get; set; } 

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
    public bool? _clearlastrun { get; set; } 

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
    public int? Toplevel { get; set; } 

    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Report_id { get; set; } 

    [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbody { get; set; } 

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
    public bool? Promptproceed { get; set; } 

    [JsonProperty("pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pdf { get; set; } 

    [JsonProperty("sendifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendifempty { get; set; } 

    [JsonProperty("copied_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Copied_from_id { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Assets { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; } 

    [JsonProperty("itil_request_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itil_request_type { get; set; } 

    [JsonProperty("create_on_nonworkdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_on_nonworkdays { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_id { get; set; } 

    [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_id { get; set; } 

    [JsonProperty("creationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creationtype { get; set; } 

    [JsonProperty("parentticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentticketid { get; set; } 

    [JsonProperty("kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kb_id { get; set; } 

    [JsonProperty("kb_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kb_name { get; set; } 

    [JsonProperty("kb_accessible_for_enduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Kb_accessible_for_enduser { get; set; } 

    [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forwardinboundupdates { get; set; } 

    [JsonProperty("enable_budget_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_budget_table { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<STDrequestbudget>? Budgets { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgettype_id { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Budgettype_name { get; set; } 

    [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailcclist { get; set; } 

    [JsonProperty("services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServSite_List>? Services { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _canupdate { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("updateparent_status_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Updateparent_status_close { get; set; } 

    [JsonProperty("updateparent_target_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Updateparent_target_create { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("clone_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clone_parent_id { get; set; } 

    [JsonProperty("increasecontractnextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Increasecontractnextcalldate { get; set; } 

    [JsonProperty("makeinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Makeinactive { get; set; } 

    [JsonProperty("_queue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _queue { get; set; } 

    [JsonProperty("_sendnow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _sendnow { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("automationcriteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutoassignCriteria>? Automationcriteria { get; set; } 

    [JsonProperty("isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isclone { get; set; } 

    [JsonProperty("showforusers_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Showforusers_int { get; set; } 

    [JsonProperty("forwardinboundupdates_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Forwardinboundupdates_int { get; set; } 

    [JsonProperty("excludefromsla_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Excludefromsla_int { get; set; } 

    [JsonProperty("start_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Start_num_days_added { get; set; } 

    [JsonProperty("target_num_days_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Target_num_days_added { get; set; } 

    [JsonProperty("milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MileStone>? Milestones { get; set; } 

    [JsonProperty("sqltoselectusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sqltoselectusers { get; set; } 

    [JsonProperty("usersqllookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Usersqllookup { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notification_id { get; set; } 

    [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaultAdditionalAgents>? Additional_agents { get; set; } 

    [JsonProperty("new_audits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Audit>? New_audits { get; set; } 

    [JsonProperty("new_changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceChange>? New_changes { get; set; } 

    [JsonProperty("child_count_of_ticket_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Child_count_of_ticket_to_save { get; set; } 

    [JsonProperty("ticket_id_to_save", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id_to_save { get; set; } 

    [JsonProperty("create_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_child_templates { get; set; } 

    [JsonProperty("ticket_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_template { get; set; } 

    [JsonProperty("ticket_template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Ticket_template_guid { get; set; } 

    [JsonProperty("ticket_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_template_name { get; set; } 

    [JsonProperty("enable_task_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_task_dependencies { get; set; } 

    [JsonProperty("date_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdrequestDateDependencies>? Date_dependencies { get; set; } 

    [JsonProperty("upload_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Upload_type { get; set; } 

    [JsonProperty("integration_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_details_id { get; set; } 

    [JsonProperty("integration_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_details_name { get; set; } 

    [JsonProperty("integration_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_mapping { get; set; } 

    [JsonProperty("integration_mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_mapping_name { get; set; } 

    [JsonProperty("integration_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_folder { get; set; } 

    [JsonProperty("overwrite_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Overwrite_files { get; set; } 

    [JsonProperty("create_for_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Create_for_user_type { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sla_id { get; set; } 

    [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Restrictto_department_guid { get; set; } 

    [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Restrictto_team_guid { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clients { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Tickettype_guid { get; set; } 

    [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automationtype { get; set; } 

    [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optionalservice { get; set; } 

    [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_agent_id { get; set; } 

    [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_team { get; set; } 

    [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_status_id { get; set; } 

    [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_tickettype_id { get; set; } 

    [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional_create_locked { get; set; } 

    [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_defaultresourcetype { get; set; } 

    [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_excludefromsla { get; set; } 

    [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Optional_customfields { get; set; } 

    [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Optional_assets { get; set; } 

    [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_forwardinboundupdates { get; set; } 

    [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_showforusers { get; set; } 

    [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_urgency { get; set; } 

    [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_impact { get; set; } 

    [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_workflow_id { get; set; } 

    [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Optional_estimate { get; set; } 

    [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_1 { get; set; } 

    [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_2 { get; set; } 

    [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_3 { get; set; } 

    [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_4 { get; set; } 

    [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_priority_id { get; set; } 

    [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_budgettype_id { get; set; } 

    [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_kb_id { get; set; } 

    [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_service { get; set; } 

    [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_service_details_id { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_sla_id { get; set; } 

}