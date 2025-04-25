using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Areas;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AreaItem
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity { get; set; } 

    [JsonProperty("areaitemdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Areaitemdesc { get; set; } 

    [JsonProperty("billingperiod_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriodId { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoicenumber { get; set; } 

    [JsonProperty("lastinvoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastinvoicedate { get; set; } 

    [JsonProperty("nextinvoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextinvoicedate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostPrice { get; set; } 

    [JsonProperty("sellingprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Sellingprice { get; set; } 

    [JsonProperty("accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsId { get; set; } 

    [JsonProperty("numberdayswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Numberdayswarning { get; set; } 

    [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dsite { get; set; } 

    [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ddevnum { get; set; } 

    [JsonProperty("technician", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technician { get; set; } 

    [JsonProperty("billingcategory_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingcategoryId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontinvoice { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}