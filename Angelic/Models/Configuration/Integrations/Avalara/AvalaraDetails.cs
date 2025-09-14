using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Avalara;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AvalaraDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("environment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Environment { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPassword { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CompanyId { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierTopLevel { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierTopLevelName { get; set; } 

    [JsonProperty("company_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public StringIdNameKeyPair? CompanyObject { get; set; } 

    [JsonProperty("defaulttax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTax { get; set; } 

    [JsonProperty("defaultitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultItem { get; set; } 

    [JsonProperty("autosyncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoSyncEntities { get; set; } 

    [JsonProperty("autosyncentitiesonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoSyncEntitiesOnUpdate { get; set; } 

    [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("defaultcustomercode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCustomerCode { get; set; } 

    [JsonProperty("default_customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCustomerName { get; set; } 

    [JsonProperty("disablerecording", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableRecording { get; set; } 

    [JsonProperty("address_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddressMappingType { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("sync_committed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncCommitted { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}