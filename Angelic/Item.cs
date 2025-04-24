using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Item
{
    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_type_matching_field_name { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetgroup_id { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetgroup_name { get; set; } 

    [JsonProperty("third_party_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_assetgroup_id { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_part_code { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_description { get; set; } 

    [JsonProperty("internalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Internalreference { get; set; } 

    [JsonProperty("externalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Externalreference { get; set; } 

    [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_in_stock { get; set; } 

    [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_reserved { get; set; } 

    [JsonProperty("quantity_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_on_order { get; set; } 

    [JsonProperty("goodsinunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Goodsinunit { get; set; } 

    [JsonProperty("goodsoutunit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Goodsoutunit { get; set; } 

    [JsonProperty("inoutconversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inoutconversion { get; set; } 

    [JsonProperty("qtyissuedthisyear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Qtyissuedthisyear { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice { get; set; } 

    [JsonProperty("created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Created_by { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("manufacturer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Manufacturer_id { get; set; } 

    [JsonProperty("manufacturer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Manufacturer_name { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_name { get; set; } 

    [JsonProperty("minstockqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Minstockqty { get; set; } 

    [JsonProperty("min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Min_purchase_qty { get; set; } 

    [JsonProperty("secondprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Secondprice { get; set; } 

    [JsonProperty("promptforprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Promptforprice { get; set; } 

    [JsonProperty("sleeveprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Sleeveprice { get; set; } 

    [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcode { get; set; } 

    [JsonProperty("taxcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Taxcode_name { get; set; } 

    [JsonProperty("taxcodeother", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcodeother { get; set; } 

    [JsonProperty("taxcodeother_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Taxcodeother_name { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsid { get; set; } 

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
    public int? Template_id { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Template_name { get; set; } 

    [JsonProperty("recurringprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recurringprice { get; set; } 

    [JsonProperty("showmobilescanner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showmobilescanner { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("icon_download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon_download_url { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("group_third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_third_party_id { get; set; } 

    [JsonProperty("sagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sagetoken { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("item_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemSupplier>? Item_suppliers { get; set; } 

    [JsonProperty("xero_salestax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_salestax { get; set; } 

    [JsonProperty("xero_purchasetax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_purchasetax { get; set; } 

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
    public int? Qbo_quantity { get; set; } 

    [JsonProperty("qboinitial_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Qboinitial_quantity_date { get; set; } 

    [JsonProperty("stocklocations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Site_List>? Stocklocations { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_id { get; set; } 

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_name { get; set; } 

    [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Xerodetails_id { get; set; } 

    [JsonProperty("income_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Income_account_name { get; set; } 

    [JsonProperty("expense_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Expense_account_name { get; set; } 

    [JsonProperty("asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_account_name { get; set; } 

    [JsonProperty("income_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Income_account { get; set; } 

    [JsonProperty("expense_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Expense_account { get; set; } 

    [JsonProperty("asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Asset_account { get; set; } 

    [JsonProperty("qbosku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbosku { get; set; } 

    [JsonProperty("qbocategoryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocategoryid { get; set; } 

    [JsonProperty("qbocategoryname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbocategoryname { get; set; } 

    [JsonProperty("qbo_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Qbo_category { get; set; } 

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
    public int? Kashflow_tenant_id { get; set; } 

    [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflow_tenant_name { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_name { get; set; } 

    [JsonProperty("purchasenominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchasenominalcode_name { get; set; } 

    [JsonProperty("linked_item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_item_id { get; set; } 

    [JsonProperty("linked_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_item_name { get; set; } 

    [JsonProperty("update_recurring_invoice_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Update_recurring_invoice_price { get; set; } 

    [JsonProperty("update_recurring_invoice_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Update_recurring_invoice_cost { get; set; } 

    [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snelstart_id { get; set; } 

    [JsonProperty("snelstart_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snelstart_department_id { get; set; } 

    [JsonProperty("snelstart_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snelstart_department_name { get; set; } 

    [JsonProperty("snelstart_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Snelstart_department { get; set; } 

    [JsonProperty("linked_asset_defaults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemDeviceDefaults>? Linked_asset_defaults { get; set; } 

    [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Maxitemdiscount { get; set; } 

    [JsonProperty("item_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_default_billing_period { get; set; } 

    [JsonProperty("primaryimageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Primaryimageid { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

    [JsonProperty("lastmodified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastmodified { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_id { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_details_id { get; set; } 

    [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuickBooksDetails? Quickbooks_details { get; set; } 

    [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_name { get; set; } 

    [JsonProperty("extra_invoice_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Extra_invoice_description { get; set; } 

    [JsonProperty("isitemdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isitemdetails { get; set; } 

    [JsonProperty("intacct_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_type { get; set; } 

    [JsonProperty("item_group_nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_nominalcode { get; set; } 

    [JsonProperty("item_group_nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_nominalcode_purchase { get; set; } 

    [JsonProperty("item_group_itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group_itemcode { get; set; } 

    [JsonProperty("item_group_taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group_taxcode { get; set; } 

    [JsonProperty("item_group_taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group_taxcode_purchase { get; set; } 

    [JsonProperty("recurringcost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recurringcost { get; set; } 

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dbc_company_id { get; set; } 

    [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dbc_company_name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? External_links { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage_business_cloud_details_id { get; set; } 

    [JsonProperty("sage_business_cloud_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage_business_cloud_details_name { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgettype_id { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Budgettype_name { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Serialise_only_one { get; set; } 

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Exact_division { get; set; } 

    [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exact_division_name { get; set; } 

    [JsonProperty("dattocommerce_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dattocommerce_tenant { get; set; } 

    [JsonProperty("user_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_description { get; set; } 

    [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Weight { get; set; } 

    [JsonProperty("ignore_from_accounting_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignore_from_accounting_sync { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_class { get; set; } 

    [JsonProperty("sage50uk_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage50uk_department_id { get; set; } 

    [JsonProperty("dont_track_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_track_stock { get; set; } 

    [JsonProperty("dont_receive_on_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_receive_on_po { get; set; } 

    [JsonProperty("xero_inventory_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_inventory_account_code { get; set; } 

    [JsonProperty("xero_cogs_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_cogs_account_code { get; set; } 

    [JsonProperty("xero_inventory_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_inventory_account_code_name { get; set; } 

    [JsonProperty("xero_cogs_account_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_cogs_account_code_name { get; set; } 

    [JsonProperty("intacct_product_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_product_line_id { get; set; } 

    [JsonProperty("_updateitemtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _updateitemtype { get; set; } 

    [JsonProperty("related_item_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Related_item_count { get; set; } 

    [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Myob_tenant { get; set; } 

    [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Myob_tenant_name { get; set; } 

    [JsonProperty("myob_asset_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Myob_asset_account_code { get; set; } 

    [JsonProperty("items_per_buying_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Items_per_buying_price { get; set; } 

    [JsonProperty("items_per_selling_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Items_per_selling_price { get; set; } 

    [JsonProperty("avalara_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_item_code { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchase_currency_code { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_currency_code_name { get; set; } 

    [JsonProperty("purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Currency? Purchase_currency { get; set; } 

    [JsonProperty("autorenew_quote_line_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew_quote_line_default { get; set; } 

    [JsonProperty("price_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Price_calculated_from_components { get; set; } 

    [JsonProperty("cost_calculated_from_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cost_calculated_from_components { get; set; } 

    [JsonProperty("auto_reorder_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_reorder_type { get; set; } 

    [JsonProperty("relatedcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IdValueKeyPair>? Relatedcategories { get; set; } 

    [JsonProperty("relatedcategories_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Relatedcategories_list { get; set; } 

    [JsonProperty("item_listed_only_on_bundle_setup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_listed_only_on_bundle_setup { get; set; } 

}