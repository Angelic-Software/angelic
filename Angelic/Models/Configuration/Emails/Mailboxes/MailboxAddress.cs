using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.EmailTemplates.Encoder;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.Mailboxes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailboxAddress
{
    [JsonProperty("route", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Route { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } 

    [JsonProperty("localPart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LocalPart { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("isInternational", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInternational { get; set; } 

    [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Encoding? Encoding { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

}