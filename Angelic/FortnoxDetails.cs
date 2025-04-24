using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FortnoxDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Token_expiry { get; set; } 

    [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isauthorized { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_top_level { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_top_level_name { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_message { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sync_entities { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}