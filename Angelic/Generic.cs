using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Generic
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("islan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IsLan { get; set; } 

    [JsonProperty("connector", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Connector { get; set; } 

    [JsonProperty("showasitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showasitem { get; set; } 

    [JsonProperty("showasequip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showasequip { get; set; } 

    [JsonProperty("showwarningifonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showwarningifonrequest { get; set; } 

    [JsonProperty("moveassetonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Moveassetonrequest { get; set; } 

    [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultsite { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kaseyaid { get; set; } 

    [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Items_in_group_no_consign { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XType>? Assettypes { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyid { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("isfixedasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfixedasset { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_name { get; set; } 

    [JsonProperty("nominalcodepurchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcodepurchase { get; set; } 

    [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_name_purchase { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("tcsnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tcsnote { get; set; } 

    [JsonProperty("accounts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GenericAccountsMappings>? Accounts_mappings { get; set; } 

    [JsonProperty("tax_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tax_id { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_name { get; set; } 

    [JsonProperty("tax_id_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tax_id_purchase { get; set; } 

    [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_name_purchase { get; set; } 

    [JsonProperty("itemcode_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemcode_id { get; set; } 

    [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemcode_name { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_details_id { get; set; } 

    [JsonProperty("multipleaccountstenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multipleaccountstenants { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_class { get; set; } 

    [JsonProperty("qbo_item_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qbo_item_type { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("item_recurring_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_recurring_default { get; set; } 

    [JsonProperty("item_donttrackstock_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_donttrackstock_default { get; set; } 

    [JsonProperty("item_doesnotneedconsigning_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_doesnotneedconsigning_default { get; set; } 

    [JsonProperty("item_contract_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_contract_default { get; set; } 

    [JsonProperty("item_assettype_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_assettype_default { get; set; } 

    [JsonProperty("item_billing_period_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_billing_period_default { get; set; } 

    [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_item_code { get; set; } 

    [JsonProperty("item_assettype_name_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_assettype_name_default { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup_name { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup_name { get; set; } 

}