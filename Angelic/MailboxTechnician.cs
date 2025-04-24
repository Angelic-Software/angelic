using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailboxTechnician
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailbox_id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}