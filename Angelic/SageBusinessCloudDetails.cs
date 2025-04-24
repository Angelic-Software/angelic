using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SageBusinessCloudDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Tokenexpiry { get; set; } 

    [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isauthorized { get; set; } 

    [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirecturi { get; set; } 

    [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clienttoplevel { get; set; } 

    [JsonProperty("itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itemgroup { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablesync { get; set; } 

    [JsonProperty("defaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultitemcode { get; set; } 

    [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showmessage { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Syncentities { get; set; } 

    [JsonProperty("sbcdnewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sbcdnewmethod { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_name { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _disconnect { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_top_level_name { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

    [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Item_group_mappings { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}