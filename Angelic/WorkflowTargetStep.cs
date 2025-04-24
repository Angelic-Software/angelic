using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkflowTargetStep
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("workflowtarget_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowtargetId { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepId { get; set; } 

    [JsonProperty("is_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEnd { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("flowheader_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowheaderId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}