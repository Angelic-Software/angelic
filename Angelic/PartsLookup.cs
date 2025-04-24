using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PartsLookup
{
    [JsonProperty("lookup_value_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Lookup_value_obj { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_id { get; set; } 

    [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Table_name { get; set; } 

    [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_user { get; set; } 

    [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_new_password { get; set; } 

    [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_server { get; set; } 

    [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_database { get; set; } 

    [JsonProperty("sql_script", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sql_script { get; set; } 

    [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key_field { get; set; } 

    [JsonProperty("lookup_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_field { get; set; } 

    [JsonProperty("itemdesc1_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc1_field { get; set; } 

    [JsonProperty("itemdesc2_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc2_field { get; set; } 

    [JsonProperty("itemdesc3_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc3_field { get; set; } 

    [JsonProperty("itemvalue_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemvalue_field { get; set; } 

    [JsonProperty("matchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Matchedhint { get; set; } 

    [JsonProperty("notmatchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notmatchedhint { get; set; } 

    [JsonProperty("lookuponrefresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Lookuponrefresh { get; set; } 

    [JsonProperty("messagestring_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Messagestring_user { get; set; } 

    [JsonProperty("messagestring_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Messagestring_agent { get; set; } 

    [JsonProperty("showmessagetouseroragent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Showmessagetouseroragent { get; set; } 

    [JsonProperty("messagerequiresconfirmationuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Messagerequiresconfirmationuser { get; set; } 

    [JsonProperty("messagerequiresconfirmationagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Messagerequiresconfirmationagent { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupField>? Fields { get; set; } 

    [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupMapping>? Field_mappings { get; set; } 

    [JsonProperty("agent_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TechPartsLookup>? Agent_mappings { get; set; } 

    [JsonProperty("run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Run { get; set; } 

    [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_value { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PartsLookupResult? Lookup { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("lookupconnectiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookupconnectiontype { get; set; } 

    [JsonProperty("lookup_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup_type { get; set; } 

    [JsonProperty("lookup_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_type_name { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Certificate_id { get; set; } 

    [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Certificate_name { get; set; } 

    [JsonProperty("allowmultipleresults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowmultipleresults { get; set; } 

    [JsonProperty("lookup_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup_field_id { get; set; } 

    [JsonProperty("lookup_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_field_name { get; set; } 

    [JsonProperty("outcome_mapped_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome_mapped_field { get; set; } 

    [JsonProperty("outcome_mapped_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Outcome_mapped_field_name { get; set; } 

    [JsonProperty("invert_outcome_mapped_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invert_outcome_mapped_result { get; set; } 

    [JsonProperty("trigger_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Trigger_type { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Autoassign>? Rules { get; set; } 

    [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_id { get; set; } 

    [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_method_name { get; set; } 

    [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_value { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_method_value_name { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

}