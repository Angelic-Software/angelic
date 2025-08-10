using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Custom.CustomTables;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomTable
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("ctfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CustomField? CtField { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("add_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? AddCustomFields { get; set; } 

    [JsonProperty("edit_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? EditCustomFields { get; set; } 

    [JsonProperty("delete_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? DeleteCustomFields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("db_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbName { get; set; } 

    [JsonProperty("linkto_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkToTableId { get; set; } 

    [JsonProperty("linkto_table_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? LinkToTableGuid { get; set; } 

    [JsonProperty("linkto_table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkToTableName { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("import_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportFolder { get; set; } 

    [JsonProperty("data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DataEntryType { get; set; } 

    [JsonProperty("clear_on_close", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClearOnClose { get; set; } 

    [JsonProperty("primary_field_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrimaryField1 { get; set; } 

    [JsonProperty("primary_field_1_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? PrimaryField1Guid { get; set; } 

    [JsonProperty("primary_field_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrimaryField1Name { get; set; } 

    [JsonProperty("primary_field_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrimaryField2 { get; set; } 

    [JsonProperty("primary_field_2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? PrimaryField2Guid { get; set; } 

    [JsonProperty("primary_field_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrimaryField2Name { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldInfo>? Fields { get; set; } 

    [JsonProperty("customextratableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomExtraTableId { get; set; } 

    [JsonProperty("can_load_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanLoadData { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("customtable_orderby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomTableOrderBy { get; set; } 

    [JsonProperty("customtable_orderby_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? CustomTableOrderByGuid { get; set; } 

    [JsonProperty("customtable_orderby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomTableOrderByName { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("import_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportName { get; set; } 

    [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Columns { get; set; } 

}