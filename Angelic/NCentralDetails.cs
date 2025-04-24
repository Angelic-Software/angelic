using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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
    public int? Toplevel { get; set; } 

    [JsonProperty("dontsyncaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsyncaddr { get; set; } 

    [JsonProperty("defassettypegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defassettypegroup { get; set; } 

    [JsonProperty("defassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defassettypegroup_name { get; set; } 

    [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newmethod { get; set; } 

    [JsonProperty("alerttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alerttickettype { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tickettype_name { get; set; } 

    [JsonProperty("alertticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alertticketuser { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("alertusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alertusername { get; set; } 

    [JsonProperty("alertclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alertclientid { get; set; } 

    [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Syncentities { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsyncdate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastsyncerror { get; set; } 

    [JsonProperty("reqcredsremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reqcredsremote { get; set; } 

    [JsonProperty("deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deactivateclients { get; set; } 

    [JsonProperty("deactivateassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deactivateassets { get; set; } 

    [JsonProperty("asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_type_choice { get; set; } 

    [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_assettype { get; set; } 

    [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_field { get; set; } 

    [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

    [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_assettype_name { get; set; } 

    [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Client_links { get; set; } 

    [JsonProperty("site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Site_links { get; set; } 

    [JsonProperty("asset_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Asset_fieldmappings { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_password { get; set; } 

    [JsonProperty("new_alert_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_alert_password { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("automaticclientsitelink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Automaticclientsitelink { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("login_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Login_port { get; set; } 

    [JsonProperty("match_user_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Match_user_device { get; set; } 

    [JsonProperty("ignore_probes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignore_probes { get; set; } 

}