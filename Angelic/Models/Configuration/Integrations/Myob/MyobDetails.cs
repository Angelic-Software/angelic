using System.CodeDom.Compiler;
using Angelic.Models.ExternalLinks;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Myob;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class MyobDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("isdesktop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDesktop { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("company_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyUrl { get; set; } 

        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyId { get; set; } 

        [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyName { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewClientSecret { get; set; } 

        [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchangecode { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientId { get; set; } 

        [JsonProperty("defaulttaxcodeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTaxcodeid { get; set; } 

        [JsonProperty("defaulttaxcodename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTaxcodename { get; set; } 

        [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clienttoplevel { get; set; } 

        [JsonProperty("defaultitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultItemGroup { get; set; } 

        [JsonProperty("defaultsalesaccountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSalesaccountid { get; set; } 

        [JsonProperty("defaultsalesaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSalesaccountname { get; set; } 

        [JsonProperty("defaultexpenseaccountid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultExpenseaccountid { get; set; } 

        [JsonProperty("defaultexpenseaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultExpenseaccountname { get; set; } 

        [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesync { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncEntities { get; set; } 

        [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMessage { get; set; } 

        [JsonProperty("defaultinvoiceitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultInvoiceitem { get; set; } 

        [JsonProperty("defaultorderitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOrderitem { get; set; } 

        [JsonProperty("suppliertoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Suppliertoplevel { get; set; } 

        [JsonProperty("suppliernamefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Suppliernamefield { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientTopLevelName { get; set; } 

        [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemGroupName { get; set; } 

        [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierTopLevelName { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRefreshToken { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disconnect { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

        [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? ClientMappings { get; set; } 

        [JsonProperty("supplier_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? SupplierMappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }