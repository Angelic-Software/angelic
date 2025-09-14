using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Approval;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ApprovalProcessStep
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalProcessId { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
    
    [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order { get; set; }
    
    [JsonProperty("approver_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApproverType { get; set; }
    
    [JsonProperty("approver_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApproverTypeName { get; set; }
    
    [JsonProperty("approver_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApproverId { get; set; }
    
    [JsonProperty("approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApproverName { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
