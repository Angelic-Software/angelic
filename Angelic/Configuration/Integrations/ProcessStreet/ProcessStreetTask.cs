using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.ProcessStreet;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProcessStreetTask
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedDate { get; set; } 

    [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ProcessStreetUser? UpdatedBy { get; set; } 

    [JsonProperty("taskTemplateGroupId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaskTemplateGroupId { get; set; } 

    [JsonProperty("taskType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaskType { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stopped { get; set; } 

    [JsonProperty("hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hidden { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

}