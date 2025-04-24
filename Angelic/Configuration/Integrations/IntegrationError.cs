using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationError
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("detail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailId { get; set; } 

    [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityType { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } 

    [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } 

    [JsonProperty("endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Endpoint { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}