using System.CodeDom.Compiler;
using Angelic.Configuration.Custom.CustomFields;
using Angelic.Configuration.Integrations.Quickbooks;
using Angelic.KeyPairs;
using Angelic.Sites;
using Newtonsoft.Json;

namespace Angelic.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Item
{
    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeMatchingFieldName { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetgroupId { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetgroupName { get; set; } 

    [JsonProperty("third_party_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyAssetgroupId { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierPartCode { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseDescription { get; set; } 

    [JsonProperty("internalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Internalreference { get; set; } 

    [JsonProperty("externalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Externalreference { get; set; } 

    [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityInStock { get; set; } 

    [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityReserved { get; set; } 

    [JsonProperty("quantity_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityOnOrder { get; set; } 

    [JsonProperty("goodsinunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Goodsinunit { get; set; } 

    [JsonProperty("goodsoutunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Goodsoutunit { get; set; } 

    [JsonProperty("inoutconversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inoutconversion { get; set; } 

    [JsonProperty("qtyissuedthisyear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Qtyissuedthisyear { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasePrice { get; set; } 

    [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedBy { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("manufacturer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ManufacturerId { get; set; } 

    [JsonProperty("manufacturer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ManufacturerName { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeId { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeName { get; set; } 

    [JsonProperty("minstockqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Minstockqty { get; set; } 

    [JsonProperty("min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinPurchaseQty { get; set; } 

    [JsonProperty("secondprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Secondprice { get; set; } 

    [JsonProperty("promptforprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Promptforprice { get; set; } 

    [JsonProperty("sleeveprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Sleeveprice { get; set; } 

    [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcode { get; set; } 

    [JsonProperty("taxcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxcodeName { get; set; } 

    [JsonProperty("taxcodeother", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcodeother { get; set; } 

    [JsonProperty("taxcodeother_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxcodeotherName { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostPrice { get; set; } 

    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsId { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Margin { get; set; } 

    [JsonProperty("reorderqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Reorderqty { get; set; } 

    [JsonProperty("binlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Binlocation { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("costingmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Costingmethod { get; set; } 

    [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Servicefee { get; set; } 

    [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recovery { get; set; } 

    [JsonProperty("avco", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Avco { get; set; } 

    [JsonProperty("qtyonallsalesorders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Qtyonallsalesorders { get; set; } 

    [JsonProperty("doesnotneedconsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Doesnotneedconsigning { get; set; } 

    [JsonProperty("shaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Shaccountsid { get; set; } 

    [JsonProperty("applydiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applydiscount { get; set; } 

    [JsonProperty("secondhandprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Secondhandprice { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("markupperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Markupperc { get; set; } 

    [JsonProperty("metertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Metertype { get; set; } 

    [JsonProperty("meterlife", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Meterlife { get; set; } 

    [JsonProperty("isrecurringitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isrecurringitem { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TemplateId { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TemplateName { get; set; } 

    [JsonProperty("recurringprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recurringprice { get; set; } 

    [JsonProperty("showmobilescanner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMobilescanner { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("icon_download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconDownloadUrl { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("group_third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupThirdPartyId { get; set; } 

    [JsonProperty("sagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sagetoken { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("item_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemSupplier>? ItemSuppliers { get; set; } 

    [JsonProperty("xero_salestax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroSalestax { get; set; } 

    [JsonProperty("xero_purchasetax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroPurchasetax { get; set; } 

    [JsonProperty("purchasenominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchasenominalcode { get; set; } 

    [JsonProperty("fullyqualifiedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fullyqualifiedname { get; set; } 

    [JsonProperty("salestaxincluded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Salestaxincluded { get; set; } 

    [JsonProperty("purchasetaxincluded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Purchasetaxincluded { get; set; } 

    [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Taxable { get; set; } 

    [JsonProperty("assetaccountcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetaccountcode { get; set; } 

    [JsonProperty("qbo_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboQuantity { get; set; } 

    [JsonProperty("qboinitial_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? QboinitialQuantityDate { get; set; } 

    [JsonProperty("stocklocations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteList>? Stocklocations { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantId { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantName { get; set; } 

    [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XerodetailsId { get; set; } 

    [JsonProperty("income_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IncomeAccountName { get; set; } 

    [JsonProperty("expense_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExpenseAccountName { get; set; } 

    [JsonProperty("asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetAccountName { get; set; } 

    [JsonProperty("income_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? IncomeAccount { get; set; } 

    [JsonProperty("expense_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ExpenseAccount { get; set; } 

    [JsonProperty("asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? AssetAccount { get; set; } 

    [JsonProperty("qbosku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbosku { get; set; } 

    [JsonProperty("qbocategoryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocategoryid { get; set; } 

    [JsonProperty("qbocategoryname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocategoryname { get; set; } 

    [JsonProperty("qbo_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? QboCategory { get; set; } 

    [JsonProperty("autotaskserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskserviceid { get; set; } 

    [JsonProperty("autotaskproductid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskproductid { get; set; } 

    [JsonProperty("iscontractitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscontractitem { get; set; } 

    [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontinvoice { get; set; } 

    [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflowid { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowTenantId { get; set; } 

    [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KashflowTenantName { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalcodeName { get; set; } 

    [JsonProperty("purchasenominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchasenominalcodeName { get; set; } 

    [JsonProperty("linked_item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedItemId { get; set; } 

    [JsonProperty("linked_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedItemName { get; set; } 

    [JsonProperty("update_recurring_invoice_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateRecurringInvoicePrice { get; set; } 

    [JsonProperty("update_recurring_invoice_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateRecurringInvoiceCost { get; set; } 

    [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnelstartId { get; set; } 

    [JsonProperty("snelstart_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnelstartDepartmentId { get; set; } 

    [JsonProperty("snelstart_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnelstartDepartmentName { get; set; } 

    [JsonProperty("snelstart_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? SnelstartDepartment { get; set; } 

    [JsonProperty("linked_asset_defaults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemDeviceDefaults>? LinkedAssetDefaults { get; set; } 

    [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Maxitemdiscount { get; set; } 

    [JsonProperty("item_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemDefaultBillingPeriod { get; set; } 

    [JsonProperty("primaryimageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Primaryimageid { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("lastmodified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastmodified { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyId { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; } 

    [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuickBooksDetails? QuickbooksDetails { get; set; } 

    [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyName { get; set; } 

    [JsonProperty("extra_invoice_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? ExtraInvoiceDescription { get; set; } 

    [JsonProperty("isitemdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isitemdetails { get; set; } 

    [JsonProperty("intacct_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctType { get; set; } 

    [JsonProperty("item_group_nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupNominalcode { get; set; } 

    [JsonProperty("item_group_nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupNominalcodePurchase { get; set; } 

    [JsonProperty("item_group_itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroupItemcode { get; set; } 

    [JsonProperty("item_group_taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroupTaxcode { get; set; } 

    [JsonProperty("item_group_taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroupTaxcodePurchase { get; set; } 

    [JsonProperty("recurringcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recurringcost { get; set; } 

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyId { get; set; } 

    [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SageBusinessCloudDetailsId { get; set; } 

    [JsonProperty("sage_business_cloud_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SageBusinessCloudDetailsName { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BudgetTypeId { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BudgetTypeName { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SerialiseOnlyOne { get; set; } 

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExactDivision { get; set; } 

    [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExactDivisionName { get; set; } 

    [JsonProperty("dattocommerce_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattocommerceTenant { get; set; } 

    [JsonProperty("user_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserDescription { get; set; } 

    [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Weight { get; set; } 

    [JsonProperty("ignore_from_accounting_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreFromAccountingSync { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceClass { get; set; } 

    [JsonProperty("sage50uk_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage50UkDepartmentId { get; set; } 

    [JsonProperty("dont_track_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontTrackStock { get; set; } 

    [JsonProperty("dont_receive_on_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontReceiveOnPo { get; set; } 

    [JsonProperty("xero_inventory_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroInventoryAccountCode { get; set; } 

    [JsonProperty("xero_cogs_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCogsAccountCode { get; set; } 

    [JsonProperty("xero_inventory_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroInventoryAccountCodeName { get; set; } 

    [JsonProperty("xero_cogs_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCogsAccountCodeName { get; set; } 

    [JsonProperty("intacct_product_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctProductLineId { get; set; } 

    [JsonProperty("_updateitemtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Updateitemtype { get; set; } 

    [JsonProperty("related_item_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelatedItemCount { get; set; } 

    [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MyobTenant { get; set; } 

    [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MyobTenantName { get; set; } 

    [JsonProperty("myob_asset_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MyobAssetAccountCode { get; set; } 

    [JsonProperty("items_per_buying_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemsPerBuyingPrice { get; set; } 

    [JsonProperty("items_per_selling_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemsPerSellingPrice { get; set; } 

    [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraItemCode { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseCurrencyCode { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseCurrencyCodeName { get; set; } 

    [JsonProperty("purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Currency? PurchaseCurrency { get; set; } 

    [JsonProperty("autorenew_quote_line_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutorenewQuoteLineDefault { get; set; } 

    [JsonProperty("price_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PriceCalculatedFromComponents { get; set; } 

    [JsonProperty("cost_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CostCalculatedFromComponents { get; set; } 

    [JsonProperty("auto_reorder_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoReorderType { get; set; } 

    [JsonProperty("relatedcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IdValueKeyPair>? Relatedcategories { get; set; } 

    [JsonProperty("relatedcategories_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedcategoriesList { get; set; } 

    [JsonProperty("item_listed_only_on_bundle_setup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemListedOnlyOnBundleSetup { get; set; } 

}