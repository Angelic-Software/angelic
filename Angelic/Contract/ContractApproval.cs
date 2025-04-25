using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Contract;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractApproval
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Result { get; set; } 

    [JsonProperty("approvername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approvername { get; set; } 

    [JsonProperty("approveremailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approveremailaddress { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

}