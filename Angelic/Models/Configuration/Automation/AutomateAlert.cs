using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Automation;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AutomateAlert
{
    [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action { get; set; } 

    [JsonProperty("ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateTicket? Ticket { get; set; } 

}