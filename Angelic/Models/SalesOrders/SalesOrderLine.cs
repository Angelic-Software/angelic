using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Billing.Taxes;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Tickets;
using Newtonsoft.Json;

namespace Angelic.Models.SalesOrders;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SalesOrderLine
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SortSeq { get; set; } 

    [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupSortSeq { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productcode { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetGroupName { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeId { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostPrice { get; set; } 

    [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Profit { get; set; } 

    [JsonProperty("profit_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ProfitPercentage { get; set; } 

    [JsonProperty("quantity_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityShipped { get; set; } 

    [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityReserved { get; set; } 

    [JsonProperty("invoiced_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? InvoicedQuantity { get; set; } 

    [JsonProperty("quantity_on_open_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityOnOpenPo { get; set; } 

    [JsonProperty("total_costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostPrice { get; set; } 

    [JsonProperty("total_profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfit { get; set; } 

    [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceMonthly { get; set; } 

    [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalMonthly { get; set; } 

    [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostPriceMonthly { get; set; } 

    [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitMonthly { get; set; } 

    [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxMonthly { get; set; } 

    [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceAnnual { get; set; } 

    [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalAnnual { get; set; } 

    [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostPriceAnnual { get; set; } 

    [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitAnnual { get; set; } 

    [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxAnnual { get; set; } 

    [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceYearone { get; set; } 

    [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalYearone { get; set; } 

    [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostPriceYearone { get; set; } 

    [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitYearone { get; set; } 

    [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxYearone { get; set; } 

    [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unit { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StocklocationId { get; set; } 

    [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StocklocationName { get; set; } 

    [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityInStock { get; set; } 

    [JsonProperty("total_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalQuantityInStock { get; set; } 

    [JsonProperty("total_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalQuantityReserved { get; set; } 

    [JsonProperty("selected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Selected { get; set; } 

    [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Servicefee { get; set; } 

    [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recovery { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Margin { get; set; } 

    [JsonProperty("poqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Poqty { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriod { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoRenew { get; set; } 

    [JsonProperty("recurringinvoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceId { get; set; } 

    [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemRecurring { get; set; } 

    [JsonProperty("line_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LineRecurring { get; set; } 

    [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemContract { get; set; } 

    [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTemplate { get; set; } 

    [JsonProperty("item_budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemBudgetType { get; set; } 

    [JsonProperty("item_doesnotneedconsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemDoesNotNeedConsigning { get; set; } 

    [JsonProperty("supplier_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierPo { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("consignment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? ConsignmentIds { get; set; } 

    [JsonProperty("quotation_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotationLineId { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CostCentre { get; set; } 

    [JsonProperty("project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProjectId { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractRef { get; set; } 

    [JsonProperty("do_not_invoice_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotInvoiceLine { get; set; } 

    [JsonProperty("item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemDescription { get; set; } 

    [JsonProperty("item_purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemPurchaseDescription { get; set; } 

    [JsonProperty("item_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemNote { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemInternalReference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemExternalReference { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemTaxName { get; set; } 

    [JsonProperty("item_min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemMinPurchaseQty { get; set; } 

    [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreatePo { get; set; } 

    [JsonProperty("_create_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateTicket { get; set; } 

    [JsonProperty("quantity_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityToReserve { get; set; } 

    [JsonProperty("assets_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? AssetsToReserve { get; set; } 

    [JsonProperty("reserved_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? ReservedAssets { get; set; } 

    [JsonProperty("consigned_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? ConsignedAssets { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("soitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Soitemurl { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LineSiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserId { get; set; } 

    [JsonProperty("sales_order_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SalesOrderTicketId { get; set; } 

    [JsonProperty("sales_order_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SalesOrderDate { get; set; } 

    [JsonProperty("sales_order_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderStatus { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClass { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClassName { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinePeriods { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideItems { get; set; } 

    [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isleased { get; set; } 

    [JsonProperty("addbudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addbudget { get; set; } 

    [JsonProperty("add_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddChildTemplates { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("isfreightline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfreightline { get; set; } 

    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeMatchingFieldName { get; set; } 

    [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemsInGroupNoConsign { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SerialiseOnlyOne { get; set; } 

    [JsonProperty("invoice_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? InvoiceIds { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentageInvoiced { get; set; } 

    [JsonProperty("item_weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemWeight { get; set; } 

    [JsonProperty("create_child_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateChildProject { get; set; } 

    [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Taxable { get; set; } 

    [JsonProperty("project_child_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProjectChildFaultId { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreateInvoicePercentage { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBundledLine { get; set; } 

    [JsonProperty("dattocommercelineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommercelineid { get; set; } 

    [JsonProperty("line_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LineTicketId { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDeferredRevenue { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? ChargeRates { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketBudget>? Budgets { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideGroupedItemsPrice { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountPerc { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseCurrencyCode { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostConverted { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseCurrencyCodeName { get; set; } 

    [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseCurrencySymbol { get; set; } 

    [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PurchaseConversionRate { get; set; } 

    [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeAutoIncrease { get; set; } 

    [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoIncreasePeriod { get; set; } 

    [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentIncrease { get; set; } 

    [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseRpiIncrease { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetTotal { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxConverted { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxConverted { get; set; } 

    [JsonProperty("mark_as_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MarkAsComplete { get; set; } 

    [JsonProperty("consignment_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? ConsignmentAddress { get; set; } 

    [JsonProperty("budget_add_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BudgetAddType { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasePriceConverted { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasePrice { get; set; } 

    [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceMonthlyConverted { get; set; } 

    [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceAnnualConverted { get; set; } 

    [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceYearoneConverted { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTax { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPrice { get; set; } 

    [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscount { get; set; } 

    [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionRate { get; set; } 

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
    public int? Decimalplacesforinvoices { get; set; } 

    [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotal { get; set; } 

}