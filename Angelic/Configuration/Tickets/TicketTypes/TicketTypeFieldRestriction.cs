using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Tickets.TicketTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketTypeFieldRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("alloweditbeforeapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditbeforeapproval { get; set; } 

    [JsonProperty("alloweditafterapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditafterapproval { get; set; } 

    [JsonProperty("alloweditduringapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alloweditduringapproval { get; set; } 

}