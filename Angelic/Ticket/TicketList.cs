using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Ticket;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class TicketList
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("dateoccurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateoccurred { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StatusName { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TickettypeName { get; set; } 

        [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaId { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaName { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PriorityId { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentName { get; set; } 

        [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1 { get; set; } 

        [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2 { get; set; } 

        [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3 { get; set; } 

        [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4 { get; set; } 

        [JsonProperty("categoryid_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid1 { get; set; } 

        [JsonProperty("categoryid_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid2 { get; set; } 

        [JsonProperty("categoryid_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid3 { get; set; } 

        [JsonProperty("categoryid_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Categoryid4 { get; set; } 

        [JsonProperty("category_1_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1Display { get; set; } 

        [JsonProperty("category_2_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2Display { get; set; } 

        [JsonProperty("category_3_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3Display { get; set; } 

        [JsonProperty("category_4_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4Display { get; set; } 

        [JsonProperty("estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimate { get; set; } 

        [JsonProperty("estimatedays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Estimatedays { get; set; } 

        [JsonProperty("projecttimepercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimepercentage { get; set; } 

        [JsonProperty("projectcompletionpercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectcompletionpercentage { get; set; } 

        [JsonProperty("projectearlieststart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectearlieststart { get; set; } 

        [JsonProperty("projectlatestend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectlatestend { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Timetaken { get; set; } 

        [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargehours { get; set; } 

        [JsonProperty("nonchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Nonchargehours { get; set; } 

        [JsonProperty("travelhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Travelhours { get; set; } 

        [JsonProperty("totalmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalmileage { get; set; } 

        [JsonProperty("itemsprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Itemsprice { get; set; } 

        [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Items { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierName { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildCount { get; set; } 

        [JsonProperty("child_count_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildCountOpen { get; set; } 

        [JsonProperty("attachment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentCount { get; set; } 

        [JsonProperty("flagged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flagged { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("enduserstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enduserstatus { get; set; } 

        [JsonProperty("onhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onhold { get; set; } 

        [JsonProperty("respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Respondbydate { get; set; } 

        [JsonProperty("responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Responsedate { get; set; } 

        [JsonProperty("first_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstResponsedate { get; set; } 

        [JsonProperty("responsestartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Responsestartdate { get; set; } 

        [JsonProperty("slaresponsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaresponsestate { get; set; } 

        [JsonProperty("fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Fixbydate { get; set; } 

        [JsonProperty("dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateclosed { get; set; } 

        [JsonProperty("dateassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateassigned { get; set; } 

        [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefromsla { get; set; } 

        [JsonProperty("slaholdtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slaholdtime { get; set; } 

        [JsonProperty("site_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteTimezone { get; set; } 

        [JsonProperty("parentguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parentguid { get; set; } 

        [JsonProperty("parentassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Parentassign { get; set; } 

        [JsonProperty("slaactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Slaactiondate { get; set; } 

        [JsonProperty("slapercused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slapercused { get; set; } 

        [JsonProperty("slatimeleft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeleft { get; set; } 

        [JsonProperty("currentelapsedhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currentelapsedhours { get; set; } 

        [JsonProperty("lastactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastactiondate { get; set; } 

        [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdate { get; set; } 

        [JsonProperty("lastchildactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastchildactiondate { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrganisationId { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DepartmentId { get; set; } 

        [JsonProperty("reportedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reportedby { get; set; } 

        [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserEmail { get; set; } 

        [JsonProperty("emailtolist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtolist { get; set; } 

        [JsonProperty("emailtolistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtolistsupplier { get; set; } 

        [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcclist { get; set; } 

        [JsonProperty("emailcclistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailcclistsupplier { get; set; } 

        [JsonProperty("matched_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchedKbId { get; set; } 

        [JsonProperty("release_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReleaseNote { get; set; } 

        [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; } 

        [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProductName { get; set; } 

        [JsonProperty("release_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId { get; set; } 

        [JsonProperty("release_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReleaseName { get; set; } 

        [JsonProperty("release2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release2Id { get; set; } 

        [JsonProperty("release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release2Name { get; set; } 

        [JsonProperty("release3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release3Id { get; set; } 

        [JsonProperty("release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release3Name { get; set; } 

        [JsonProperty("child_ticket_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildTicketIdString { get; set; } 

        [JsonProperty("asset_key_field_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetKeyFieldString { get; set; } 

        [JsonProperty("asset_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetTypeName { get; set; } 

        [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowName { get; set; } 

        [JsonProperty("workflow_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowStage { get; set; } 

        [JsonProperty("workflow_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowStageId { get; set; } 

        [JsonProperty("workflow_stage_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowStageNumber { get; set; } 

        [JsonProperty("lastincomingemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastincomingemail { get; set; } 

        [JsonProperty("child_ticket_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? ChildTicketIds { get; set; } 

        [JsonProperty("nextactivitydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextactivitydate { get; set; } 

        [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InventoryNumber { get; set; } 

        [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowId { get; set; } 

        [JsonProperty("workflow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowStep { get; set; } 

        [JsonProperty("workflow_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowSeq { get; set; } 

        [JsonProperty("pipeline_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PipelineStageId { get; set; } 

        [JsonProperty("pipeline_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PipelineStageName { get; set; } 

        [JsonProperty("hasbeenclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasbeenclosed { get; set; } 

        [JsonProperty("unread_child_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UnreadChildActionCount { get; set; } 

        [JsonProperty("unread_related_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UnreadRelatedActionCount { get; set; } 

        [JsonProperty("child_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildActionCount { get; set; } 

        [JsonProperty("parent_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentSubject { get; set; } 

        [JsonProperty("related_action_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RelatedActionCount { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVip { get; set; } 

        [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impact { get; set; } 

        [JsonProperty("urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Urgency { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StartdateTimezone { get; set; } 

        [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? StartdateWithTimezone { get; set; } 

        [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Starttime { get; set; } 

        [JsonProperty("starttimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Starttimeslot { get; set; } 

        [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Targetdate { get; set; } 

        [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TargetdateTimezone { get; set; } 

        [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? TargetdateWithTimezone { get; set; } 

        [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Targettime { get; set; } 

        [JsonProperty("targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Targettimeslot { get; set; } 

        [JsonProperty("deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Deadlinedate { get; set; } 

        [JsonProperty("followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Followupdate { get; set; } 

        [JsonProperty("oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcontactname { get; set; } 

        [JsonProperty("oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcompanyname { get; set; } 

        [JsonProperty("oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppemailaddress { get; set; } 

        [JsonProperty("oppcustomertitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcustomertitle { get; set; } 

        [JsonProperty("opptel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptel { get; set; } 

        [JsonProperty("oppaddr1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr1 { get; set; } 

        [JsonProperty("oppaddr2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr2 { get; set; } 

        [JsonProperty("oppaddr3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr3 { get; set; } 

        [JsonProperty("oppaddr4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppaddr4 { get; set; } 

        [JsonProperty("opppostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opppostcode { get; set; } 

        [JsonProperty("oppcountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcountry { get; set; } 

        [JsonProperty("oppregion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppregion { get; set; } 

        [JsonProperty("opptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptype { get; set; } 

        [JsonProperty("oppvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalue { get; set; } 

        [JsonProperty("oppvalue_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppvalueMonthly { get; set; } 

        [JsonProperty("oppvalue_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppvalueAnnual { get; set; } 

        [JsonProperty("oppvalue_oneoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppvalueOneoff { get; set; } 

        [JsonProperty("oppconversionprobability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppconversionprobability { get; set; } 

        [JsonProperty("oppvalueadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppvalueadjusted { get; set; } 

        [JsonProperty("oppprofit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Oppprofit { get; set; } 

        [JsonProperty("oppcurrentsystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcurrentsystem { get; set; } 

        [JsonProperty("oppcompetitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcompetitors { get; set; } 

        [JsonProperty("opptrialdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Opptrialdate { get; set; } 

        [JsonProperty("oppdemodate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppdemodate { get; set; } 

        [JsonProperty("oppdiscountdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppdiscountdate { get; set; } 

        [JsonProperty("oppattemptsmade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppattemptsmade { get; set; } 

        [JsonProperty("oppconverteddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Oppconverteddate { get; set; } 

        [JsonProperty("oppproductchosen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppproductchosen { get; set; } 

        [JsonProperty("oppreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppreason { get; set; } 

        [JsonProperty("opphear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opphear { get; set; } 

        [JsonProperty("opptimezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opptimezonename { get; set; } 

        [JsonProperty("oppclosurecategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppclosurecategory { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; } 

        [JsonProperty("projecttimebudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimebudget { get; set; } 

        [JsonProperty("projectmoneybudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectmoneybudget { get; set; } 

        [JsonProperty("projecttimeactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimeactual { get; set; } 

        [JsonProperty("projectmoneyactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectmoneyactual { get; set; } 

        [JsonProperty("lastnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastnote { get; set; } 

        [JsonProperty("userdef1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef1 { get; set; } 

        [JsonProperty("userdef2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef2 { get; set; } 

        [JsonProperty("userdef3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef3 { get; set; } 

        [JsonProperty("userdef4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef4 { get; set; } 

        [JsonProperty("userdef5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdef5 { get; set; } 

        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Source { get; set; } 

        [JsonProperty("release_important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleaseImportant { get; set; } 

        [JsonProperty("releasenotegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReleasenotegroupName { get; set; } 

        [JsonProperty("releasenotegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleasenotegroupId { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ThirdPartyId { get; set; } 

        [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyIdString { get; set; } 

        [JsonProperty("supplier_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierStatus { get; set; } 

        [JsonProperty("contract_refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractRefextra { get; set; } 

        [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentType { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("timeentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTimeEntry>? Timeentries { get; set; } 

        [JsonProperty("section_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SectionTimezone { get; set; } 

        [JsonProperty("itilname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itilname { get; set; } 

        [JsonProperty("related_service_descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RelatedServiceDescriptions { get; set; } 

        [JsonProperty("related_service_category_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RelatedServiceCategoryNames { get; set; } 

        [JsonProperty("projectinternaltask", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Projectinternaltask { get; set; } 

        [JsonProperty("appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentId { get; set; } 

        [JsonProperty("nextappointmentdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextappointmentdate { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstname { get; set; } 

        [JsonProperty("lastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastname { get; set; } 

        [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectedinstanceId { get; set; } 

        [JsonProperty("web_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebUrl { get; set; } 

        [JsonProperty("api_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiUrl { get; set; } 

        [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionNumber { get; set; } 

        [JsonProperty("action_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionTicketId { get; set; } 

        [JsonProperty("action_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActionDatetime { get; set; } 

        [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionOutcome { get; set; } 

        [JsonProperty("action_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionChargerate { get; set; } 

        [JsonProperty("action_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionContractRef { get; set; } 

        [JsonProperty("action_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionNote { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInvoicesForEachSite { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesorderId { get; set; } 

        [JsonProperty("orderhead_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderheadId { get; set; } 

        [JsonProperty("budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgettype { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequesttypeName { get; set; } 

        [JsonProperty("recalculate_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecalculateBilling { get; set; } 

        [JsonProperty("impactlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impactlevel { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; } 

        [JsonProperty("pr_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrId { get; set; } 

        [JsonProperty("branch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BranchId { get; set; } 

        [JsonProperty("branch_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BranchName { get; set; } 

        [JsonProperty("update_milestone_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateMilestoneId { get; set; } 

        [JsonProperty("milestone_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneId { get; set; } 

        [JsonProperty("milestone_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MilestoneName { get; set; } 

        [JsonProperty("milestone_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MilestoneValue { get; set; } 

        [JsonProperty("milestone_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneSequence { get; set; } 

        [JsonProperty("milestone_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneStatus { get; set; } 

        [JsonProperty("milestone_startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MilestoneStartdate { get; set; } 

        [JsonProperty("milestone_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MilestoneEnddate { get; set; } 

        [JsonProperty("email_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailMessageId { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewed { get; set; } 

        [JsonProperty("action_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionAgentName { get; set; } 

        [JsonProperty("merged_into_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MergedIntoId { get; set; } 

        [JsonProperty("reassigncount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reassigncount { get; set; } 

        [JsonProperty("parent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentStatus { get; set; } 

        [JsonProperty("parent_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentAgent { get; set; } 

        [JsonProperty("child_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildStatus { get; set; } 

        [JsonProperty("date_fully_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateFullyClosed { get; set; } 

        [JsonProperty("lastaction_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastactionChargerate { get; set; } 

        [JsonProperty("hover_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HoverSummary { get; set; } 

        [JsonProperty("slatimeelapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Slatimeelapsed { get; set; } 

        [JsonProperty("ai_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSummary { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchScore { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("canbevotedfor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canbevotedfor { get; set; } 

        [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierReference { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TopLevelName { get; set; } 

        [JsonProperty("isbeingclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isbeingclosed { get; set; } 

        [JsonProperty("maximumRestrictedPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumRestrictedPriority { get; set; } 

        [JsonProperty("primary_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrimaryServiceName { get; set; } 

        [JsonProperty("idsummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Idsummary { get; set; } 

        [JsonProperty("scomclearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomclearance { get; set; } 

        [JsonProperty("scomalertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomalertid { get; set; } 

        [JsonProperty("statusseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statusseq { get; set; } 

        [JsonProperty("statuscolor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Statuscolor { get; set; } 

        [JsonProperty("next_appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextAppointmentType { get; set; } 

        [JsonProperty("account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountManager { get; set; } 

        [JsonProperty("orionalert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalert { get; set; } 

        [JsonProperty("orionnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionnote { get; set; } 

        [JsonProperty("orionwho", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionwho { get; set; } 

        [JsonProperty("product_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProductKey { get; set; } 

        [JsonProperty("ticketage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Ticketage { get; set; } 

        [JsonProperty("ninja_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaId { get; set; } 

        [JsonProperty("teams_ticket_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsTicketIcon { get; set; } 

        [JsonProperty("lastactiondateteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastactiondateteams { get; set; } 

        [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PriorityName { get; set; } 

        [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UsefulCount { get; set; } 

        [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NotusefulCount { get; set; } 

        [JsonProperty("sitepostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitepostcode { get; set; } 

        [JsonProperty("mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailbox { get; set; } 

        [JsonProperty("userdepartments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdepartments { get; set; } 

        [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateservicestatus { get; set; } 

        [JsonProperty("servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicestatusnote { get; set; } 

        [JsonProperty("itil_requesttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItilRequesttypeId { get; set; } 

        [JsonProperty("startdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdatetime { get; set; } 

        [JsonProperty("enddatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddatetime { get; set; } 

        [JsonProperty("closure_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosureAgentId { get; set; } 

        [JsonProperty("closed_in_integration_system", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClosedInIntegrationSystem { get; set; } 

        [JsonProperty("newrelic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicId { get; set; } 

        [JsonProperty("createdfromautomationstdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createdfromautomationstdid { get; set; } 

        [JsonProperty("ticket_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketTags { get; set; } 

        [JsonProperty("status_change_frozen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StatusChangeFrozen { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalStatus { get; set; } 

        [JsonProperty("opp_country_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCountryName { get; set; } 

        [JsonProperty("opp_region_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppRegionName { get; set; } 

        [JsonProperty("invoiceseperatelyoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceseperatelyoverride { get; set; } 

        [JsonProperty("purchaseordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchaseordernumber { get; set; } 

        [JsonProperty("overrideticketcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Overrideticketcost { get; set; } 

        [JsonProperty("budgethours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Budgethours { get; set; } 

        [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedBy { get; set; } 

        [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketAdditionalAgents>? AdditionalAgents { get; set; } 

        [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientToInvoiceToId { get; set; } 

        [JsonProperty("primary_issue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? PrimaryIssue { get; set; } 

        [JsonProperty("primary_workitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? PrimaryWorkitem { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPlanText { get; set; } 

        [JsonProperty("default_appointment_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAppointmentSummary { get; set; } 

        [JsonProperty("default_appointment_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAppointmentDetails { get; set; } 

        [JsonProperty("agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentSignature { get; set; } 

        [JsonProperty("customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerSignature { get; set; } 

        [JsonProperty("new_agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAgentSignature { get; set; } 

        [JsonProperty("new_customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCustomerSignature { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketClientToInvoiceToId { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? NewExternalLink { get; set; } 

    }