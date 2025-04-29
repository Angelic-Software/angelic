using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractTemplateHeader
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UnmatchedCombinations { get; set; } 

    [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PrepayRecurringChargeNextDate { get; set; } 

    [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Billforrecurringprepayamount { get; set; } 

    [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringCharge { get; set; } 

    [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringHours { get; set; } 

    [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayRecurringChargeBp { get; set; } 

    [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpthreshhold { get; set; } 

    [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUptoamount { get; set; } 

    [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpcostperhour { get; set; } 

    [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpbyamount { get; set; } 

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SurchargeId { get; set; } 

    [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Numberofunitsfree { get; set; } 

    [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringMinimumDeduction { get; set; } 

    [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrepayRecurringMinimumDeductionOnlyActive { get; set; } 

    [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringAutomaticDeduction { get; set; } 

    [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractTemplateDetail>? BillingPlans { get; set; } 

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