using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Audit
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? To { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From { get; set; } 

    [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableName { get; set; } 

    [JsonProperty("id1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id1 { get; set; } 

    [JsonProperty("id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id2 { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("actoutcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Actoutcome { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("datetime_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DatetimeTo { get; set; } 

    [JsonProperty("datetime_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DatetimeFrom { get; set; } 

}