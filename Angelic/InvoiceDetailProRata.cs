using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetailProRata
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoicedetailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoicedetailid { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("client_to_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_to_invoice_id { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

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
    public int? Quantity_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_id { get; set; } 

    [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prorata_next_invoice { get; set; } 

    [JsonProperty("invoiceheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoiceheaderid { get; set; } 

    [JsonProperty("dont_auto_calculate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_auto_calculate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("isinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isinvoiced { get; set; } 

    [JsonProperty("isfuturepr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfuturepr { get; set; } 

    [JsonProperty("inv_manual_pr_immediately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inv_manual_pr_immediately { get; set; } 

    [JsonProperty("change_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Change_id { get; set; } 

    [JsonProperty("istempprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Istempprorata { get; set; } 

    [JsonProperty("include_in_roi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include_in_roi { get; set; } 

}