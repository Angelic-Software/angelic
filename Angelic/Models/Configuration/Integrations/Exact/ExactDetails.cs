using System.CodeDom.Compiler;
using Angelic.Models.ExternalLinks;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Exact;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ExactDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAuthorized { get; set; } 

    [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroup { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableSync { get; set; } 

    [JsonProperty("defaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultItemCode { get; set; } 

    [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("exdnewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExdNewMethod { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupName { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disconnect { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ClientMappings { get; set; } 

    [JsonProperty("item_group_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ItemGroupMappings { get; set; } 

    [JsonProperty("locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Locale { get; set; } 

    [JsonProperty("division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Division { get; set; } 

    [JsonProperty("division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DivisionName { get; set; } 

    [JsonProperty("division_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExactDivision? DivisionObject { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}