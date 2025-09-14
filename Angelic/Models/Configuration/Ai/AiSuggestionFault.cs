using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Ai;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AiSuggestionFault
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("suggestion_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SuggestionId { get; set; }
    
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; }
    
    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValue { get; set; }
    
    [JsonProperty("applied", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applied { get; set; }
    
    [JsonProperty("applied_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AppliedDate { get; set; }
    
    [JsonProperty("dismissed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dismissed { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
