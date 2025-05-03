using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Invoice;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetailProRata
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoicedetailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceDetailid { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_to_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity { get; set; } 

    [JsonProperty("unitprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unitprice { get; set; } 

    [JsonProperty("unitcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unitcost { get; set; } 

    [JsonProperty("shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Shortdescription { get; set; } 

    [JsonProperty("longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Longdescription { get; set; } 

    [JsonProperty("quantity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuantityId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceId { get; set; } 

    [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProrataNextInvoice { get; set; } 

    [JsonProperty("invoiceheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceHeaderId { get; set; } 

    [JsonProperty("dont_auto_calculate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontAutoCalculate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("isinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInvoiced { get; set; } 

    [JsonProperty("isfuturepr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfuturepr { get; set; } 

    [JsonProperty("inv_manual_pr_immediately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvManualPrImmediately { get; set; } 

    [JsonProperty("change_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChangeId { get; set; } 

    [JsonProperty("istempprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Istempprorata { get; set; } 

    [JsonProperty("include_in_roi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeInRoi { get; set; } 

}