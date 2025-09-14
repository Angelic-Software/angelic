using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Tickets.TicketRule;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.QualificationMatching;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record QualificationCategory
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("qlid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QlId { get; set; } 

    [JsonProperty("qualification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? QualificationGuid { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? Fields { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}