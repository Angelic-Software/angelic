using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetailQuantity
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceLineId { get; set; } 

    [JsonProperty("kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kind { get; set; } 

    [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TypeId { get; set; } 

    [JsonProperty("device_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceGroupId { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TypeName { get; set; } 

    [JsonProperty("device_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceGroupName { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceId { get; set; } 

    [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceName { get; set; } 

    [JsonProperty("assigned_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssignedLicences { get; set; } 

    [JsonProperty("qty_free", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QtyFree { get; set; } 

    [JsonProperty("minimum_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinimumQty { get; set; } 

    [JsonProperty("pro_rata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProRata { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantityCriteria>? Criteria { get; set; } 

    [JsonProperty("use_linked_subscription_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseLinkedSubscriptionPrice { get; set; } 

    [JsonProperty("use_linked_subscription_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseLinkedSubscriptionCost { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}