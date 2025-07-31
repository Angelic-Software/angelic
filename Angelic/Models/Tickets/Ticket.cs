using System.CodeDom.Compiler;
using Angelic.Models.Appointments;
using Angelic.Models.Assets;
using Angelic.Models.Attachments;
using Angelic.Models.Auditing;
using Angelic.Models.Clients;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Ai;
using Angelic.Models.Configuration.Billing;
using Angelic.Models.Configuration.Billing.Prepay;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Integrations.Freshdesk;
using Angelic.Models.Configuration.Integrations.Google;
using Angelic.Models.Configuration.Integrations.Lookups;
using Angelic.Models.Configuration.TeamsAndAgents.QualificationMatching;
using Angelic.Models.Configuration.Tickets;
using Angelic.Models.Configuration.Tickets.Slas;
using Angelic.Models.Configuration.Tickets.Views;
using Angelic.Models.Configuration.Tickets.Workflows;
using Angelic.Models.EcommerceOrders;
using Angelic.Models.ExternalLinks;
using Angelic.Models.KeyPairs;
using Angelic.Models.Milestones;
using Newtonsoft.Json;

namespace Angelic.Models.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Ticket {
        [JsonProperty("oppjobtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppJobTitle { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("dateoccurred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOccurred { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StatusName { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketTypeId { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketTypeName { get; set; } 

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
        public int? CategoryId1 { get; set; } 

        [JsonProperty("categoryid_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId2 { get; set; } 

        [JsonProperty("categoryid_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId3 { get; set; } 

        [JsonProperty("categoryid_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId4 { get; set; } 

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
        public double? EstimateDays { get; set; } 

        [JsonProperty("projecttimepercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projecttimepercentage { get; set; } 

        [JsonProperty("projectcompletionpercentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Projectcompletionpercentage { get; set; } 

        [JsonProperty("projectearlieststart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectearlieststart { get; set; } 

        [JsonProperty("projectlatestend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Projectlatestend { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? TimeTaken { get; set; } 

        [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ChargeHours { get; set; } 

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
        public int? EndUserstatus { get; set; } 

        [JsonProperty("onhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onhold { get; set; } 

        [JsonProperty("respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Respondbydate { get; set; } 

        [JsonProperty("responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ResponseDate { get; set; } 

        [JsonProperty("first_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FirstResponseDate { get; set; } 

        [JsonProperty("responsestartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ResponseStartDate { get; set; } 

        [JsonProperty("slaresponsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaResponseState { get; set; } 

        [JsonProperty("fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FixByDate { get; set; } 

        [JsonProperty("dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateClosed { get; set; } 

        [JsonProperty("dateassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateAssigned { get; set; } 

        [JsonProperty("excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFromSla { get; set; } 

        [JsonProperty("slaholdtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SlaHoldtime { get; set; } 

        [JsonProperty("site_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteTimeZone { get; set; } 

        [JsonProperty("parentguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentGuid { get; set; } 

        [JsonProperty("parentassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParentAssign { get; set; } 

        [JsonProperty("slaactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SlaActiondate { get; set; } 

        [JsonProperty("slapercused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SlaPercUsed { get; set; } 

        [JsonProperty("slatimeleft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SlaTimeleft { get; set; } 

        [JsonProperty("currentelapsedhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CurrentElapsedHours { get; set; } 

        [JsonProperty("lastactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastActiondate { get; set; } 

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
        public string? EmailToList { get; set; } 

        [JsonProperty("emailtolistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailToListsupplier { get; set; } 

        [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailCclist { get; set; } 

        [JsonProperty("emailcclistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailCclistsupplier { get; set; } 

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
        public DateTimeOffset? LastIncomingEmail { get; set; } 

        [JsonProperty("child_ticket_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? ChildTicketIds { get; set; } 

        [JsonProperty("nextactivitydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextActivitydate { get; set; } 

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
        public bool? IsImportantcontact { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Impact { get; set; } 

        [JsonProperty("urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Urgency { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StartDateTimeZone { get; set; } 

        [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? StartDateWithTimeZone { get; set; } 

        [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StartTime { get; set; } 

        [JsonProperty("starttimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTimeslot { get; set; } 

        [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TargetDate { get; set; } 

        [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TargetDateTimeZone { get; set; } 

        [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeZone? TargetDateWithTimeZone { get; set; } 

        [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TargetTime { get; set; } 

        [JsonProperty("targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetTimeslot { get; set; } 

        [JsonProperty("deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Deadlinedate { get; set; } 

        [JsonProperty("followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Followupdate { get; set; } 

        [JsonProperty("oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppContactName { get; set; } 

        [JsonProperty("oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCompanyName { get; set; } 

        [JsonProperty("oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppEmailAddress { get; set; } 

        [JsonProperty("oppcustomertitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCompanyTitle { get; set; } 

        [JsonProperty("opptel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppTel { get; set; } 

        [JsonProperty("oppaddr1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppAddr1 { get; set; } 

        [JsonProperty("oppaddr2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppAddr2 { get; set; } 

        [JsonProperty("oppaddr3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppAddr3 { get; set; } 

        [JsonProperty("oppaddr4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppAddr4 { get; set; } 

        [JsonProperty("opppostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppPostcode { get; set; } 

        [JsonProperty("oppcountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCountry { get; set; } 

        [JsonProperty("oppregion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppRegion { get; set; } 

        [JsonProperty("opptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppType { get; set; } 

        [JsonProperty("oppvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppValue { get; set; } 

        [JsonProperty("oppvalue_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppValueMonthly { get; set; } 

        [JsonProperty("oppvalue_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppValueAnnual { get; set; } 

        [JsonProperty("oppvalue_oneoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppValueOneOff { get; set; } 

        [JsonProperty("oppconversionprobability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppConversionprobability { get; set; } 

        [JsonProperty("oppvalueadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppValueadjusted { get; set; } 

        [JsonProperty("oppprofit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? OppProfit { get; set; } 

        [JsonProperty("oppcurrentsystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCurrentsystem { get; set; } 

        [JsonProperty("oppcompetitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppCompetitors { get; set; } 

        [JsonProperty("opptrialdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OppTrialDate { get; set; } 

        [JsonProperty("oppdemodate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OppDemoDate { get; set; } 

        [JsonProperty("oppdiscountdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OppDiscountDate { get; set; } 

        [JsonProperty("oppattemptsmade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OppAttemptsMade { get; set; } 

        [JsonProperty("oppconverteddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OppConvertedDate { get; set; } 

        [JsonProperty("oppproductchosen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppProductChosen { get; set; } 

        [JsonProperty("oppreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppReason { get; set; } 

        [JsonProperty("opphear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppHear { get; set; } 

        [JsonProperty("opptimezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OppTimeZoneName { get; set; } 

        [JsonProperty("oppclosurecategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OppClosureCategory { get; set; } 

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
        public string? UserDef1 { get; set; } 

        [JsonProperty("userdef2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDef2 { get; set; } 

        [JsonProperty("userdef3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDef3 { get; set; } 

        [JsonProperty("userdef4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDef4 { get; set; } 

        [JsonProperty("userdef5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDef5 { get; set; } 

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
        public ICollection<CustomField>? CustomFields { get; set; } 

        [JsonProperty("timeentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTimeEntry>? TimeEntries { get; set; } 

        [JsonProperty("section_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SectionTimeZone { get; set; } 

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
        public DateTimeOffset? NextAppointmentdate { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FirstName { get; set; } 

        [JsonProperty("lastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastName { get; set; } 

        [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectedInstanceId { get; set; } 

        [JsonProperty("web_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebUrl { get; set; } 

        [JsonProperty("api_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiUrl { get; set; } 

        [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionNumber { get; set; } 

        [JsonProperty("action_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionTicketId { get; set; } 

        [JsonProperty("action_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActionDateTime { get; set; } 

        [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionOutcome { get; set; } 

        [JsonProperty("action_chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionChargeRate { get; set; } 

        [JsonProperty("action_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionContractRef { get; set; } 

        [JsonProperty("action_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActionNote { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInvoicesForEachSite { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesOrderId { get; set; } 

        [JsonProperty("orderhead_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderHeadId { get; set; } 

        [JsonProperty("budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BudgetType { get; set; } 

        [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequestTypeName { get; set; } 

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
        public DateTimeOffset? MilestoneStartDate { get; set; } 

        [JsonProperty("milestone_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MilestoneEndDate { get; set; } 

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
        public string? LastActionChargeRate { get; set; } 

        [JsonProperty("hover_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HoverSummary { get; set; } 

        [JsonProperty("slatimeelapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SlaTimeelapsed { get; set; } 

        [JsonProperty("ai_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSummary { get; set; } 

        [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SearchScore { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } 

        [JsonProperty("details_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DetailsHtml { get; set; } 

        [JsonProperty("takenby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TakenBy { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreated { get; set; } 

        [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromId { get; set; } 

        [JsonProperty("createdfrom_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedFromSummary { get; set; } 

        [JsonProperty("clonedfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClonedFromId { get; set; } 

        [JsonProperty("clonedfrom_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClonedFromSummary { get; set; } 

        [JsonProperty("closure_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClosureNote { get; set; } 

        [JsonProperty("closure_note_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClosureNoteHtml { get; set; } 

        [JsonProperty("closure_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ClosureTime { get; set; } 

        [JsonProperty("top_level_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLevelId { get; set; } 

        [JsonProperty("customer_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerRelationships { get; set; } 

        [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetNumber { get; set; } 

        [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetSite { get; set; } 

        [JsonProperty("slastate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaState { get; set; } 

        [JsonProperty("slaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaExcuse { get; set; } 

        [JsonProperty("site_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteSlaId { get; set; } 

        [JsonProperty("client_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientReference { get; set; } 

        [JsonProperty("supplier_slaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierSlaExcuse { get; set; } 

        [JsonProperty("supplier_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SupplierDate { get; set; } 

        [JsonProperty("supplier_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierContractId { get; set; } 

        [JsonProperty("supplier_contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierContractRef { get; set; } 

        [JsonProperty("supplier_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierSlaId { get; set; } 

        [JsonProperty("supplier_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierPriorityId { get; set; } 

        [JsonProperty("supplier_responsestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierResponseState { get; set; } 

        [JsonProperty("supplier_responsedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SupplierResponseDate { get; set; } 

        [JsonProperty("supplier_responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SupplierResponseTime { get; set; } 

        [JsonProperty("supplier_respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SupplierRespondbydate { get; set; } 

        [JsonProperty("supplier_slastate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierSlaState { get; set; } 

        [JsonProperty("supplier_slatimeelapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SupplierSlaTimeelapsed { get; set; } 

        [JsonProperty("supplier_dateclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SupplierDateClosed { get; set; } 

        [JsonProperty("supplier_fixbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SupplierFixByDate { get; set; } 

        [JsonProperty("supplier_breachrespsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupplierBreachrespsent { get; set; } 

        [JsonProperty("supplier_breachfixbysent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupplierBreachfixbysent { get; set; } 

        [JsonProperty("changestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Changestate { get; set; } 

        [JsonProperty("approvedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovedBy { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowForUsers { get; set; } 

        [JsonProperty("messsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messsent { get; set; } 

        [JsonProperty("satisfactionlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SatisfactionLevel { get; set; } 

        [JsonProperty("satisfactioncomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SatisfactionComment { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InvoiceNumber { get; set; } 

        [JsonProperty("invoicenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InvoiceNote { get; set; } 

        [JsonProperty("invoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InvoiceDate { get; set; } 

        [JsonProperty("invoicepaiddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InvoicePaidDate { get; set; } 

        [JsonProperty("nonbillable_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NonbillableTime { get; set; } 

        [JsonProperty("mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Mileage { get; set; } 

        [JsonProperty("planneddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Planneddate { get; set; } 

        [JsonProperty("ccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ccaddress { get; set; } 

        [JsonProperty("agreedcleared", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agreedcleared { get; set; } 

        [JsonProperty("responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ResponseTime { get; set; } 

        [JsonProperty("first_responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? FirstResponseTime { get; set; } 

        [JsonProperty("alsoinform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alsoinform { get; set; } 

        [JsonProperty("justification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Justification { get; set; } 

        [JsonProperty("backoutplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Backoutplan { get; set; } 

        [JsonProperty("communicationplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Communicationplan { get; set; } 

        [JsonProperty("testplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Testplan { get; set; } 

        [JsonProperty("riskdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Riskdescription { get; set; } 

        [JsonProperty("risklevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Risklevel { get; set; } 

        [JsonProperty("impactdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Impactdescription { get; set; } 

        [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; } 

        [JsonProperty("isparentservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsParentservice { get; set; } 

        [JsonProperty("surveysent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surveysent { get; set; } 

        [JsonProperty("planneddateend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Planneddateend { get; set; } 

        [JsonProperty("currentfaactionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currentfaactionnumber { get; set; } 

        [JsonProperty("approval_process_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalProcessStep { get; set; } 

        [JsonProperty("approval_process_step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApprovalProcessStepName { get; set; } 

        [JsonProperty("approval_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApprovalCabName { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalProcessId { get; set; } 

        [JsonProperty("faultcodeopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultcodeopen { get; set; } 

        [JsonProperty("faultcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultcode { get; set; } 

        [JsonProperty("laststatus3rdparty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LastStatus3Rdparty { get; set; } 

        [JsonProperty("inform3rdpartysystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inform3Rdpartysystem { get; set; } 

        [JsonProperty("deliverycontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deliverycontact { get; set; } 

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Address? DeliveryAddress { get; set; } 

        [JsonProperty("surveyneeded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surveyneeded { get; set; } 

        [JsonProperty("knownerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Knownerror { get; set; } 

        [JsonProperty("development", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Development { get; set; } 

        [JsonProperty("causedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Causedby { get; set; } 

        [JsonProperty("messsentlast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Messsentlast { get; set; } 

        [JsonProperty("unapprovedchangestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unapprovedchangestatus { get; set; } 

        [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Changeseq { get; set; } 

        [JsonProperty("lastrecurringemailsentdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastRecurringemailsentdate { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TemplateId { get; set; } 

        [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TemplateName { get; set; } 

        [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildTemplateId { get; set; } 

        [JsonProperty("slaholdreminderdatelastemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SlaHoldreminderdatelastemailed { get; set; } 

        [JsonProperty("closurereminderdatelastemailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Closurereminderdatelastemailed { get; set; } 

        [JsonProperty("assetstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetstring { get; set; } 

        [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxid { get; set; } 

        [JsonProperty("alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alerttype { get; set; } 

        [JsonProperty("actisbillabledefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actisbillabledefault { get; set; } 

        [JsonProperty("emaildisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailDisplayName { get; set; } 

        [JsonProperty("emailpriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailPriority { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeRate { get; set; } 

        [JsonProperty("timezonename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TimeZoneName { get; set; } 

        [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardinboundupdates { get; set; } 

        [JsonProperty("loggedoutofhdworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loggedoutofhdworkinghours { get; set; } 

        [JsonProperty("acctmaninformedsurvey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Acctmaninformedsurvey { get; set; } 

        [JsonProperty("laststatuschangeinformed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LastStatuschangeinformed { get; set; } 

        [JsonProperty("gfialerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gfialerttype { get; set; } 

        [JsonProperty("quotedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quotedescription { get; set; } 

        [JsonProperty("quotelabouramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotelabouramount { get; set; } 

        [JsonProperty("quotepriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotepriority { get; set; } 

        [JsonProperty("budgetcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgetcode { get; set; } 

        [JsonProperty("actualcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Actualcost { get; set; } 

        [JsonProperty("invoicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicestatus { get; set; } 

        [JsonProperty("invoicedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InvoiceDescription { get; set; } 

        [JsonProperty("invoicelabouramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? InvoiceLabouramount { get; set; } 

        [JsonProperty("invoicematerialsamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? InvoiceMaterialsamount { get; set; } 

        [JsonProperty("firsttimefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Firsttimefix { get; set; } 

        [JsonProperty("quotematerialsamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotematerialsamount { get; set; } 

        [JsonProperty("ukasaccredited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ukasaccredited { get; set; } 

        [JsonProperty("labno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Labno { get; set; } 

        [JsonProperty("twitterscreenname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twitterscreenname { get; set; } 

        [JsonProperty("twitterid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TwitterId { get; set; } 

        [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FacebookId { get; set; } 

        [JsonProperty("fixbydateadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixByDateadjusted { get; set; } 

        [JsonProperty("loggedonbehalfby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loggedonbehalfby { get; set; } 

        [JsonProperty("alternativecontactno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alternativecontactno { get; set; } 

        [JsonProperty("operationalserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Operationalserviceid { get; set; } 

        [JsonProperty("requestdetailsprinted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestDetailsprinted { get; set; } 

        [JsonProperty("serviceformprinted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceformprinted { get; set; } 

        [JsonProperty("auditstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auditstatus { get; set; } 

        [JsonProperty("auditunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auditunum { get; set; } 

        [JsonProperty("auditdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Auditdate { get; set; } 

        [JsonProperty("auditnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auditnote { get; set; } 

        [JsonProperty("auditfaileddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Auditfaileddate { get; set; } 

        [JsonProperty("auditfailednote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auditfailednote { get; set; } 

        [JsonProperty("userrequestedapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userrequestedapprover { get; set; } 

        [JsonProperty("oppdontaddtomailinglist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OppDontaddtomailinglist { get; set; } 

        [JsonProperty("sendprintrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendprintrequest { get; set; } 

        [JsonProperty("pagerdutyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyid { get; set; } 

        [JsonProperty("pagerdutyincidentidstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyincidentidstring { get; set; } 

        [JsonProperty("pagerdutystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutystatus { get; set; } 

        [JsonProperty("pagerdutyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyurl { get; set; } 

        [JsonProperty("pagerdutyincidentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyincidentid { get; set; } 

        [JsonProperty("opportunity_third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpportunityThirdPartyUrl { get; set; } 

        [JsonProperty("pr_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrLink { get; set; } 

        [JsonProperty("github_repository", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GithubRepository { get; set; } 

        [JsonProperty("component_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; } 

        [JsonProperty("component_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ComponentName { get; set; } 

        [JsonProperty("version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionId { get; set; } 

        [JsonProperty("version_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? VersionName { get; set; } 

        [JsonProperty("mailentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MailEntryId { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractRef { get; set; } 

        [JsonProperty("billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Address? BillingAddress { get; set; } 

        [JsonProperty("workflow_stepstarted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? WorkflowStepstarted { get; set; } 

        [JsonProperty("lessonslearned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lessonslearned { get; set; } 

        [JsonProperty("laststatuschangeinformedmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LastStatuschangeinformedmanager { get; set; } 

        [JsonProperty("lastbugzillasync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastbugzillasync { get; set; } 

        [JsonProperty("sapid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sapid { get; set; } 

        [JsonProperty("sapattachmentsuuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sapattachmentsuuid { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency { get; set; } 

        [JsonProperty("projectconsignmentheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Projectconsignmentheaderid { get; set; } 

        [JsonProperty("projectconsignmentdetailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Projectconsignmentdetailid { get; set; } 

        [JsonProperty("servicefailurestid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicefailurestid { get; set; } 

        [JsonProperty("hdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hdid { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("matched_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchedRuleId { get; set; } 

        [JsonProperty("matched_rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchedRuleName { get; set; } 

        [JsonProperty("matched_rule_dont_show_notification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchedRuleDontShowNotification { get; set; } 

        [JsonProperty("ignore_kb_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreKbMatch { get; set; } 

        [JsonProperty("deadlinenotificationhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deadlinenotificationhours { get; set; } 

        [JsonProperty("asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetType { get; set; } 

        [JsonProperty("showonroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnroadmap { get; set; } 

        [JsonProperty("roadmapnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Roadmapnote { get; set; } 

        [JsonProperty("phonenumberfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PhoneNumberfrom { get; set; } 

        [JsonProperty("addressfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addressfrom { get; set; } 

        [JsonProperty("changeinformation_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChangeinformationHtml { get; set; } 

        [JsonProperty("team_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamDepartmentId { get; set; } 

        [JsonProperty("sendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAck { get; set; } 

        [JsonProperty("newaction_emailfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActionEmailFrom { get; set; } 

        [JsonProperty("newaction_emailfrom_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewActionEmailFromAddressOverride { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; } 

        [JsonProperty("_mustupdateticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustupdateticketuser { get; set; } 

        [JsonProperty("_spam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spam { get; set; } 

        [JsonProperty("_spamblock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Spamblock { get; set; } 

        [JsonProperty("users_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UsersName { get; set; } 

        [JsonProperty("sibling_count_open", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiblingCountOpen { get; set; } 

        [JsonProperty("parent_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentSummary { get; set; } 

        [JsonProperty("parent_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentStatusName { get; set; } 

        [JsonProperty("new_approvalprocess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcess { get; set; } 

        [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessAgentId { get; set; } 

        [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessUserId { get; set; } 

        [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewApprovalProcessEmail { get; set; } 

        [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessCabId { get; set; } 

        [JsonProperty("approvers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketApproval>? Approvers { get; set; } 

        [JsonProperty("approvers_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketApproval>? ApproversHistory { get; set; } 

        [JsonProperty("appointment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentCount { get; set; } 

        [JsonProperty("open_chat_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenChatCount { get; set; } 

        [JsonProperty("task_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskCount { get; set; } 

        [JsonProperty("create_article", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateArticle { get; set; } 

        [JsonProperty("qualifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Qualification>? Qualifications { get; set; } 

        [JsonProperty("target_adjust", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetAdjust { get; set; } 

        [JsonProperty("start_adjust", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StartAdjust { get; set; } 

        [JsonProperty("dont_do_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontDoRules { get; set; } 

        [JsonProperty("dont_do_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontDoDatabaselookups { get; set; } 

        [JsonProperty("apply_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyRules { get; set; } 

        [JsonProperty("apply_this_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApplyThisRule { get; set; } 

        [JsonProperty("_forcereassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forcereassign { get; set; } 

        [JsonProperty("_appointment01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Appointment01Ok { get; set; } 

        [JsonProperty("_agent01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent01Ok { get; set; } 

        [JsonProperty("_agent02_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent02Ok { get; set; } 

        [JsonProperty("_asset01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Asset01Ok { get; set; } 

        [JsonProperty("return_this", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnThis { get; set; } 

        [JsonProperty("_validate_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateForm { get; set; } 

        [JsonProperty("_validate_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateUpdates { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("documents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Documents { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PopupNote>? PopupNotes { get; set; } 

        [JsonProperty("current_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrentActionType { get; set; } 

        [JsonProperty("current_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrentActionName { get; set; } 

        [JsonProperty("_ispreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreview { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetList>? Assets { get; set; } 

        [JsonProperty("nochangesequpdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nochangesequpdate { get; set; } 

        [JsonProperty("_reclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reclose { get; set; } 

        [JsonProperty("_reclose_oid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RecloseOid { get; set; } 

        [JsonProperty("_recover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recover { get; set; } 

        [JsonProperty("reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reference { get; set; } 

        [JsonProperty("email_start_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailStartTagOverride { get; set; } 

        [JsonProperty("email_end_tag_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailEndTagOverride { get; set; } 

        [JsonProperty("follower_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FollowerCount { get; set; } 

        [JsonProperty("contact_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Address? ContactAddress { get; set; } 

        [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatId { get; set; } 

        [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actioncode { get; set; } 

        [JsonProperty("clone_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CloneCount { get; set; } 

        [JsonProperty("todo_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TodoCount { get; set; } 

        [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketToDo>? TodoList { get; set; } 

        [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceCount { get; set; } 

        [JsonProperty("unsubscribedfromserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unsubscribedfromserviceid { get; set; } 

        [JsonProperty("is_opportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpportunity { get; set; } 

        [JsonProperty("is_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProject { get; set; } 

        [JsonProperty("items_issued_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemsIssuedCount { get; set; } 

        [JsonProperty("items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketItem>? ItemsIssued { get; set; } 

        [JsonProperty("project_items_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketItem>? ProjectItemsIssued { get; set; } 

        [JsonProperty("quotation_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotationCount { get; set; } 

        [JsonProperty("salesorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesOrderCount { get; set; } 

        [JsonProperty("purchaseorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseOrderCount { get; set; } 

        [JsonProperty("invoice_line_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceLineCount { get; set; } 

        [JsonProperty("third_party_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyClientId { get; set; } 

        [JsonProperty("_refreshresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refreshresponse { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImport { get; set; } 

        [JsonProperty("_isalert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAlert { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Novalidate { get; set; } 

        [JsonProperty("is_closure_reminder_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClosureReminderClosure { get; set; } 

        [JsonProperty("is_slahold_reminder_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSlaHoldReminderClosure { get; set; } 

        [JsonProperty("_importid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importid { get; set; } 

        [JsonProperty("sendtopagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendtopagerduty { get; set; } 

        [JsonProperty("splunkurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkurl { get; set; } 

        [JsonProperty("splunksearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunksearch { get; set; } 

        [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BudgetTypeId { get; set; } 

        [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BudgetTypeName { get; set; } 

        [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketBudget>? Budgets { get; set; } 

        [JsonProperty("process_ai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProcessAi { get; set; } 

        [JsonProperty("send_remoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendRemoteinvite { get; set; } 

        [JsonProperty("invite_emaillist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InviteEmailList { get; set; } 

        [JsonProperty("third_party_call_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyCallId { get; set; } 

        [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotetechid { get; set; } 

        [JsonProperty("linkremotesession", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linkremotesession { get; set; } 

        [JsonProperty("remotesessionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotesessionid { get; set; } 

        [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Utcoffset { get; set; } 

        [JsonProperty("form_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FormId { get; set; } 

        [JsonProperty("database_lookup_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DatabaseLookupResult? DatabaseLookupResult { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenants { get; set; } 

        [JsonProperty("azure_tenants_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantsName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("_warning_is_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WarningIsError { get; set; } 

        [JsonProperty("close_unassigned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloseUnassigned { get; set; } 

        [JsonProperty("canbechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canbechild { get; set; } 

        [JsonProperty("_changefreeze01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changefreeze01Ok { get; set; } 

        [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; } 

        [JsonProperty("_ticketclash01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketclash01Ok { get; set; } 

        [JsonProperty("_milestonedate01_ok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Milestonedate01Ok { get; set; } 

        [JsonProperty("_ignoremilestonedates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoremilestonedates { get; set; } 

        [JsonProperty("locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; } 

        [JsonProperty("has_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasRelated { get; set; } 

        [JsonProperty("pagerdutyeragent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutyeragent { get; set; } 

        [JsonProperty("elapsed_response_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ElapsedResponseHours { get; set; } 

        [JsonProperty("elapsed_resolution_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ElapsedResolutionHours { get; set; } 

        [JsonProperty("sla_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SlaStartDate { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrintGenerate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrintHtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PdfAttachmentId { get; set; } 

        [JsonProperty("journeys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Journey>? Journeys { get; set; } 

        [JsonProperty("devops_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DevOpsAgent { get; set; } 

        [JsonProperty("_dontupdate_devops", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateDevOps { get; set; } 

        [JsonProperty("category_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryNote1 { get; set; } 

        [JsonProperty("category_user_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryUserNote1 { get; set; } 

        [JsonProperty("category_include_note_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoryIncludeNote1 { get; set; } 

        [JsonProperty("category_itil_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryItil1 { get; set; } 

        [JsonProperty("category_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryNote2 { get; set; } 

        [JsonProperty("category_user_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryUserNote2 { get; set; } 

        [JsonProperty("category_include_note_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoryIncludeNote2 { get; set; } 

        [JsonProperty("category_itil_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryItil2 { get; set; } 

        [JsonProperty("category_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryNote3 { get; set; } 

        [JsonProperty("category_user_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryUserNote3 { get; set; } 

        [JsonProperty("category_include_note_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoryIncludeNote3 { get; set; } 

        [JsonProperty("category_itil_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryItil3 { get; set; } 

        [JsonProperty("category_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryNote4 { get; set; } 

        [JsonProperty("category_user_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryUserNote4 { get; set; } 

        [JsonProperty("category_include_note_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CategoryIncludeNote4 { get; set; } 

        [JsonProperty("category_itil_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryItil4 { get; set; } 

        [JsonProperty("devops_comment_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DevOpsCommentCount { get; set; } 

        [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iszapier { get; set; } 

        [JsonProperty("ncentral_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralTicketId { get; set; } 

        [JsonProperty("_isnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnotify { get; set; } 

        [JsonProperty("created_from_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromActionId { get; set; } 

        [JsonProperty("created_from_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedFromActionName { get; set; } 

        [JsonProperty("createacknowledgement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createacknowledgement { get; set; } 

        [JsonProperty("your_vote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? YourVote { get; set; } 

        [JsonProperty("your_vote_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? YourVoteComment { get; set; } 

        [JsonProperty("donotapplytemplateintheapi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotApplytemplateintheapi { get; set; } 

        [JsonProperty("_create_outstanding_appointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateOutstandingAppointments { get; set; } 

        [JsonProperty("_create_outstanding_appointment_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateOutstandingAppointmentEmail { get; set; } 

        [JsonProperty("scomalertstate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scomalertstate { get; set; } 

        [JsonProperty("orionalertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalertid { get; set; } 

        [JsonProperty("orionalertactiveid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionalertactiveid { get; set; } 

        [JsonProperty("orionacknowledgestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionacknowledgestate { get; set; } 

        [JsonProperty("orionclosestate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionclosestate { get; set; } 

        [JsonProperty("orionacknowledgedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orionacknowledgedby { get; set; } 

        [JsonProperty("orionacknowledgedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Orionacknowledgedate { get; set; } 

        [JsonProperty("_acknowledgealert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Acknowledgealert { get; set; } 

        [JsonProperty("orionacknowledgenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionacknowledgenote { get; set; } 

        [JsonProperty("orionacknowledgedbyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionacknowledgedbyname { get; set; } 

        [JsonProperty("orionalertname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionalertname { get; set; } 

        [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNowId { get; set; } 

        [JsonProperty("third_party_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyParentId { get; set; } 

        [JsonProperty("third_party_problem_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyProblemId { get; set; } 

        [JsonProperty("opened_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpenedBy { get; set; } 

        [JsonProperty("resolved_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResolvedBy { get; set; } 

        [JsonProperty("sendtosplunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendtosplunkoncall { get; set; } 

        [JsonProperty("splunkoncalltarget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkoncalltarget { get; set; } 

        [JsonProperty("splunkoncalltarget_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplunkoncalltargetId { get; set; } 

        [JsonProperty("splunkoncall_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplunkoncallId { get; set; } 

        [JsonProperty("splunkoncallurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkoncallurl { get; set; } 

        [JsonProperty("splunkoncallstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkoncallstatus { get; set; } 

        [JsonProperty("connectwise_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectWiseId { get; set; } 

        [JsonProperty("connectwise_project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectWiseProjectId { get; set; } 

        [JsonProperty("prepay_balance_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalanceHours { get; set; } 

        [JsonProperty("prepay_balance_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalanceAmount { get; set; } 

        [JsonProperty("servicenow_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNowNumber { get; set; } 

        [JsonProperty("parent_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentTicketTypeName { get; set; } 

        [JsonProperty("createdfrom_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CreatedFromTicketTypeName { get; set; } 

        [JsonProperty("clonedfrom_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClonedFromTicketTypeName { get; set; } 

        [JsonProperty("autotask_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoTaskId { get; set; } 

        [JsonProperty("autotask_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutoTaskNumber { get; set; } 

        [JsonProperty("atera_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraAlertId { get; set; } 

        [JsonProperty("syncro_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroAlertId { get; set; } 

        [JsonProperty("laststatuschangestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LastStatuschangestatus { get; set; } 

        [JsonProperty("laststatuschangestatusdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastStatuschangestatusdate { get; set; } 

        [JsonProperty("mark_as_read_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkAsReadOnly { get; set; } 

        [JsonProperty("audit_log", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Audit>? AuditLog { get; set; } 

        [JsonProperty("meraki_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiDevice { get; set; } 

        [JsonProperty("meraki_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiAlertType { get; set; } 

        [JsonProperty("matched_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketRuleMatch>? MatchedRules { get; set; } 

        [JsonProperty("powershell_script_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PowershellScriptCount { get; set; } 

        [JsonProperty("devops_workitem_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DevOpsWorkitemCount { get; set; } 

        [JsonProperty("ninja_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaAlertId { get; set; } 

        [JsonProperty("ninja_device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaDeviceId { get; set; } 

        [JsonProperty("usertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usertype { get; set; } 

        [JsonProperty("actionworkflowset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actionworkflowset { get; set; } 

        [JsonProperty("isbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isbillable { get; set; } 

        [JsonProperty("itemsarebillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itemsarebillable { get; set; } 

        [JsonProperty("childrenlefttocreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Childrenlefttocreate { get; set; } 

        [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Who { get; set; } 

        [JsonProperty("resourcetype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourcetypeId { get; set; } 

        [JsonProperty("resourcetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ResourcetypeName { get; set; } 

        [JsonProperty("resource_booking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceBookingType { get; set; } 

        [JsonProperty("resource_booking_timeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ResourceBookingTimeslot { get; set; } 

        [JsonProperty("resource_booking_asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceBookingAsset { get; set; } 

        [JsonProperty("matched_rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchedRuleIds { get; set; } 

        [JsonProperty("forceruleupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forceruleupdate { get; set; } 

        [JsonProperty("teams_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsUserId { get; set; } 

        [JsonProperty("_isteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTeams { get; set; } 

        [JsonProperty("faultapprovalfailed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faultapprovalfailed { get; set; } 

        [JsonProperty("article_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArticleDescription { get; set; } 

        [JsonProperty("article_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArticleResolution { get; set; } 

        [JsonProperty("article_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArticleNotes { get; set; } 

        [JsonProperty("article_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ArticleType { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? Tags { get; set; } 

        [JsonProperty("dontcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontCreatechild { get; set; } 

        [JsonProperty("needcreatechild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedCreatechild { get; set; } 

        [JsonProperty("sentinel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelId { get; set; } 

        [JsonProperty("sentinel_resourcegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelResourcegroup { get; set; } 

        [JsonProperty("sentinel_subscriptionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelSubscriptionid { get; set; } 

        [JsonProperty("sentinel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelWorkspace { get; set; } 

        [JsonProperty("faultapprovalexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faultapprovalexists { get; set; } 

        [JsonProperty("_validate_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidateOnly { get; set; } 

        [JsonProperty("_validation_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValidationKey { get; set; } 

        [JsonProperty("azuremonitor_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzuremonitorId { get; set; } 

        [JsonProperty("domotz_alertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzAlertid { get; set; } 

        [JsonProperty("domotz_deviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzDeviceid { get; set; } 

        [JsonProperty("domerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoMerge { get; set; } 

        [JsonProperty("isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; } 

        [JsonProperty("automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomateId { get; set; } 

        [JsonProperty("device_automate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceAutomateId { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikId { get; set; } 

        [JsonProperty("auvik_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikUrl { get; set; } 

        [JsonProperty("contract_balance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractBalance { get; set; } 

        [JsonProperty("bookingurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bookingurl { get; set; } 

        [JsonProperty("billable_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? BillableTime { get; set; } 

        [JsonProperty("isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClone { get; set; } 

        [JsonProperty("clonedfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClonedFrom { get; set; } 

        [JsonProperty("slatimeremaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? SlaTimeremaining { get; set; } 

        [JsonProperty("customfieldvalidationreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customfieldvalidationreason { get; set; } 

        [JsonProperty("_has_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasAutomations { get; set; } 

        [JsonProperty("chat_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatCount { get; set; } 

        [JsonProperty("_dontupdate_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateJira { get; set; } 

        [JsonProperty("jira_issue_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraIssueCount { get; set; } 

        [JsonProperty("call_log_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallLogCount { get; set; } 

        [JsonProperty("sentinel_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelUrl { get; set; } 

        [JsonProperty("sentinel_display_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelDisplayId { get; set; } 

        [JsonProperty("postloggedview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Postloggedview { get; set; } 

        [JsonProperty("addigy_alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyAlertId { get; set; } 

        [JsonProperty("ninja_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaAlertType { get; set; } 

        [JsonProperty("freshdesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FreshdeskId { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? ExternalLinks { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdPartyId { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; } 

        [JsonProperty("kaseya_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaAgentId { get; set; } 

        [JsonProperty("salesforce_contactid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceContactid { get; set; } 

        [JsonProperty("salesforce_accountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceAccountid { get; set; } 

        [JsonProperty("salesforce_parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceParentId { get; set; } 

        [JsonProperty("salesforce_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceStatus { get; set; } 

        [JsonProperty("newrelic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicId { get; set; } 

        [JsonProperty("newrelicincident_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicincidentId { get; set; } 

        [JsonProperty("backup_radar_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupRadarId { get; set; } 

        [JsonProperty("backup_radar_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupRadarState { get; set; } 

        [JsonProperty("linktypesarray", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Linktypesarray { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaId { get; set; } 

        [JsonProperty("alluserscanview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alluserscanview { get; set; } 

        [JsonProperty("_dontupdate_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateSalesforce { get; set; } 

        [JsonProperty("sync_to_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToSalesforce { get; set; } 

        [JsonProperty("salesforce_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceStage { get; set; } 

        [JsonProperty("_newticket_quickclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewTicketQuickclose { get; set; } 

        [JsonProperty("service_request_detail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceRequestDetailId { get; set; } 

        [JsonProperty("visible_child_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibleChildTickets { get; set; } 

        [JsonProperty("check_status_freeze", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckStatusFreeze { get; set; } 

        [JsonProperty("expenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Expense>? Expenses { get; set; } 

        [JsonProperty("clear_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearFeedback { get; set; } 

        [JsonProperty("facebook_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FacebookMessageId { get; set; } 

        [JsonProperty("twitter_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? TwitterMessageId { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralDetailsId { get; set; } 

        [JsonProperty("requesttype_published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequestTypePublishedId { get; set; } 

        [JsonProperty("chat_key_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatKeyId { get; set; } 

        [JsonProperty("supplier_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierContactId { get; set; } 

        [JsonProperty("parent_itil_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentItilTicketType { get; set; } 

        [JsonProperty("parent_release_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentReleaseNote { get; set; } 

        [JsonProperty("parent_release_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentReleaseName { get; set; } 

        [JsonProperty("parent_release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentRelease2Name { get; set; } 

        [JsonProperty("parent_release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentRelease3Name { get; set; } 

        [JsonProperty("pagerdutyservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyservice { get; set; } 

        [JsonProperty("pagerdutyservice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerdutyserviceName { get; set; } 

        [JsonProperty("_dontupdate_pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdatePagerduty { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontFireAutomations { get; set; } 

        [JsonProperty("teamsmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsmessage { get; set; } 

        [JsonProperty("default_teams_chat_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTeamsChatName { get; set; } 

        [JsonProperty("show_chat_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChatCreate { get; set; } 

        [JsonProperty("htmlmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Htmlmessage { get; set; } 

        [JsonProperty("linked_halo_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedHaloTicketCount { get; set; } 

        [JsonProperty("halolink_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HalolinkTicketId { get; set; } 

        [JsonProperty("override_opening_action_who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverrideOpeningActionWho { get; set; } 

        [JsonProperty("whatsappcreatedfromid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsappcreatedfromid { get; set; } 

        [JsonProperty("unotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unotes { get; set; } 

        [JsonProperty("smemo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smemo { get; set; } 

        [JsonProperty("amemo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Amemo { get; set; } 

        [JsonProperty("_matchintacctclass", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchintacctclass { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctClass { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctClassName { get; set; } 

        [JsonProperty("sms_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmsOverride { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceName { get; set; } 

        [JsonProperty("milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Milestone>? Milestones { get; set; } 

        [JsonProperty("email_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailMessageId { get; set; } 

        [JsonProperty("seenby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Seenby { get; set; } 

        [JsonProperty("recaptcha_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RecaptchaToken { get; set; } 

        [JsonProperty("resource_booking_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceBookingSite { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabs>? ExtraTabs { get; set; } 

        [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessRoleId { get; set; } 

        [JsonProperty("new_approvalprocess_customfieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewApprovalProcessCustomfieldid { get; set; } 

        [JsonProperty("linked_ecommerce_order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LinkedEcommerceOrderNumber { get; set; } 

        [JsonProperty("linked_ecommerce_order_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LinkedEcommerceOrderUrl { get; set; } 

        [JsonProperty("parent_milestones", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Milestone>? ParentMilestones { get; set; } 

        [JsonProperty("vectors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketVector>? Vectors { get; set; } 

        [JsonProperty("ai_matched_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketVectorScore>? AiMatchedTickets { get; set; } 

        [JsonProperty("ai_matched_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketVectorScore>? AiMatchedArticles { get; set; } 

        [JsonProperty("ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AiSuggestionFault>? AiSuggestions { get; set; } 

        [JsonProperty("_apply_ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? ApplyAiSuggestions { get; set; } 

        [JsonProperty("_dismiss_ai_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? DismissAiSuggestions { get; set; } 

        [JsonProperty("suggested_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SuggestedCategory1 { get; set; } 

        [JsonProperty("thirdpartyreviewscore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ThirdPartyReviewScore { get; set; } 

        [JsonProperty("datto_alert_state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattoAlertState { get; set; } 

        [JsonProperty("forwarded_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardedBy { get; set; } 

        [JsonProperty("reviewed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ReviewedDate { get; set; } 

        [JsonProperty("is_sensitive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSensitive { get; set; } 

        [JsonProperty("contract_schedule_plan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractSchedulePlanId { get; set; } 

        [JsonProperty("instagram_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstagramMessageId { get; set; } 

        [JsonProperty("default_reporter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultReporter { get; set; } 

        [JsonProperty("defaultsendattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultSendattachments { get; set; } 

        [JsonProperty("devops_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DevOpsKey { get; set; } 

        [JsonProperty("related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketList>? RelatedTickets { get; set; } 

        [JsonProperty("new_related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketList>? NewRelatedTickets { get; set; } 

        [JsonProperty("unrelate_from_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UnrelateFromTicketId { get; set; } 

        [JsonProperty("ecommerce_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<EcommerceOrderTicket>? EcommerceOrders { get; set; } 

        [JsonProperty("hide_feedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFeedback { get; set; } 

        [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? WorkflowHistory { get; set; } 

        [JsonProperty("connectwisermm_ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWiseRmmTicketId { get; set; } 

        [JsonProperty("colour_rule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ColourRule { get; set; } 

        [JsonProperty("google_reviewdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleBusinessReview? GoogleReviewdata { get; set; } 

        [JsonProperty("google_questiondata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public GoogleBusinessQuestion? GoogleQuestiondata { get; set; } 

        [JsonProperty("original_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalAgent { get; set; } 

        [JsonProperty("do_lookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoLookups { get; set; } 

        [JsonProperty("liongard_system_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardSystemId { get; set; } 

        [JsonProperty("bigpanda_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BigpandaId { get; set; } 

        [JsonProperty("contributors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Contributors>? Contributors { get; set; } 

        [JsonProperty("internet_message_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InternetMessageId { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchingValue { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SqlImportId { get; set; } 

        [JsonProperty("respondbydateadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Respondbydateadjusted { get; set; } 

        [JsonProperty("date_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketDateDependencies>? DateDependencies { get; set; } 

        [JsonProperty("new_milestone_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewMilestoneTicket { get; set; } 

        [JsonProperty("assets_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ViewColumnsDetails>? AssetsColumns { get; set; } 

        [JsonProperty("slaresponseexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaResponseexcuse { get; set; } 

        [JsonProperty("can_add_cc_followers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanAddCcFollowers { get; set; } 

        [JsonProperty("_fromchatprofileid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fromchatprofileid { get; set; } 

        [JsonProperty("lapsafe_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LapsafeCount { get; set; } 

        [JsonProperty("olas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketOla>? Olas { get; set; } 

        [JsonProperty("ola_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OlaCount { get; set; } 

        [JsonProperty("new_workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? NewWorkflowHistory { get; set; } 

        [JsonProperty("default_slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSlackChannelName { get; set; } 

        [JsonProperty("show_channel_create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChannelCreate { get; set; } 

        [JsonProperty("slack_channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackChannelId { get; set; } 

        [JsonProperty("slack_callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackCallbackId { get; set; } 

        [JsonProperty("ai_suggested_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSuggestedPriority { get; set; } 

        [JsonProperty("ai_suggested_resolution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSuggestedResolution { get; set; } 

        [JsonProperty("ai_generated_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiGeneratedSummary { get; set; } 

        [JsonProperty("ai_search_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSearchQuery { get; set; } 

        [JsonProperty("ai_suggested_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSuggestedType { get; set; } 

        [JsonProperty("ai_sentiment_analysis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSentimentAnalysis { get; set; } 

        [JsonProperty("ai_satisfaction_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSatisfactionLevel { get; set; } 

        [JsonProperty("ai_tonality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiTonality { get; set; } 

        [JsonProperty("_isagentuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAgentuser { get; set; } 

        [JsonProperty("ai_survey_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiSurveyScore { get; set; } 

        [JsonProperty("ai_survey_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiSurveyComment { get; set; } 

        [JsonProperty("freshdesk_ticket_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FreshdeskTicket? FreshdeskTicketData { get; set; } 

        [JsonProperty("freshdesk_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskGroupName { get; set; } 

        [JsonProperty("freshdesk_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskAgentName { get; set; } 

        [JsonProperty("freshdesk_agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskAgentEmail { get; set; } 

        [JsonProperty("freshdesk_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskProductName { get; set; } 

        [JsonProperty("matched_kb_id_acessible_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchedKbIdAcessibleToUser { get; set; } 

        [JsonProperty("remotesession_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RemotesessionCount { get; set; } 

        [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SearchIndexSyncTimestamp { get; set; } 

        [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchIndexSyncBatches { get; set; } 

        [JsonProperty("new_whe_", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NewWhe { get; set; } 

        [JsonProperty("new_actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewActioncode { get; set; } 

        [JsonProperty("notepad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notepad { get; set; } 

        [JsonProperty("embedding_match_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EmbeddingMatchTimestamp { get; set; } 

        [JsonProperty("_re_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReIndex { get; set; } 

        [JsonProperty("_fetch_matches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FetchMatches { get; set; } 

        [JsonProperty("workflow_move_date_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? WorkflowMoveDateOverride { get; set; } 

        [JsonProperty("lookup_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LookupSearch { get; set; } 

        [JsonProperty("agent_booking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentBookingType { get; set; } 

        [JsonProperty("agent_booking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Appointment? AgentBooking { get; set; } 

        [JsonProperty("pandadoc_attachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PandadocAttachment { get; set; } 

        [JsonProperty("pandadoc_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PandadocAttachmentName { get; set; } 

        [JsonProperty("pandadoc_attachment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PandadocAttachmentUrl { get; set; } 

        [JsonProperty("thirdparty_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyUrl { get; set; } 

        [JsonProperty("security_signal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SecuritySignalId { get; set; } 

        [JsonProperty("datadog_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DatadogId { get; set; } 

        [JsonProperty("ai_conversation_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AiConversationSummary { get; set; } 

        [JsonProperty("incomingevent_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingEventCount { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureConnectionId { get; set; } 

        [JsonProperty("kblinkid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kblinkid { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketClientToInvoiceToId { get; set; } 

        [JsonProperty("ticket_client_to_invoice_to_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketClientToInvoiceToName { get; set; } 

        [JsonProperty("_prevent_outgoing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreventOutgoing { get; set; } 

        [JsonProperty("dont_copy_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontCopyHistory { get; set; } 

        [JsonProperty("user_linked_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? UserLinkedSites { get; set; } 

        [JsonProperty("prepay_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PrePayThreshold? PrepayThreshold { get; set; } 

        [JsonProperty("automation_entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomationEntityType { get; set; } 

        [JsonProperty("make_automation_entity_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MakeAutomationEntityInactive { get; set; } 

        [JsonProperty("is_downtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDowntime { get; set; } 

        [JsonProperty("add_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tag>? AddTags { get; set; } 

        [JsonProperty("locked_by_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LockedByAgentId { get; set; } 

        [JsonProperty("_forceunlock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forceunlock { get; set; } 

        [JsonProperty("_is_aisuggestion_merge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAisuggestionMerge { get; set; } 

        [JsonProperty("service_linked_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceLinkedDevice { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Table { get; set; } 

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
        public string? LastActiondateteams { get; set; } 

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
        public string? UserDepartments { get; set; } 

        [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateservicestatus { get; set; } 

        [JsonProperty("servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicestatusnote { get; set; } 

        [JsonProperty("itil_requesttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItilRequestTypeId { get; set; } 

        [JsonProperty("startdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDateTime { get; set; } 

        [JsonProperty("enddatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDateTime { get; set; } 

        [JsonProperty("closure_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosureAgentId { get; set; } 

        [JsonProperty("closed_in_integration_system", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClosedInIntegrationSystem { get; set; } 

        [JsonProperty("createdfromautomationstdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedFromAutomationstdid { get; set; } 

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
        public string? PurchaseOrdernumber { get; set; } 

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
        public ExternalLink? PrimaryIssue { get; set; } 

        [JsonProperty("primary_workitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink? PrimaryWorkitem { get; set; } 

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

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportTypeId { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportThirdPartyId { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink? NewExternalLink { get; set; } 

    }