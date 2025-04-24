using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DattoCommerceDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("new_api_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_api_key { get; set; } 

    [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halointegratorenabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_name { get; set; } 

    [JsonProperty("customer_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Customer_field_mappings { get; set; } 

    [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

    [JsonProperty("quote_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Quote_status_mappings { get; set; } 

    [JsonProperty("create_items_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_items_on_import { get; set; } 

    [JsonProperty("product_supplier_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Product_supplier_on_import { get; set; } 

    [JsonProperty("sostatustoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sostatustoimport { get; set; } 

    [JsonProperty("sostatustoimport_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sostatustoimport_list { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}