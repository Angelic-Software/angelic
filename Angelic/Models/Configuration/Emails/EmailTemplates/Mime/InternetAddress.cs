using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.EmailTemplates.Encoder;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Mime;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InternetAddress
{
    [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Encoding? Encoding { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

}