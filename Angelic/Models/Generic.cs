using System.CodeDom.Compiler;
using Angelic.Models.Configuration;
using Newtonsoft.Json;

namespace Angelic.Models;

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
    public bool? ShowAsItem { get; set; } 

    [JsonProperty("showasequip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAsEquip { get; set; } 

    [JsonProperty("showwarningifonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowWarningifonrequest { get; set; } 

    [JsonProperty("moveassetonrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Moveassetonrequest { get; set; } 

    [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSite { get; set; } 

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; } 

    [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemsInGroupNoConsign { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetType>? AssetTypes { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("isfixedasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfixedasset { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalcodeName { get; set; } 

    [JsonProperty("nominalcodepurchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcodepurchase { get; set; } 

    [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalcodeNamePurchase { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("tcsnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tcsnote { get; set; } 

    [JsonProperty("accounts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GenericAccountsMappings>? AccountsMappings { get; set; } 

    [JsonProperty("tax_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TaxId { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxName { get; set; } 

    [JsonProperty("tax_id_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TaxIdPurchase { get; set; } 

    [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxNamePurchase { get; set; } 

    [JsonProperty("itemcode_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemcodeId { get; set; } 

    [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemcodeName { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; } 

    [JsonProperty("multipleaccountstenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multipleaccountstenants { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceClass { get; set; } 

    [JsonProperty("qbo_item_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboItemType { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("item_recurring_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemRecurringDefault { get; set; } 

    [JsonProperty("item_donttrackstock_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemDontTrackstockDefault { get; set; } 

    [JsonProperty("item_doesnotneedconsigning_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemDoesNotNeedConsigningDefault { get; set; } 

    [JsonProperty("item_contract_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemContractDefault { get; set; } 

    [JsonProperty("item_assettype_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemAssetTypeDefault { get; set; } 

    [JsonProperty("item_billing_period_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemBillingPeriodDefault { get; set; } 

    [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraItemCode { get; set; } 

    [JsonProperty("item_assettype_name_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemAssetTypeNameDefault { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1Lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2Lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1LookupName { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2LookupName { get; set; } 

}