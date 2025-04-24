using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSalesforce
{
    [JsonProperty("campaign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Campaign { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Notes { get; set; } 

}