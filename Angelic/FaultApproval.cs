using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultApproval
{
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchase_order_id { get; set; } 

    [JsonProperty("purchase_order_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_order_ref { get; set; } 

    [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quote_id { get; set; } 

    [JsonProperty("quote_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quote_ref { get; set; } 

    [JsonProperty("startdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Startdate_timezone { get; set; } 

    [JsonProperty("startdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeZone? Startdate_with_timezone { get; set; } 

    [JsonProperty("targetdate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Targetdate_timezone { get; set; } 

    [JsonProperty("targetdate_with_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeZone? Targetdate_with_timezone { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_id { get; set; } 

    [JsonProperty("invoice_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_ref { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionnumber { get; set; } 

    [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailstatus { get; set; } 

    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Result { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailaddress { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("adhoc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Adhoc { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("ticket_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_user_id { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_user_name { get; set; } 

    [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cab_id { get; set; } 

    [JsonProperty("templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Templateid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Image { get; set; } 

    [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initials { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("requestor_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestor_agent_id { get; set; } 

    [JsonProperty("requestor_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestor_user_id { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_process_id { get; set; } 

    [JsonProperty("approval_process_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approval_process_name { get; set; } 

    [JsonProperty("approval_process_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Approval_process_guid { get; set; } 

    [JsonProperty("approver_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approver_note { get; set; } 

    [JsonProperty("requestor_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestor_name { get; set; } 

    [JsonProperty("requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestor_imgpath { get; set; } 

    [JsonProperty("requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestor_colour { get; set; } 

    [JsonProperty("requestor_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestor_initials { get; set; } 

    [JsonProperty("requestor_onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestor_onlinestatus { get; set; } 

    [JsonProperty("requestor_lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestor_lastonline { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("_includeticketinresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _includeticketinresponse { get; set; } 

    [JsonProperty("attachment_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AttachmentView? Attachment_list { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RequestTypeField>? Fields { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("agent_initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_initials { get; set; } 

    [JsonProperty("agent_requestor_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_requestor_colour { get; set; } 

    [JsonProperty("agent_requestor_imgpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_requestor_imgpath { get; set; } 

    [JsonProperty("delegated_by_uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delegated_by_uid { get; set; } 

    [JsonProperty("votes_required_to_accept", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Votes_required_to_accept { get; set; } 

    [JsonProperty("votes_required_to_reject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Votes_required_to_reject { get; set; } 

    [JsonProperty("is_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_mandatory { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("faresultchanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faresultchanged { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uniqueid { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("newsignatureadded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newsignatureadded { get; set; } 

    [JsonProperty("lastreminderdatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastreminderdatetime { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("targetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Targetdate { get; set; } 

    [JsonProperty("starttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Starttime { get; set; } 

    [JsonProperty("targettime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Targettime { get; set; } 

    [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Timetaken { get; set; } 

    [JsonProperty("allow_approver_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_approver_attachments { get; set; } 

    [JsonProperty("holiday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Holiday_id { get; set; } 

    [JsonProperty("holiday_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Holiday_ref { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; } 

    [JsonProperty("admin_overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Admin_overridden { get; set; } 

    [JsonProperty("admin_override_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Admin_override_id { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Role_id { get; set; } 

    [JsonProperty("total_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_count { get; set; } 

    [JsonProperty("send_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Send_webhook { get; set; } 

    [JsonProperty("dateapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateapproved { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Step_id { get; set; } 

    [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Step_name { get; set; } 

    [JsonProperty("approval_inprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approval_inprogress { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role_name { get; set; } 

    [JsonProperty("_isportalagentnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isportalagentnote { get; set; } 

    [JsonProperty("delegated_by_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delegated_by_username { get; set; } 

}