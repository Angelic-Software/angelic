using System.CodeDom.Compiler;
using Angelic.Configuration.Billing.ChargeRates;
using Newtonsoft.Json;

namespace Angelic.Configuration.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Lookup
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("lookupid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookupid { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("value2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value2 { get; set; } 

    [JsonProperty("value2_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value2Bool { get; set; } 

    [JsonProperty("value3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value3 { get; set; } 

    [JsonProperty("value3_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value3Bool { get; set; } 

    [JsonProperty("value4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value4 { get; set; } 

    [JsonProperty("value4_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value4Bool { get; set; } 

    [JsonProperty("value5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value5 { get; set; } 

    [JsonProperty("value5_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value5Bool { get; set; } 

    [JsonProperty("value6", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value6 { get; set; } 

    [JsonProperty("value6_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value6Bool { get; set; } 

    [JsonProperty("value7", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value7 { get; set; } 

    [JsonProperty("value7_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value7Bool { get; set; } 

    [JsonProperty("value8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value8 { get; set; } 

    [JsonProperty("value8_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value8Bool { get; set; } 

    [JsonProperty("value9", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value9 { get; set; } 

    [JsonProperty("value9_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value9Bool { get; set; } 

    [JsonProperty("rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargeRate>? Rates { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractRef { get; set; } 

    [JsonProperty("overriding_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverridingRateId { get; set; } 

    [JsonProperty("_isnewcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isnewcode { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("kashflow_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KashflowTenant { get; set; } 

    [JsonProperty("email_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTemplateName { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlaName { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("custom1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom1 { get; set; } 

    [JsonProperty("custom1_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Custom1Bool { get; set; } 

    [JsonProperty("custom2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom2 { get; set; } 

    [JsonProperty("tax_rate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxRateName { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantName { get; set; } 

    [JsonProperty("surcharge_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SurchargeItemName { get; set; } 

    [JsonProperty("dynamics_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DynamicsCompanyName { get; set; } 

    [JsonProperty("valueint1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Valueint1 { get; set; } 

    [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedItem { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("sub_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? SubLookup { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColumnProfileName { get; set; } 

    [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraInstanceName { get; set; } 

}