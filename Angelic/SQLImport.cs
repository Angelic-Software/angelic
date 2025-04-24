using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SQLImport
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Table { get; set; } 

    [JsonProperty("udlpath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Udlpath { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql { get; set; } 

    [JsonProperty("keyfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield { get; set; } 

    [JsonProperty("datafield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datafield1 { get; set; } 

    [JsonProperty("datafield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datafield2 { get; set; } 

    [JsonProperty("datafield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datafield3 { get; set; } 

    [JsonProperty("datafield4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datafield4 { get; set; } 

    [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultsite { get; set; } 

    [JsonProperty("defaultsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultsitename { get; set; } 

    [JsonProperty("lastrundate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastrundate { get; set; } 

    [JsonProperty("nhdfield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhdfield3 { get; set; } 

    [JsonProperty("updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Updateonly { get; set; } 

    [JsonProperty("integrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Integrator_enabled { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SQLImportField>? Fields { get; set; } 

    [JsonProperty("sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sqlserver { get; set; } 

    [JsonProperty("sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sqldatabase { get; set; } 

    [JsonProperty("sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sqlusername { get; set; } 

    [JsonProperty("sisqlpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sisqlpassword { get; set; } 

    [JsonProperty("new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_sql_password { get; set; } 

    [JsonProperty("useusers_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useusers_site { get; set; } 

    [JsonProperty("dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontupdatesite { get; set; } 

    [JsonProperty("dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontremoveusers { get; set; } 

    [JsonProperty("canupdaterecords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canupdaterecords { get; set; } 

    [JsonProperty("syncto3party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Syncto3party { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("halointegrator_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Halointegrator_allowed_clientids_list { get; set; } 

    [JsonProperty("halointegrator_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_allowed_clientids { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_access { get; set; } 

    [JsonProperty("include_linux_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include_linux_software { get; set; } 

    [JsonProperty("dontupdatetoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontupdatetoplevel { get; set; } 

    [JsonProperty("donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Donotvalidate { get; set; } 

    [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetimportidentifier { get; set; } 

    [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Assetimportidentifier_guid { get; set; } 

    [JsonProperty("assetimportidentifier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetimportidentifier_name { get; set; } 

    [JsonProperty("sql_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sql_provider { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("sql_driver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_driver { get; set; } 

    [JsonProperty("dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontupdatetype { get; set; } 

    [JsonProperty("sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sql_timeout { get; set; } 

    [JsonProperty("sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_port { get; set; } 

    [JsonProperty("import_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Import_table { get; set; } 

    [JsonProperty("import_table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Import_table_name { get; set; } 

    [JsonProperty("entity_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_match_field { get; set; } 

    [JsonProperty("table_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_matching_field { get; set; } 

    [JsonProperty("table_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Table_matching_field_name { get; set; } 

    [JsonProperty("linkto_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linkto_table_id { get; set; } 

    [JsonProperty("table_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_update_type { get; set; } 

    [JsonProperty("match_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Match_accountsid { get; set; } 

}