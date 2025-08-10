using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.Lookups;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Custom.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomField
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Label { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Value { get; set; } 

    [JsonProperty("value_is_password_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValueIsPasswordId { get; set; } 

    [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display { get; set; } 

    [JsonProperty("characterlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CharacterLimit { get; set; } 

    [JsonProperty("characterlimittype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CharacterLimitType { get; set; } 

    [JsonProperty("inputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InputType { get; set; } 

    [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToChild { get; set; } 

    [JsonProperty("copytoparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToParent { get; set; } 

    [JsonProperty("searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Searchable { get; set; } 

    [JsonProperty("ordervalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OrderValues { get; set; } 

    [JsonProperty("ordervaluesby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderValuesBy { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupId { get; set; } 

    [JsonProperty("database_lookup_auto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DatabaseLookupAuto { get; set; } 

    [JsonProperty("database_lookup_triggers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DatabaseLookupField>? DatabaseLookupTriggers { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyName { get; set; } 

    [JsonProperty("extratype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExtraType { get; set; } 

    [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToChildOnUpdate { get; set; } 

    [JsonProperty("copytoparentonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToParentOnUpdate { get; set; } 

    [JsonProperty("hyperlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hyperlink { get; set; } 

    [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Usage { get; set; } 

    [JsonProperty("linked_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedTableId { get; set; } 

    [JsonProperty("showondetailsscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnDetailsScreen { get; set; } 

    [JsonProperty("third_party_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyValue { get; set; } 

    [JsonProperty("custom_extra_table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomExtraTableId { get; set; } 

    [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToRelated { get; set; } 

    [JsonProperty("calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Calculation { get; set; } 

    [JsonProperty("rounding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rounding { get; set; } 

    [JsonProperty("validation_reasons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? ValidationReasons { get; set; } 

    [JsonProperty("int_value_is_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntValueIsDisplay { get; set; } 

    [JsonProperty("regex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Regex { get; set; } 

    [JsonProperty("onlyshowforagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnlyShowForAgents { get; set; } 

    [JsonProperty("is_horizontal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHorizontal { get; set; } 

    [JsonProperty("copied", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copied { get; set; } 

    [JsonProperty("isencrypted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEncrypted { get; set; } 

    [JsonProperty("max_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxSelection { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("selection_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SelectionFieldId { get; set; } 

    [JsonProperty("variable_format_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VariableFormat1 { get; set; } 

    [JsonProperty("variable_format_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VariableFormat2 { get; set; } 

    [JsonProperty("validation_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldValidation>? ValidationData { get; set; } 

    [JsonProperty("database_lookup_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupInput { get; set; } 

    [JsonProperty("table_data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableDataEntryType { get; set; } 

    [JsonProperty("showintable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInTable { get; set; } 

    [JsonProperty("table_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableHeight { get; set; } 

    [JsonProperty("dont_delete_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontDeleteRows { get; set; } 

    [JsonProperty("table_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableMatchingField { get; set; } 

    [JsonProperty("new_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewStorageMethod { get; set; } 

    [JsonProperty("where_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhereSql { get; set; } 

    [JsonProperty("load_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadType { get; set; } 

    [JsonProperty("add_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddRows { get; set; } 

    [JsonProperty("delete_these_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? DeleteTheseRows { get; set; } 

    [JsonProperty("showinpool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInPool { get; set; } 

    [JsonProperty("allow_pool_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowPoolOverride { get; set; } 

}