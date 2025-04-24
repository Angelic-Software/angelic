using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StreamOneIonDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Account_id { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Import_entities { get; set; } 

    [JsonProperty("top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Top_level { get; set; } 

    [JsonProperty("update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Update_addresses { get; set; } 

    [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halointegrator { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Client_mappings { get; set; } 

    [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Top_level_name { get; set; } 

    [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Import_entities_list { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}