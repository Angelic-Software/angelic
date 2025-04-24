using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WordpressOrgDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connectionname { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_integration_method { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("new_app_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_app_password { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("blogurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Blogurl { get; set; } 

    [JsonProperty("import_this_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_this_tag { get; set; } 

    [JsonProperty("post_status_to_import", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Post_status_to_import { get; set; } 

    [JsonProperty("custom_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Custom_endpoint { get; set; } 

    [JsonProperty("use_custom_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_custom_endpoint { get; set; } 

    [JsonProperty("import_this_tag_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Import_this_tag_name { get; set; } 

    [JsonProperty("default_faqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_faqlist { get; set; } 

    [JsonProperty("default_faqlist_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_faqlist_name { get; set; } 

    [JsonProperty("importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Importcategories { get; set; } 

    [JsonProperty("nocategoryupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Nocategoryupdate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}