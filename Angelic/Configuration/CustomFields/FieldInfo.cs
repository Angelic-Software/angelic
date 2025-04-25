using System.CodeDom.Compiler;
using Angelic.Areas;
using Angelic.Configuration.SqlImports;
using Newtonsoft.Json;

namespace Angelic.Configuration.CustomFields;

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
    public Guid? UsageGuid { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabId { get; set; } 

    [JsonProperty("tab_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TabGuid { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TabName { get; set; } 

    [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabSequence { get; set; } 

    [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabColumns { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableId { get; set; } 

    [JsonProperty("table_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TableGuid { get; set; } 

    [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableName { get; set; } 

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
    public bool? UserSearchable { get; set; } 

    [JsonProperty("calendar_searchable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CalendarSearchable { get; set; } 

    [JsonProperty("defaultvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Defaultvalue { get; set; } 

    [JsonProperty("ordervaluesalphanumerically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ordervaluesalphanumerically { get; set; } 

    [JsonProperty("ordervalueby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ordervalueby { get; set; } 

    [JsonProperty("defaultvalue_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultvalueLookup { get; set; } 

    [JsonProperty("defaultvalue_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomTableRow>? DefaultvalueTable { get; set; } 

    [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Values { get; set; } 

    [JsonProperty("table_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomTableRow>? TableValues { get; set; } 

    [JsonProperty("new_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValues { get; set; } 

    [JsonProperty("variable_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VariableName { get; set; } 

    [JsonProperty("faults_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FaultsFieldName { get; set; } 

    [JsonProperty("actions_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionsFieldName { get; set; } 

    [JsonProperty("table_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CustomTable? TableInfo { get; set; } 

    [JsonProperty("client_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaField>? ClientRestrictions { get; set; } 

    [JsonProperty("org_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OrganisationField>? OrgRestrictions { get; set; } 

    [JsonProperty("database_lookup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupId { get; set; } 

    [JsonProperty("database_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DatabaseLookupName { get; set; } 

    [JsonProperty("database_lookup_auto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DatabaseLookupAuto { get; set; } 

    [JsonProperty("database_lookup_triggers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupField>? DatabaseLookupTriggers { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyName { get; set; } 

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
    public bool? Testsql { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("showhintondetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showhintondetails { get; set; } 

    [JsonProperty("partslookupusedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Partslookupusedin { get; set; } 

    [JsonProperty("showondetailsscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOndetailsscreen { get; set; } 

    [JsonProperty("selection_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SelectionFieldId { get; set; } 

    [JsonProperty("selection_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SelectionFieldName { get; set; } 

    [JsonProperty("variable_format_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? VariableFormat1 { get; set; } 

    [JsonProperty("variable_format_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? VariableFormat2 { get; set; } 

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
    public ICollection<CustomFieldValidation>? ValidationData { get; set; } 

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
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("inherit_ac_from_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InheritAcFromTicketType { get; set; } 

    [JsonProperty("is_horizontal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHorizontal { get; set; } 

    [JsonProperty("sqlcfvariables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Sqlcfvariables { get; set; } 

    [JsonProperty("showoncrmnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOncrmnote { get; set; } 

    [JsonProperty("database_lookup_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DatabaseLookupInput { get; set; } 

    [JsonProperty("table_data_entry_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableDataEntryType { get; set; } 

    [JsonProperty("isencrypted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isencrypted { get; set; } 

    [JsonProperty("table_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableHeight { get; set; } 

    [JsonProperty("sql_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlConnectionType { get; set; } 

    [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlUser { get; set; } 

    [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlNewPassword { get; set; } 

    [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlServer { get; set; } 

    [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlDatabase { get; set; } 

    [JsonProperty("sql_certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlCertificateId { get; set; } 

    [JsonProperty("sql_certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlCertificateName { get; set; } 

    [JsonProperty("lookup_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SqlLookupRequest? LookupRequest { get; set; } 

    [JsonProperty("max_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxSelection { get; set; } 

    [JsonProperty("hint_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HintType { get; set; } 

    [JsonProperty("defaultdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defaultdays { get; set; } 

    [JsonProperty("new_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewStorageMethod { get; set; } 

    [JsonProperty("where_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WhereSql { get; set; } 

    [JsonProperty("load_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadType { get; set; } 

    [JsonProperty("hide_from_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideFromFilters { get; set; } 

    [JsonProperty("lookup_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupMethod { get; set; } 

    [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMethodId { get; set; } 

    [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMethodName { get; set; } 

    [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMethodValue { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMethodValueName { get; set; } 

    [JsonProperty("display_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayProperty { get; set; } 

    [JsonProperty("value_property", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueProperty { get; set; } 

    [JsonProperty("showinpool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinpool { get; set; } 

    [JsonProperty("allow_pool_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowPoolOverride { get; set; } 

    [JsonProperty("simplify_rich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SimplifyRich { get; set; } 

}