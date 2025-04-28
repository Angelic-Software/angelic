using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.Mailboxes;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IncomingEmail
{
    [JsonProperty("old_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mbid { get; set; } 

    [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agentid { get; set; } 

    [JsonProperty("addactiontofaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addactiontofaultid { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("dateprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateprocessed { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("processed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Processed { get; set; } 

    [JsonProperty("delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delete { get; set; } 

    [JsonProperty("issalesmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Issalesmb { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From { get; set; } 

    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; } 

    [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? To { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public User? User { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("mailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailid { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? Data { get; set; } 

    [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Source { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("removed_from_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemovedFromMailbox { get; set; } 

    [JsonProperty("retry_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RetryRemaining { get; set; } 

    [JsonProperty("last_attempt_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastAttemptDate { get; set; } 

    [JsonProperty("_checkmailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkmailid { get; set; } 

    [JsonProperty("_downloadmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Downloadmail { get; set; } 

    [JsonProperty("mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Mailbox? Mailbox { get; set; } 

    [JsonProperty("mailbox_type_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxTypeInt { get; set; } 

    [JsonProperty("outbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Outbound { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}