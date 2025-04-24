using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FieldInfo
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Label { get; set; } 

    [JsonProperty("labellong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Labellong { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hint { get; set; } 

    [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Custom { get; set; } 

    [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Usage { get; set; } 

    [JsonProperty("usage_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Usage_guid { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_id { get; set; } 

    [JsonProperty("tab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Tab_guid { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tab_name { get; set; } 

    [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_sequence { get; set; } 

    [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_columns { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_id { get; set; } 

    [JsonProperty("table_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Table_guid { get; set; } 

    [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Table_name { get; set; } 

    [JsonProperty("readonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Readonly { get; set; } 

    [JsonProperty("addunknown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addunknown { get; set; } 

    [JsonProperty("extratype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Extratype { get; set; } 

    [JsonProperty("calcfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Calcfield { get; set; } 

    [JsonProperty("characterlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Characterlimit { get; set; } 

    [JsonProperty("characterlimittype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Characterlimittype { get; set; } 

    [JsonProperty("inputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inputtype { get; set; } 

    [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytochild { get; set; } 

    [JsonProperty("copytoparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytoparent { get; set; } 

    [JsonProperty("searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Searchable { get; set; } 

    [JsonProperty("user_searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? User_searchable { get; set; } 

    [JsonProperty("calendar_searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Calendar_searchable { get; set; } 

    [JsonProperty("defaultvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultvalue { get; set; } 

    [JsonProperty("ordervaluesalphanumerically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ordervaluesalphanumerically { get; set; } 

    [JsonProperty("ordervalueby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ordervalueby { get; set; } 

    [JsonProperty("defaultvalue_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultvalue_lookup { get; set; } 

    [JsonProperty("defaultvalue_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomTableRow>? Defaultvalue_table { get; set; } 

    [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Values { get; set; } 

    [JsonProperty("table_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomTableRow>? Table_values { get; set; } 

    [JsonProperty("new_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_values { get; set; } 

    [JsonProperty("variable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Variable_name { get; set; } 

    [JsonProperty("faults_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Faults_field_name { get; set; } 

    [JsonProperty("actions_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Actions_field_name { get; set; } 

    [JsonProperty("table_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CustomTable? Table_info { get; set; } 

    [JsonProperty("client_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaField>? Client_restrictions { get; set; } 

    [JsonProperty("org_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OrganisationField>? Org_restrictions { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Database_lookup_id { get; set; } 

    [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Database_lookup_name { get; set; } 

    [JsonProperty("database_lookup_auto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Database_lookup_auto { get; set; } 

    [JsonProperty("database_lookup_triggers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupField>? Database_lookup_triggers { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_name { get; set; } 

    [JsonProperty("sqllookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sqllookup { get; set; } 

    [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytochildonupdate { get; set; } 

    [JsonProperty("copytoparentonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytoparentonupdate { get; set; } 

    [JsonProperty("showintable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showintable { get; set; } 

    [JsonProperty("importalias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importalias { get; set; } 

    [JsonProperty("hyperlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hyperlink { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("visibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Visibility { get; set; } 

    [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Groupname { get; set; } 

    [JsonProperty("_testsql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _testsql { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("showhintondetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showhintondetails { get; set; } 

    [JsonProperty("partslookupusedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Partslookupusedin { get; set; } 

    [JsonProperty("showondetailsscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showondetailsscreen { get; set; } 

    [JsonProperty("selection_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Selection_field_id { get; set; } 

    [JsonProperty("selection_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Selection_field_name { get; set; } 

    [JsonProperty("variable_format_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? Variable_format_1 { get; set; } 

    [JsonProperty("variable_format_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? Variable_format_2 { get; set; } 

    [JsonProperty("customextratableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Customextratableid { get; set; } 

    [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytorelated { get; set; } 

    [JsonProperty("deleteafterclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleteafterclosure { get; set; } 

    [JsonProperty("deleteafterclosuredays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deleteafterclosuredays { get; set; } 

    [JsonProperty("defaultdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultdate { get; set; } 

    [JsonProperty("validation_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldValidation>? Validation_data { get; set; } 

    [JsonProperty("calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Calculation { get; set; } 

    [JsonProperty("rounding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rounding { get; set; } 

    [JsonProperty("regex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Regex { get; set; } 

    [JsonProperty("onlyshowforagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Onlyshowforagents { get; set; } 

    [JsonProperty("excludefromallfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Excludefromallfields { get; set; } 

    [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mandatory { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("inherit_ac_from_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inherit_ac_from_tickettype { get; set; } 

    [JsonProperty("is_horizontal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_horizontal { get; set; } 

    [JsonProperty("sqlcfvariables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Sqlcfvariables { get; set; } 

    [JsonProperty("showoncrmnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showoncrmnote { get; set; } 

    [JsonProperty("database_lookup_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Database_lookup_input { get; set; } 

    [JsonProperty("table_data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_data_entry_type { get; set; } 

    [JsonProperty("isencrypted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isencrypted { get; set; } 

    [JsonProperty("table_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_height { get; set; } 

    [JsonProperty("sql_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sql_connection_type { get; set; } 

    [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_user { get; set; } 

    [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_new_password { get; set; } 

    [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_server { get; set; } 

    [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_database { get; set; } 

    [JsonProperty("sql_certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sql_certificate_id { get; set; } 

    [JsonProperty("sql_certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_certificate_name { get; set; } 

    [JsonProperty("lookup_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SqlLookupRequest? Lookup_request { get; set; } 

    [JsonProperty("max_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max_selection { get; set; } 

    [JsonProperty("hint_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Hint_type { get; set; } 

    [JsonProperty("defaultdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultdays { get; set; } 

    [JsonProperty("new_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_storage_method { get; set; } 

    [JsonProperty("where_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Where_sql { get; set; } 

    [JsonProperty("load_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Load_type { get; set; } 

    [JsonProperty("hide_from_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_from_filters { get; set; } 

    [JsonProperty("lookup_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup_method { get; set; } 

    [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_id { get; set; } 

    [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_method_name { get; set; } 

    [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_value { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_method_value_name { get; set; } 

    [JsonProperty("display_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display_property { get; set; } 

    [JsonProperty("value_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_property { get; set; } 

    [JsonProperty("showinpool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinpool { get; set; } 

    [JsonProperty("allow_pool_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_pool_override { get; set; } 

    [JsonProperty("simplify_rich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Simplify_rich { get; set; } 

}