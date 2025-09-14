using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SqlImports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SqlImport
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
    public string? UdlPath { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql { get; set; } 

    [JsonProperty("keyfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField { get; set; } 

    [JsonProperty("datafield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataField1 { get; set; } 

    [JsonProperty("datafield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataField2 { get; set; } 

    [JsonProperty("datafield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataField3 { get; set; } 

    [JsonProperty("datafield4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataField4 { get; set; } 

    [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSite { get; set; } 

    [JsonProperty("defaultsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSiteName { get; set; } 

    [JsonProperty("lastrundate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastRunDate { get; set; } 

    [JsonProperty("nhdfield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NhdField3 { get; set; } 

    [JsonProperty("updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateOnly { get; set; } 

    [JsonProperty("integrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntegratorEnabled { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SqlImportField>? Fields { get; set; } 

    [JsonProperty("sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlServer { get; set; } 

    [JsonProperty("sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlDatabase { get; set; } 

    [JsonProperty("sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlUsername { get; set; } 

    [JsonProperty("sisqlpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiSqlPassword { get; set; } 

    [JsonProperty("new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSqlPassword { get; set; } 

    [JsonProperty("useusers_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseUsersSite { get; set; } 

    [JsonProperty("dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateSite { get; set; } 

    [JsonProperty("dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontRemoveUsers { get; set; } 

    [JsonProperty("canupdaterecords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdateRecords { get; set; } 

    [JsonProperty("syncto3party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncTo3Party { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("halointegrator_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? HaloIntegratorAllowedClientIdsList { get; set; } 

    [JsonProperty("halointegrator_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorAllowedClientIds { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAccess { get; set; } 

    [JsonProperty("include_linux_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeLinuxSoftware { get; set; } 

    [JsonProperty("dontupdatetoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateToplevel { get; set; } 

    [JsonProperty("donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotValidate { get; set; } 

    [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetImportIdentifier { get; set; } 

    [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AssetImportIdentifierGuid { get; set; } 

    [JsonProperty("assetimportidentifier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetImportIdentifierName { get; set; } 

    [JsonProperty("sql_provider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlProvider { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("sql_driver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlDriver { get; set; } 

    [JsonProperty("dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateType { get; set; } 

    [JsonProperty("sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlTimeout { get; set; } 

    [JsonProperty("sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlPort { get; set; } 

    [JsonProperty("import_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTable { get; set; } 

    [JsonProperty("import_table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportTableName { get; set; } 

    [JsonProperty("entity_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityMatchField { get; set; } 

    [JsonProperty("table_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableMatchingField { get; set; } 

    [JsonProperty("table_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableMatchingFieldName { get; set; } 

    [JsonProperty("linkto_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkToTableId { get; set; } 

    [JsonProperty("table_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableUpdateType { get; set; } 

    [JsonProperty("match_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchAccountsId { get; set; } 

}