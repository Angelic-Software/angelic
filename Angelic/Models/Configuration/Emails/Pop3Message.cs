using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.EmailTemplates;
using Angelic.Models.Configuration.Emails.EmailTemplates.Mime;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Pop3Message
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("haloMailboxId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloMailboxId { get; set; } 

    [JsonProperty("incomingEmailId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IncomingEmailId { get; set; } 

    [JsonProperty("mimeMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MimeMessage? MimeMessage { get; set; } 

}