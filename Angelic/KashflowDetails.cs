using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class KashflowDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_password { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_top_level { get; set; } 

    [JsonProperty("client_item_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_item_tax { get; set; } 

    [JsonProperty("client_service_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_service_tax { get; set; } 

    [JsonProperty("client_contract_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_contract_tax { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_top_level_name { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_name { get; set; } 

    [JsonProperty("isdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isdefault { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablesync { get; set; } 

    [JsonProperty("default_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_item_code { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_message { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("client_item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_item_tax_name { get; set; } 

    [JsonProperty("client_service_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_service_tax_name { get; set; } 

    [JsonProperty("client_contract_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_contract_tax_name { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_top_level { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_top_level_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}