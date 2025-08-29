using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Billing.Taxes;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Items;
using Newtonsoft.Json;

namespace Angelic.Models.Invoice;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetail
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IhId { get; set; } 

    [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemCode { get; set; } 

    [JsonProperty("item_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemShortDescription { get; set; } 

    [JsonProperty("item_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemLongDescription { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCode { get; set; } 

    [JsonProperty("tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxCode { get; set; } 

    [JsonProperty("qty_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QtyOrder { get; set; } 

    [JsonProperty("unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitPrice { get; set; } 

    [JsonProperty("unit_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitPriceConverted { get; set; } 

    [JsonProperty("net_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetAmount { get; set; } 

    [JsonProperty("tax_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxAmount { get; set; } 

    [JsonProperty("tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxRate { get; set; } 

    [JsonProperty("comment_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment1 { get; set; } 

    [JsonProperty("comment_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment2 { get; set; } 

    [JsonProperty("itemonorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemOnOrder { get; set; } 

    [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DSite { get; set; } 

    [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DDevNum { get; set; } 

    [JsonProperty("_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("productnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductNumber { get; set; } 

    [JsonProperty("unit_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitCost { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetId { get; set; } 

    [JsonProperty("asset_inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetInventoryNumber { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceId { get; set; } 

    [JsonProperty("recurring_invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceLineId { get; set; } 

    [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionCode { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site { get; set; } 

    [JsonProperty("meter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MeterId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("lineactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LineActionDate { get; set; } 

    [JsonProperty("labourdepartmentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LabourDepartmentId { get; set; } 

    [JsonProperty("salesorder_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderLine { get; set; } 

    [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderLineId { get; set; } 

    [JsonProperty("meter_pricing_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MeterPricingMethod { get; set; } 

    [JsonProperty("line_fully_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LineFullyInvoiced { get; set; } 

    [JsonProperty("xero_lineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroLineid { get; set; } 

    [JsonProperty("prepay_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayId { get; set; } 

    [JsonProperty("calculate_price_from_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CalculatePriceFromAssets { get; set; } 

    [JsonProperty("calculate_price_from_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CalculatePriceFromUsers { get; set; } 

    [JsonProperty("creditlinkedidid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreditLinkedIdId { get; set; } 

    [JsonProperty("recurring_invoice_price_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoicePriceType { get; set; } 

    [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityType { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemInternalReference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemExternalReference { get; set; } 

    [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Item? LinkedItem { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemTaxName { get; set; } 

    [JsonProperty("xero_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTaxCode { get; set; } 

    [JsonProperty("override_ast_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OverrideAstTotal { get; set; } 

    [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProRataNextInvoice { get; set; } 

    [JsonProperty("prorata_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProRataQuantity { get; set; } 

    [JsonProperty("prorata_unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProRataUnitPrice { get; set; } 

    [JsonProperty("prorata_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProRataShortDescription { get; set; } 

    [JsonProperty("prorata_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProRataLongDescription { get; set; } 

    [JsonProperty("isinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInactive { get; set; } 

    [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PeriodType { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGroupDesc { get; set; } 

    [JsonProperty("kashflow_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowLineId { get; set; } 

    [JsonProperty("_is_calculated_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCalculatedLine { get; set; } 

    [JsonProperty("tax_code_overriden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TaxCodeOverriden { get; set; } 

    [JsonProperty("is_meter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMeter { get; set; } 

    [JsonProperty("current_reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrentReading { get; set; } 

    [JsonProperty("last_reading_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastReadingDate { get; set; } 

    [JsonProperty("prorata_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailProRata>? ProRataData { get; set; } 

    [JsonProperty("quantity_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? QuantityUsers { get; set; } 

    [JsonProperty("quantity_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? QuantityAssets { get; set; } 

    [JsonProperty("quantity_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? QuantityLicences { get; set; } 

    [JsonProperty("quantity_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? QuantitySubscriptions { get; set; } 

    [JsonProperty("recurring_invoice_quantity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceQuantityType { get; set; } 

    [JsonProperty("quantity_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuantityCustom { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriod { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinePeriods { get; set; } 

    [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentIncrease { get; set; } 

    [JsonProperty("min_meter_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinMeterUnits { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SequenceId { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoRenew { get; set; } 

    [JsonProperty("autorenewperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoRenewPeriod { get; set; } 

    [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctLocationId { get; set; } 

    [JsonProperty("intacct_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDepartmentId { get; set; } 

    [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncedToIntacct { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideItems { get; set; } 

    [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGroupPriceAndQty { get; set; } 

    [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoIncreasePeriod { get; set; } 

    [JsonProperty("auto_increase_last_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AutoIncreaseLastDate { get; set; } 

    [JsonProperty("onetimecharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OneTimeCharge { get; set; } 

    [JsonProperty("onetimechargeinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OneTimeChargeInvoiceId { get; set; } 

    [JsonProperty("needsreviewbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NeedsReviewBeforeCreation { get; set; } 

    [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reviewed { get; set; } 

    [JsonProperty("metertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MeterType { get; set; } 

    [JsonProperty("importcsvid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportCsvId { get; set; } 

    [JsonProperty("force_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceNew { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcId { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; } 

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderLineId { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountPerc { get; set; } 

    [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeAutoIncrease { get; set; } 

    [JsonProperty("createproratanormallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateProRataNormalLines { get; set; } 

    [JsonProperty("createproratadate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreateProRataDate { get; set; } 

    [JsonProperty("pro_rata_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProRataLineId { get; set; } 

    [JsonProperty("supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("hide_on_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideOnPdf { get; set; } 

    [JsonProperty("intacct_warehouse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctWarehouseId { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceClass { get; set; } 

    [JsonProperty("percent_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentInvoiced { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBundledLine { get; set; } 

    [JsonProperty("meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailMeterTiers>? MeterTiers { get; set; } 

    [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MeterMinQuantity { get; set; } 

    [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OriginalClientId { get; set; } 

    [JsonProperty("myob_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MyobLocation { get; set; } 

    [JsonProperty("myob_row_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MyobRowId { get; set; } 

    [JsonProperty("dbc_sequence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DbcSequenceId { get; set; } 

    [JsonProperty("minimum_line_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinimumLineTotal { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideGroupedItemsPrice { get; set; } 

    [JsonProperty("credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreditId { get; set; } 

    [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDeferredRevenue { get; set; } 

    [JsonProperty("deferred_revenue_olid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeferredRevenueOlid { get; set; } 

    [JsonProperty("deferred_revenue_olseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeferredRevenueOlSeq { get; set; } 

    [JsonProperty("is_recognised_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRecognisedRevenue { get; set; } 

    [JsonProperty("no_tax_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoTaxOverride { get; set; } 

    [JsonProperty("_temp_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TempOrderId { get; set; } 

    [JsonProperty("_temp_order_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TempOrderSeq { get; set; } 

    [JsonProperty("_temp_order_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TempOrderQty { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("_updateprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateProRata { get; set; } 

    [JsonProperty("bundle_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BundleId { get; set; } 

    [JsonProperty("bundle_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BundleName { get; set; } 

    [JsonProperty("bundle_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BundleLineId { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1Lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2Lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1LookupName { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2LookupName { get; set; } 

    [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseRpiIncrease { get; set; } 

    [JsonProperty("merge_lines_if_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MergeLinesIfMatched { get; set; } 

    [JsonProperty("surcharge_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SurchargeId { get; set; } 

    [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideTaxCode { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasePriceConverted { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasePrice { get; set; } 

    [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitPriceUNDERSCOREConverted { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxConverted { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetTotal { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxConverted { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTax { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPrice { get; set; } 

    [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscount { get; set; } 

    [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountConverted { get; set; } 

    [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetAmountConverted { get; set; } 

    [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceConverted { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxName { get; set; } 

    [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

    [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DecimalPlacesForInvoices { get; set; } 

    [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotal { get; set; } 

}