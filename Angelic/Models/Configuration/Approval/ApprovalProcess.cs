using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Approval;

[HasEndpoint("ApprovalProcess")]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ApprovalProcess
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
    
    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; }
    
    [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityType { get; set; }
    
    [JsonProperty("entity_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityTypeName { get; set; }
    
    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ApprovalProcessRule>? Rules { get; set; }
    
    [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ApprovalProcessStep>? Steps { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
