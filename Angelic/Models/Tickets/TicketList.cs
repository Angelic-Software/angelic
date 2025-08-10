using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using Angelic.Attributes;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.ExternalLinks;
using Newtonsoft.Json;

namespace Angelic.Models.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
[HasEndpoint("Tickets")]
[ListVariantOf(typeof(Ticket))]
[Table("FAULTS")]
public class TicketList
{
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
    public string? Username { get; set; }

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
    public double? ProjectTimePercentage { get; set; }

    [JsonProperty("projectcompletionpercentage", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? ProjectCompletionPercentage { get; set; }


    [JsonProperty("projectearlieststart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ProjectEarliestStart { get; set; }

    [JsonProperty("projectlatestend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ProjectLatestEnd { get; set; }

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeTaken { get; set; }

    [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeHours { get; set; }

    [JsonProperty("nonchargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NonChargeHours { get; set; }

    [JsonProperty("travelhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TravelHours { get; set; }

    [JsonProperty("totalmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalMileage { get; set; }

    [JsonProperty("itemsprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemsPrice { get; set; }

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
    public int? EndUserStatus { get; set; }

    [JsonProperty("onhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnHold { get; set; }

    [JsonProperty("respondbydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? RespondByDate { get; set; }

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
    public double? SlaHoldTime { get; set; }

    [JsonProperty("site_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteTimeZone { get; set; }

    [JsonProperty("parentguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentGuid { get; set; }

    [JsonProperty("parentassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ParentAssign { get; set; }

    [JsonProperty("slaactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SlaActionDate { get; set; }

    [JsonProperty("slapercused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SlaPercUsed { get; set; }

    [JsonProperty("slatimeleft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SlaTimeLeft { get; set; }

    [JsonProperty("currentelapsedhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentElapsedHours { get; set; }

    [JsonProperty("lastactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastActionDate { get; set; }

    [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdate { get; set; }

    [JsonProperty("lastchildactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastChildActionDate { get; set; }

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrganisationId { get; set; }

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; }

    [JsonProperty("reportedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportedBy { get; set; }

    [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserEmail { get; set; }

    [JsonProperty("emailtolist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailToList { get; set; }

    [JsonProperty("emailtolistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailToListSupplier { get; set; }

    [JsonProperty("emailcclist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCcList { get; set; }

    [JsonProperty("emailcclistsupplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCcListSupplier { get; set; }

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
    public DateTimeOffset? NextActivityDate { get; set; }

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
    public bool? HasBeenClosed { get; set; }

    [JsonProperty("unread_child_action_count", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? UnreadChildActionCount { get; set; }

    [JsonProperty("unread_related_action_count", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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
    public bool? IsImportantContact { get; set; }

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
    public int? StartTimeSlot { get; set; }

    [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TargetDate { get; set; }

    [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetDateTimeZone { get; set; }

    [JsonProperty("targetdate_with_timezone", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeZone? TargetDateWithTimeZone { get; set; }

    [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetTime { get; set; }

    [JsonProperty("targettimeslot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetTimeSlot { get; set; }

    [JsonProperty("deadlinedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DeadlineDate { get; set; }

    [JsonProperty("followupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? FollowUpdate { get; set; }

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

    [JsonProperty("oppconversionprobability", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? OppConversionProbability { get; set; }

    [JsonProperty("oppvalueadjusted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OppValueAdjusted { get; set; }

    [JsonProperty("oppprofit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OppProfit { get; set; }

    [JsonProperty("oppcurrentsystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OppCurrentSystem { get; set; }

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
    public double? ProjectTimeBudget { get; set; }

    [JsonProperty("projectmoneybudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProjectMoneyBudget { get; set; }

    [JsonProperty("projecttimeactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProjectTimeActual { get; set; }

    [JsonProperty("projectmoneyactual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProjectMoneyActual { get; set; }

    [JsonProperty("lastnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastNote { get; set; }

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
    public string? ReleaseNoteGroupName { get; set; }

    [JsonProperty("releasenotegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseNoteGroupId { get; set; }

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyId { get; set; }

    [JsonProperty("third_party_id_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyIdString { get; set; }

    [JsonProperty("supplier_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierStatus { get; set; }

    [JsonProperty("contract_refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractRefExtra { get; set; }

    [JsonProperty("appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentType { get; set; }

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; }

    [JsonProperty("timeentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTimeEntry>? TimeEntries { get; set; }

    [JsonProperty("section_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SectionTimeZone { get; set; }

    [JsonProperty("itilname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItilName { get; set; }

    [JsonProperty("related_service_descriptions", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedServiceDescriptions { get; set; }

    [JsonProperty("related_service_category_names", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedServiceCategoryNames { get; set; }

    [JsonProperty("projectinternaltask", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProjectInternalTask { get; set; }

    [JsonProperty("appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentId { get; set; }

    [JsonProperty("nextappointmentdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextAppointmentDate { get; set; }

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

    [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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
    public int? ImpactLevel { get; set; }

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
    public int? ReassignCount { get; set; }

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
    public double? SlaTimeElapsed { get; set; }

    [JsonProperty("ai_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AiSummary { get; set; }

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SearchScore { get; set; }

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table { get; set; }

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; }

    [JsonProperty("canbevotedfor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanBeVotedFor { get; set; }

    [JsonProperty("supplier_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierReference { get; set; }

    [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopLevelName { get; set; }

    [JsonProperty("isbeingclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBeingClosed { get; set; }

    [JsonProperty("maximumRestrictedPriority", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? MaximumRestrictedPriority { get; set; }

    [JsonProperty("primary_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrimaryServiceName { get; set; }

    [JsonProperty("idsummary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IdSummary { get; set; }

    [JsonProperty("scomclearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScomClearance { get; set; }

    [JsonProperty("scomalertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScomAlertId { get; set; }

    [JsonProperty("statusseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusSeq { get; set; }

    [JsonProperty("statuscolor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusColor { get; set; }

    [JsonProperty("next_appointment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NextAppointmentType { get; set; }

    [JsonProperty("account_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountManager { get; set; }

    [JsonProperty("orionalert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrionAlert { get; set; }

    [JsonProperty("orionnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrionNote { get; set; }

    [JsonProperty("orionwho", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrionWho { get; set; }

    [JsonProperty("product_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductKey { get; set; }

    [JsonProperty("ticketage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TicketAge { get; set; }

    [JsonProperty("ninja_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaId { get; set; }

    [JsonProperty("teams_ticket_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamsTicketIcon { get; set; }

    [JsonProperty("lastactiondateteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastActionDateTeams { get; set; }

    [JsonProperty("priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PriorityName { get; set; }

    [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UsefulCount { get; set; }

    [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotUsefulCount { get; set; }

    [JsonProperty("sitepostcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SitePostcode { get; set; }

    [JsonProperty("mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailbox { get; set; }

    [JsonProperty("userdepartments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserDepartments { get; set; }

    [JsonProperty("updateservicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateServiceStatus { get; set; }

    [JsonProperty("servicestatusnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceStatusNote { get; set; }

    [JsonProperty("itil_requesttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequestTypeId { get; set; }

    [JsonProperty("startdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDateTime { get; set; }

    [JsonProperty("enddatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDateTime { get; set; }

    [JsonProperty("closure_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosureAgentId { get; set; }

    [JsonProperty("closed_in_integration_system", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClosedInIntegrationSystem { get; set; }

    [JsonProperty("newrelic_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRelicId { get; set; }

    [JsonProperty("createdfromautomationstdid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedFromAutomationStdId { get; set; }


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

    [JsonProperty("invoiceseperatelyoverride", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceSeparatelyOverride { get; set; }

    [JsonProperty("purchaseordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseOrderNumber { get; set; }

    [JsonProperty("overrideticketcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OverrideTicketCost { get; set; }

    [JsonProperty("budgethours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BudgetHours { get; set; }

    [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedBy { get; set; }

    [JsonProperty("additional_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketAdditionalAgents>? AdditionalAgents { get; set; }

    [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceToId { get; set; }

    [JsonProperty("primary_issue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? PrimaryIssue { get; set; }

    [JsonProperty("primary_workitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? PrimaryWorkItem { get; set; }

    [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingPlanText { get; set; }

    [JsonProperty("default_appointment_summary", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentSummary { get; set; }

    [JsonProperty("default_appointment_details", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAppointmentDetails { get; set; }

    [JsonProperty("agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentSignature { get; set; }

    [JsonProperty("customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerSignature { get; set; }

    [JsonProperty("new_agent_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAgentSignature { get; set; }

    [JsonProperty("new_customer_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewCustomerSignature { get; set; }

    [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketClientToInvoiceToId { get; set; }

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; }

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; }

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; }

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; }
}