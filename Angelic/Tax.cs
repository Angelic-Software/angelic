using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tax
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Value { get; set; } 

    [JsonProperty("thirdparty_tax_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Thirdparty_tax_rates { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_id { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_name { get; set; } 

    [JsonProperty("third_party_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_desc { get; set; } 

    [JsonProperty("is_composite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_composite { get; set; } 

    [JsonProperty("linked_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tax>? Linked_rates { get; set; } 

    [JsonProperty("xerotaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Xerotaxrate { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflow_tenant_id { get; set; } 

    [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflow_tenant_name { get; set; } 

    [JsonProperty("kashflowtaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Kashflowtaxrate { get; set; } 

    [JsonProperty("qbotaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Qbotaxrate { get; set; } 

    [JsonProperty("qbocode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocode { get; set; } 

    [JsonProperty("qbocode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocode_name { get; set; } 

    [JsonProperty("qbotaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Qbotaxcode { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_id { get; set; } 

    [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_name { get; set; } 

    [JsonProperty("sageintacttaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Sageintacttaxcode { get; set; } 

    [JsonProperty("sage_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage_tenant_id { get; set; } 

    [JsonProperty("sage_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage_tenant_name { get; set; } 

    [JsonProperty("sagebusinesscloudtaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Sagebusinesscloudtaxcode { get; set; } 

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Exact_division { get; set; } 

    [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exact_division_name { get; set; } 

    [JsonProperty("exacttaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Exacttaxcode { get; set; } 

    [JsonProperty("onseparateline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Onseparateline { get; set; } 

    [JsonProperty("myobtaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Myobtaxcode { get; set; } 

    [JsonProperty("myob_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Myob_details_id { get; set; } 

    [JsonProperty("myob_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Myob_details_name { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("avalara_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("category_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_code { get; set; } 

}