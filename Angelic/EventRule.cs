using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EventRule
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("precedence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Precedence { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Tickettype_guid { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tickettype_name { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Template_id { get; set; } 

    [JsonProperty("template_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Template_guid { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Template_name { get; set; } 

    [JsonProperty("create_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Create_type { get; set; } 

    [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Values { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutoassignCriteria>? Criteria { get; set; } 

    [JsonProperty("mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EventMapping>? Mappings { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("event_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_key { get; set; } 

    [JsonProperty("hide_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_actions { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}