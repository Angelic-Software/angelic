using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractHeaderList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Refextra { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Started { get; set; } 

    [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Expired { get; set; } 

    [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Numberofunitsfree { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriod { get; set; } 

    [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingdescription { get; set; } 

    [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subtype { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("periodicinvoicenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PeriodIcinvoicenextdate { get; set; } 

    [JsonProperty("next_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextInvoiceDate { get; set; } 

    [JsonProperty("periodchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PeriodChargeamount { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AssetValue { get; set; } 

    [JsonProperty("refextra2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Refextra2 { get; set; } 

    [JsonProperty("contract_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractStatus { get; set; } 

    [JsonProperty("asset_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetSequence { get; set; } 

    [JsonProperty("next_call_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCallDate { get; set; } 

    [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccountsOverrideMailbox { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("asset_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AssetEndDate { get; set; } 

    [JsonProperty("contracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractType { get; set; } 

    [JsonProperty("contracttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractTypeName { get; set; } 

    [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayRecurringChargeBp { get; set; } 

    [JsonProperty("force_recalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceRecalculation { get; set; } 

    [JsonProperty("cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CostCalculation { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("sent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SentToOracle { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("createdby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedById { get; set; } 

    [JsonProperty("createdby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedByName { get; set; } 

    [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingCategory { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}