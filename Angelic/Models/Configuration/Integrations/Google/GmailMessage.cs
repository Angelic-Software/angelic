using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails;
using Angelic.Models.Configuration.Emails.EmailTemplates;
using Angelic.Models.Configuration.Emails.EmailTemplates.Mime;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Google;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GmailMessage
{
    [JsonProperty("haloMailboxId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloMailboxId { get; set; } 

    [JsonProperty("mimeMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MimeMessage? MimeMessage { get; set; } 

    [JsonProperty("incomingEmailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IncomingEmailId { get; set; } 

    [JsonProperty("historyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? HistoryId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("internalDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? InternalDate { get; set; } 

    [JsonProperty("labelIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? LabelIds { get; set; } 

    [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MessagePart? Payload { get; set; } 

    [JsonProperty("raw", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Raw { get; set; } 

    [JsonProperty("sizeEstimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SizeEstimate { get; set; } 

    [JsonProperty("snippet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snippet { get; set; } 

    [JsonProperty("threadId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThreadId { get; set; } 

    [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ETag { get; set; } 

}