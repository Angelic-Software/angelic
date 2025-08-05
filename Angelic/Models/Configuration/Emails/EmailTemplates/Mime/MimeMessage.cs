using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Angelic.Models.Configuration.Emails.EmailTemplates.Message;
using Angelic.Models.Configuration.Emails.Mailboxes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Mime;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MimeMessage
{
    [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Header>? Headers { get; set; } 

    [Range(0, 2)]
    [JsonProperty("importance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Importance { get; set; } 

    [Range(0, 2)]
    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority { get; set; } 

    [Range(1, 5)]
    [JsonProperty("xPriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XPriority { get; set; } 

    [JsonProperty("sender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailboxAddress? Sender { get; set; } 

    [JsonProperty("resentSender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailboxAddress? ResentSender { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? From { get; set; } 

    [JsonProperty("resentFrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ResentFrom { get; set; } 

    [JsonProperty("replyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ReplyTo { get; set; } 

    [JsonProperty("resentReplyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ResentReplyTo { get; set; } 

    [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? To { get; set; } 

    [JsonProperty("resentTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ResentTo { get; set; } 

    [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? Cc { get; set; } 

    [JsonProperty("resentCc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ResentCc { get; set; } 

    [JsonProperty("bcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? Bcc { get; set; } 

    [JsonProperty("resentBcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InternetAddress>? ResentBcc { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("resentDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ResentDate { get; set; } 

    [JsonProperty("references", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? References { get; set; } 

    [JsonProperty("inReplyTo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InReplyTo { get; set; } 

    [JsonProperty("messageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageId { get; set; } 

    [JsonProperty("resentMessageId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResentMessageId { get; set; } 

    [JsonProperty("mimeVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MimeVersion { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MimeEntity? Body { get; set; } 

    [JsonProperty("textBody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TextBody { get; set; } 

    [JsonProperty("htmlBody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HtmlBody { get; set; } 

    [JsonProperty("bodyParts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MimeEntity>? BodyParts { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MimeEntity>? Attachments { get; set; } 

}