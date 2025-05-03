using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EscMsg
{
    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("full", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Full { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailStatus { get; set; } 

    [JsonProperty("popupstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Popupstatus { get; set; } 

    [JsonProperty("popupaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popupaddress { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBody { get; set; } 

    [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBodyHtml { get; set; } 

    [JsonProperty("ccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ccaddress { get; set; } 

    [JsonProperty("smsstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmsStatus { get; set; } 

    [JsonProperty("pushstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pushstatus { get; set; } 

    [JsonProperty("smsnos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmsNos { get; set; } 

    [JsonProperty("smsbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmsBody { get; set; } 

    [JsonProperty("sendemailifnopopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendEmailifnopopup { get; set; } 

    [JsonProperty("slackid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlackId { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TemplateId { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalId { get; set; } 

    [JsonProperty("msteamsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Msteamsid { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("apiversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apiversion { get; set; } 

    [JsonProperty("integratorwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Integratorwarning { get; set; } 

    [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextRetryDate { get; set; } 

    [JsonProperty("template_already_processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TemplateAlreadyProcessed { get; set; } 

    [JsonProperty("mattermost_channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MattermostChannelid { get; set; } 

    [JsonProperty("replyto_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReplyToAddress { get; set; } 

    [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxFrom { get; set; } 

    [JsonProperty("batch_master", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BatchMaster { get; set; } 

    [JsonProperty("batch_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BatchUse { get; set; } 

    [JsonProperty("batch_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BatchStatus { get; set; } 

    [JsonProperty("batch_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? BatchParentId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_ignoreperms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoreperms { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("eventno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Eventno { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotificationId { get; set; } 

    [JsonProperty("notification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NotificationName { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReadStatus { get; set; } 

    [JsonProperty("read_status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReadStatusUpdate { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateTime { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Shown { get; set; } 

    [JsonProperty("key_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KeyId { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusUpdate { get; set; } 

    [JsonProperty("popupcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PopupColour { get; set; } 

    [JsonProperty("attachment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttachmentType { get; set; } 

    [JsonProperty("at_entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AtEntity { get; set; } 

    [JsonProperty("at_uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AtUniqueId { get; set; } 

}