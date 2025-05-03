using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractDetail
{
    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("itil_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequestType { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestType { get; set; } 

    [JsonProperty("requesttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestTypeName { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priority { get; set; } 

    [JsonProperty("chargerate_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRateType { get; set; } 

    [JsonProperty("chargerate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRateId { get; set; } 

    [JsonProperty("chargerate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChargeRateName { get; set; } 

    [JsonProperty("multiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Multiplier { get; set; } 

    [JsonProperty("plan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PlanId { get; set; } 

    [JsonProperty("plan_contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PlanContractId { get; set; } 

    [JsonProperty("plan_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PlanName { get; set; } 

    [JsonProperty("category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1 { get; set; } 

    [JsonProperty("partialmatchcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Partialmatchcategory { get; set; } 

    [JsonProperty("category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2 { get; set; } 

    [JsonProperty("partialmatchcategory2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Partialmatchcategory2 { get; set; } 

    [JsonProperty("category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category3 { get; set; } 

    [JsonProperty("partialmatchcategory3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Partialmatchcategory3 { get; set; } 

    [JsonProperty("category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category4 { get; set; } 

    [JsonProperty("partialmatchcategory4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Partialmatchcategory4 { get; set; } 

    [JsonProperty("user_covered_billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserCoveredBillingdescription { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("allowallcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllcontracts { get; set; } 

    [JsonProperty("asset_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetCoveredByContract { get; set; } 

    [JsonProperty("user_covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserCoveredByContract { get; set; } 

    [JsonProperty("work_hours_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkHoursCovered { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order { get; set; } 

    [JsonProperty("billing_plan_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingPlanDesc { get; set; } 

    [JsonProperty("contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractType { get; set; } 

    [JsonProperty("contract_sub_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractSubType { get; set; } 

    [JsonProperty("not_included_in_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NotIncludedInContract { get; set; } 

    [JsonProperty("contract_header_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContractHeaderEndDate { get; set; } 

}