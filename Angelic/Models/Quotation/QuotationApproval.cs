using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Quotation;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record QuotationApproval
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Result { get; set; } 

    [JsonProperty("approvalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalName { get; set; } 

    [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalEmailAddress { get; set; } 

    [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalNote { get; set; } 

    [JsonProperty("ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoNumber { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("optional_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QuotationDetail>? OptionalLines { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

}