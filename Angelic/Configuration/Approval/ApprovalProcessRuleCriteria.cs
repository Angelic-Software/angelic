using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Approval;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ApprovalProcessRuleCriteria
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("approval_process_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalProcessRuleId { get; set; }
    
    [JsonProperty("field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field { get; set; }
    
    [JsonProperty("field_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldDisplay { get; set; }
    
    [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Operation { get; set; }
    
    [JsonProperty("operation_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OperationDisplay { get; set; }
    
    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
