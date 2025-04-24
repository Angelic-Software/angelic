using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OutboundIntegration
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Module_id { get; set; } 

    [JsonProperty("authorizationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Authorizationtype { get; set; } 

    [JsonProperty("granttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Granttype { get; set; } 

    [JsonProperty("authorizationurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authorizationurl { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_password { get; set; } 

    [JsonProperty("tokenurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tokenurl { get; set; } 

    [JsonProperty("scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Scope { get; set; } 

    [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? State { get; set; } 

    [JsonProperty("headername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? Headername { get; set; } 

    [JsonProperty("headerprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(100)]
    public string? Headerprefix { get; set; } 

    [JsonProperty("algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Algorithm { get; set; } 

    [JsonProperty("bearername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bearername { get; set; } 

    [JsonProperty("bearerlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bearerlocation { get; set; } 

    [JsonProperty("resourcebaseurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resourcebaseurl { get; set; } 

    [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Certificate_id { get; set; } 

    [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Certificate_name { get; set; } 

    [JsonProperty("response_token_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Response_token_name { get; set; } 

    [JsonProperty("token_expiry_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Token_expiry_mins { get; set; } 

    [JsonProperty("library_licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Library_licence_name { get; set; } 

    [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon_base64 { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Major_version_number { get; set; } 

    [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Minor_version_number { get; set; } 

    [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Patch_version_number { get; set; } 

    [JsonProperty("version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version_number { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Note { get; set; } 

    [JsonProperty("install_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Install_popup { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("methods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethod>? Methods { get; set; } 

    [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _code { get; set; } 

    [JsonProperty("_verifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _verifier { get; set; } 

    [JsonProperty("_callback_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _callback_uri { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _disconnect { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}