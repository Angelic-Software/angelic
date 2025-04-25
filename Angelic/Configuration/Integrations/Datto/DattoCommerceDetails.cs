using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Datto;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DattoCommerceDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("new_api_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewApiKey { get; set; } 

    [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloIntegratorenabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroup { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupName { get; set; } 

    [JsonProperty("customer_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? CustomerFieldMappings { get; set; } 

    [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ItemGroupMappings { get; set; } 

    [JsonProperty("quote_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? QuoteStatusMappings { get; set; } 

    [JsonProperty("create_items_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateItemsOnImport { get; set; } 

    [JsonProperty("product_supplier_on_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProductSupplierOnImport { get; set; } 

    [JsonProperty("sostatustoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sostatustoimport { get; set; } 

    [JsonProperty("sostatustoimport_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SostatustoimportList { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}