using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Kashflow;

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
    public string? NewPassword { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("client_item_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientItemTax { get; set; } 

    [JsonProperty("client_service_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientServiceTax { get; set; } 

    [JsonProperty("client_contract_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientContractTax { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroup { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupName { get; set; } 

    [JsonProperty("isdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isdefault { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablesync { get; set; } 

    [JsonProperty("default_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultItemCode { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("client_item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientItemTaxName { get; set; } 

    [JsonProperty("client_service_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientServiceTaxName { get; set; } 

    [JsonProperty("client_contract_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientContractTaxName { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierTopLevel { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierTopLevelName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}