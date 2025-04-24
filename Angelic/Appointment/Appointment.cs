using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Angelic.Appointment;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Appointment
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; }
    
    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Location { get; set; }
    
    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; }
    
    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; }
    
    [JsonProperty("all_day", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllDay { get; set; }
    
    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
    
    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; }
    
    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TypeName { get; set; }
    
    [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created { get; set; }
    
    [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedBy { get; set; }
    
    [JsonProperty("created_by_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedByName { get; set; }
    
    [JsonProperty("modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Modified { get; set; }
    
    [JsonProperty("modified_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModifiedBy { get; set; }
    
    [JsonProperty("modified_by_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ModifiedByName { get; set; }
    
    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; }
    
    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; }
    
    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; }
    
    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; }
    
    [JsonProperty("contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactId { get; set; }
    
    [JsonProperty("contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContactName { get; set; }
    
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; }
    
    [JsonProperty("ticket_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketNumber { get; set; }
    
    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; }
    
    [JsonProperty("contract_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractNumber { get; set; }
    
    [JsonProperty("attendees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attendee>? Attendees { get; set; }
    
    [JsonProperty("reminder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reminder { get; set; }
    
    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; }
    
    [JsonProperty("recurrence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Recurrence { get; set; }
    
    [JsonProperty("crmnote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Crmnote_id { get; set; } 
}