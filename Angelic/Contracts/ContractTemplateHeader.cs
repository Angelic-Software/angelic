using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractTemplateHeader
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unmatchedcombinations { get; set; } 

    [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Prepayrecurringchargenextdate { get; set; } 

    [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Billforrecurringprepayamount { get; set; } 

    [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringcharge { get; set; } 

    [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringhours { get; set; } 

    [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Prepayrecurringchargebp { get; set; } 

    [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupthreshhold { get; set; } 

    [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopuptoamount { get; set; } 

    [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupcostperhour { get; set; } 

    [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupbyamount { get; set; } 

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Surchargeid { get; set; } 

    [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Numberofunitsfree { get; set; } 

    [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringminimumdeduction { get; set; } 

    [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prepayrecurringminimumdeductiononlyactive { get; set; } 

    [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringautomaticdeduction { get; set; } 

    [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractTemplateDetail>? Billingplans { get; set; } 

    [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingdescription { get; set; } 

    [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subtype { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriod { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Clients { get; set; } 

    [JsonProperty("create_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateContract { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}