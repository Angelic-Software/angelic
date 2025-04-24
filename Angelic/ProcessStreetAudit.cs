using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProcessStreetAudit
{
    [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; } 

    [JsonProperty("createdBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ProcessStreetUser? CreatedBy { get; set; } 

    [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedDate { get; set; } 

    [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ProcessStreetUser? UpdatedBy { get; set; } 

}