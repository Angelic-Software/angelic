using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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
    public bool? Value2_bool { get; set; } 

    [JsonProperty("value3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value3 { get; set; } 

    [JsonProperty("value3_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value3_bool { get; set; } 

    [JsonProperty("value4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value4 { get; set; } 

    [JsonProperty("value4_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value4_bool { get; set; } 

    [JsonProperty("value5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value5 { get; set; } 

    [JsonProperty("value5_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value5_bool { get; set; } 

    [JsonProperty("value6", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value6 { get; set; } 

    [JsonProperty("value6_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value6_bool { get; set; } 

    [JsonProperty("value7", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value7 { get; set; } 

    [JsonProperty("value7_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value7_bool { get; set; } 

    [JsonProperty("value8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value8 { get; set; } 

    [JsonProperty("value8_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value8_bool { get; set; } 

    [JsonProperty("value9", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value9 { get; set; } 

    [JsonProperty("value9_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value9_bool { get; set; } 

    [JsonProperty("rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargeRate>? Rates { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contract_ref { get; set; } 

    [JsonProperty("overriding_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Overriding_rate_id { get; set; } 

    [JsonProperty("_isnewcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isnewcode { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("kashflow_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflow_tenant { get; set; } 

    [JsonProperty("email_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_template_name { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sla_name { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("custom1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom1 { get; set; } 

    [JsonProperty("custom1_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Custom1_bool { get; set; } 

    [JsonProperty("custom2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom2 { get; set; } 

    [JsonProperty("tax_rate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_rate_name { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_name { get; set; } 

    [JsonProperty("surcharge_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Surcharge_item_name { get; set; } 

    [JsonProperty("dynamics_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dynamics_company_name { get; set; } 

    [JsonProperty("valueint1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Valueint1 { get; set; } 

    [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_item { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("sub_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Sub_lookup { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column_profile_name { get; set; } 

    [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jira_instance_name { get; set; } 

}