using System.CodeDom.Compiler;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Newtonsoft.Json;

namespace Angelic.Models.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketApproval
{
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; } 

    [JsonProperty("purchase_order_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseOrderRef { get; set; } 

    [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuoteId { get; set; } 

    [JsonProperty("quote_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuoteRef { get; set; } 

    [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartDateTimeZone { get; set; } 

    [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeZone? StartDateWithTimeZone { get; set; } 

    [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetDateTimeZone { get; set; } 

    [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeZone? TargetDateWithTimeZone { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("invoice_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceRef { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailStatus { get; set; } 

    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Result { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("adhoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Adhoc { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("ticket_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketUserId { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketUsername { get; set; } 

    [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CabId { get; set; } 

    [JsonProperty("templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TemplateId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Image { get; set; } 

    [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initials { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("requestor_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestorAgentId { get; set; } 

    [JsonProperty("requestor_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestorUserId { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateTime { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalProcessId { get; set; } 

    [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalProcessName { get; set; } 

    [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ApprovalProcessGuid { get; set; } 

    [JsonProperty("approver_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApproverNote { get; set; } 

    [JsonProperty("requestor_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestorName { get; set; } 

    [JsonProperty("requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestorImgPath { get; set; } 

    [JsonProperty("requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestorColour { get; set; } 

    [JsonProperty("requestor_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestorInitials { get; set; } 

    [JsonProperty("requestor_onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestorOnlineStatus { get; set; } 

    [JsonProperty("requestor_lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestorLastOnline { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("_includeticketinresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeTicketInResponse { get; set; } 

    [JsonProperty("attachment_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AttachmentView? AttachmentList { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Fields { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("agent_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentInitials { get; set; } 

    [JsonProperty("agent_requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentRequestorColour { get; set; } 

    [JsonProperty("agent_requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentRequestorImgPath { get; set; } 

    [JsonProperty("delegated_by_uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DelegatedByUid { get; set; } 

    [JsonProperty("votes_required_to_accept", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? VotesRequiredToAccept { get; set; } 

    [JsonProperty("votes_required_to_reject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? VotesRequiredToReject { get; set; } 

    [JsonProperty("is_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMandatory { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("faresultchanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaResultChanged { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueId { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("newsignatureadded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewSignatureAdded { get; set; } 

    [JsonProperty("lastreminderdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastReminderDatetime { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TargetDate { get; set; } 

    [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartTime { get; set; } 

    [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetTime { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeTaken { get; set; } 

    [JsonProperty("allow_approver_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowApproverAttachments { get; set; } 

    [JsonProperty("holiday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HolidayId { get; set; } 

    [JsonProperty("holiday_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HolidayRef { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("admin_overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdminOverridden { get; set; } 

    [JsonProperty("admin_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdminOverrideId { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } 

    [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalCount { get; set; } 

    [JsonProperty("send_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendWebhook { get; set; } 

    [JsonProperty("dateapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateApproved { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepId { get; set; } 

    [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StepName { get; set; } 

    [JsonProperty("approval_inprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApprovalInprogress { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("_isportalagentnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPortalAgentNote { get; set; } 

    [JsonProperty("delegated_by_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DelegatedByUsername { get; set; } 

}