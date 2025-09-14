using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record BulkEmail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("serviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceIdWithUnderscore { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("next_retry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextRetryDate { get; set; } 

    [JsonProperty("last_attempt_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastAttemptDate { get; set; } 

    [JsonProperty("mailcampaignid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailCampaignId { get; set; } 

    [JsonProperty("mailcampaignemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailCampaignEmailId { get; set; } 

    [JsonProperty("mailboxfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxFrom { get; set; } 

    [JsonProperty("mailboxreplyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxReplyTo { get; set; } 

    [JsonProperty("trace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Trace>? Trace { get; set; } 

    [JsonProperty("request_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestBody { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionNumber { get; set; } 

    [JsonProperty("distribution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DistributionList { get; set; } 

}