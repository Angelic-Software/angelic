using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Items;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.ExchangeWebServices;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record EwsAppointmentChange
{
    [Range(0, 3)]
    [JsonProperty("changeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChangeType { get; set; } 

    [JsonProperty("itemId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ItemId? ItemId { get; set; } 

    [JsonProperty("item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public EwsAppointmentBasic? Item { get; set; } 

    [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AgentList? Agent { get; set; } 

}