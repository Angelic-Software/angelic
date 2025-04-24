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
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isauthorized { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroup { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exchangecode { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importtype { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}