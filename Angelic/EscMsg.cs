using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EscMsg
{
    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailaddress { get; set; } 

    [JsonProperty("full", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Full { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailstatus { get; set; } 

    [JsonProperty("popupstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Popupstatus { get; set; } 

    [JsonProperty("popupaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popupaddress { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("emailbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbody { get; set; } 

    [JsonProperty("emailbody_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbody_html { get; set; } 

    [JsonProperty("ccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ccaddress { get; set; } 

    [JsonProperty("smsstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Smsstatus { get; set; } 

    [JsonProperty("pushstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pushstatus { get; set; } 

    [JsonProperty("smsnos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smsnos { get; set; } 

    [JsonProperty("smsbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smsbody { get; set; } 

    [JsonProperty("sendemailifnopopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendemailifnopopup { get; set; } 

    [JsonProperty("slackid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slackid { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Template_id { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_id { get; set; } 

    [JsonProperty("msteamsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Msteamsid { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("apiversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apiversion { get; set; } 

    [JsonProperty("integratorwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Integratorwarning { get; set; } 

    [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Next_retry_date { get; set; } 

    [JsonProperty("template_already_processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Template_already_processed { get; set; } 

    [JsonProperty("mattermost_channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mattermost_channelid { get; set; } 

    [JsonProperty("replyto_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Replyto_address { get; set; } 

    [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailbox_from { get; set; } 

    [JsonProperty("batch_master", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Batch_master { get; set; } 

    [JsonProperty("batch_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Batch_use { get; set; } 

    [JsonProperty("batch_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Batch_status { get; set; } 

    [JsonProperty("batch_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Batch_parent_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_ignoreperms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _ignoreperms { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("eventno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Eventno { get; set; } 

    [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notification_id { get; set; } 

    [JsonProperty("notification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notification_name { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Read_status { get; set; } 

    [JsonProperty("read_status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Read_status_update { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("action_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_number { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Shown { get; set; } 

    [JsonProperty("key_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key_id { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("status_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status_update { get; set; } 

    [JsonProperty("popupcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popupcolour { get; set; } 

    [JsonProperty("attachment_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attachment_type { get; set; } 

    [JsonProperty("at_entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? At_entity { get; set; } 

    [JsonProperty("at_uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? At_uniqueid { get; set; } 

}