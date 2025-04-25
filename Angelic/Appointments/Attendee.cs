using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Appointments;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Attendee
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("appointment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentId { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TypeName { get; set; }
    
    [JsonProperty("response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Response { get; set; }
    
    [JsonProperty("response_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseName { get; set; }
    
    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; }
    
    [JsonProperty("contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContactId { get; set; }
}