using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.NCentral;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NCentralDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevel { get; set; } 

    [JsonProperty("dontsyncaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSyncaddr { get; set; } 

    [JsonProperty("defassettypegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defassettypegroup { get; set; } 

    [JsonProperty("defassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefassettypegroupName { get; set; } 

    [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newmethod { get; set; } 

    [JsonProperty("alerttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alerttickettype { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("alertticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alertticketuser { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("alertusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alertusername { get; set; } 

    [JsonProperty("alertclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alertclientid { get; set; } 

    [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncEntities { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastSyncDate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastSyncEror { get; set; } 

    [JsonProperty("reqcredsremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reqcredsremote { get; set; } 

    [JsonProperty("deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deactivateclients { get; set; } 

    [JsonProperty("deactivateassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deactivateassets { get; set; } 

    [JsonProperty("asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeChoice { get; set; } 

    [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetType { get; set; } 

    [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeField { get; set; } 

    [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeMapping>? MappingsXType { get; set; } 

    [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetTypeName { get; set; } 

    [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ClientLinks { get; set; } 

    [JsonProperty("site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? SiteLinks { get; set; } 

    [JsonProperty("asset_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? AssetFieldMappings { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPassword { get; set; } 

    [JsonProperty("new_alert_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAlertPassword { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("automaticclientsitelink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Automaticclientsitelink { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("login_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoginPort { get; set; } 

    [JsonProperty("match_user_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchUserDevice { get; set; } 

    [JsonProperty("ignore_probes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreProbes { get; set; } 

}