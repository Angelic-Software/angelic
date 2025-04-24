using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskSla
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("is_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefault { get; set; } 

    [JsonProperty("position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Position { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedAt { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedAt { get; set; } 

    [JsonProperty("sla_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, FreshdeskPriority>? SlaTarget { get; set; } 

    [JsonProperty("applicable_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? ApplicableTo { get; set; } 

    [JsonProperty("escalation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Escalation { get; set; } 

}