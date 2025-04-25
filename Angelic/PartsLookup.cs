using System.CodeDom.Compiler;
using Angelic.Configuration;
using Angelic.Configuration.CustomFields;
using Angelic.Configuration.Tickets.TicketRule;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PartsLookup
{
    [JsonProperty("lookup_value_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? LookupValueObj { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableId { get; set; } 

    [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableName { get; set; } 

    [JsonProperty("sql_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlUser { get; set; } 

    [JsonProperty("sql_new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlNewPassword { get; set; } 

    [JsonProperty("sql_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlServer { get; set; } 

    [JsonProperty("sql_database", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlDatabase { get; set; } 

    [JsonProperty("sql_script", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlScript { get; set; } 

    [JsonProperty("key_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyField { get; set; } 

    [JsonProperty("lookup_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupField { get; set; } 

    [JsonProperty("itemdesc1_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc1Field { get; set; } 

    [JsonProperty("itemdesc2_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc2Field { get; set; } 

    [JsonProperty("itemdesc3_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemdesc3Field { get; set; } 

    [JsonProperty("itemvalue_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemvalueField { get; set; } 

    [JsonProperty("matchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Matchedhint { get; set; } 

    [JsonProperty("notmatchedhint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notmatchedhint { get; set; } 

    [JsonProperty("lookuponrefresh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Lookuponrefresh { get; set; } 

    [JsonProperty("messagestring_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessagestringUser { get; set; } 

    [JsonProperty("messagestring_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessagestringAgent { get; set; } 

    [JsonProperty("showmessagetouseroragent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowMessagetouseroragent { get; set; } 

    [JsonProperty("messagerequiresconfirmationuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Messagerequiresconfirmationuser { get; set; } 

    [JsonProperty("messagerequiresconfirmationagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Messagerequiresconfirmationagent { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupField>? Fields { get; set; } 

    [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PartsLookupMapping>? FieldMappings { get; set; } 

    [JsonProperty("agent_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TechPartsLookup>? AgentMappings { get; set; } 

    [JsonProperty("run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Run { get; set; } 

    [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupValue { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PartsLookupResult? Lookup { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("lookupconnectiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookupconnectiontype { get; set; } 

    [JsonProperty("lookup_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupType { get; set; } 

    [JsonProperty("lookup_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupTypeName { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CertificateId { get; set; } 

    [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CertificateName { get; set; } 

    [JsonProperty("allowmultipleresults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowmultipleresults { get; set; } 

    [JsonProperty("lookup_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupFieldId { get; set; } 

    [JsonProperty("lookup_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupFieldName { get; set; } 

    [JsonProperty("outcome_mapped_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeMappedField { get; set; } 

    [JsonProperty("outcome_mapped_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeMappedFieldName { get; set; } 

    [JsonProperty("invert_outcome_mapped_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvertOutcomeMappedResult { get; set; } 

    [JsonProperty("trigger_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TriggerType { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRules>? Rules { get; set; } 

    [JsonProperty("integration_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMethodId { get; set; } 

    [JsonProperty("integration_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMethodName { get; set; } 

    [JsonProperty("integration_method_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMethodValue { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMethodValueName { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

}