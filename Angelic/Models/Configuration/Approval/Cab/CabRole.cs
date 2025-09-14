using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Approval.Cab;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record CabRole
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CabId { get; set; } 

    [JsonProperty("cab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? CabGuid { get; set; } 

    [JsonProperty("mandatory_approvers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MandatoryApprovers { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("mandatory_rejecters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MandatoryRejecters { get; set; } 

    [JsonProperty("mandatory_voters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MandatoryVoters { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}