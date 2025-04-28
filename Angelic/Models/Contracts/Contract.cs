using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Contract
{
    [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Started { get; set; } 

    [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Expired { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("contract_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractDescription { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("contact_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contact1 { get; set; } 

    [JsonProperty("contact_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contact2 { get; set; } 

    [JsonProperty("contact_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contact3 { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("dontsendalarm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendalarm { get; set; } 

    [JsonProperty("costing_information", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CostingInformation { get; set; } 

    [JsonProperty("is_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefault { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? Assets { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlaName { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("iscontractdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscontractdetails { get; set; } 

    [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractHeaderContract>? Contracts { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? ConfigurationItems { get; set; } 

    [JsonProperty("add_configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? AddConfigurationItems { get; set; } 

    [JsonProperty("renewedfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RenewedfromId { get; set; } 

    [JsonProperty("renewedfrom_id_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RenewedfromIdRef { get; set; } 

    [JsonProperty("renewedby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RenewedbyId { get; set; } 

    [JsonProperty("renewedby_id_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RenewedbyIdRef { get; set; } 

}