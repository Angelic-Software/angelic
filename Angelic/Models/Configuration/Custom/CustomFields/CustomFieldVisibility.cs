using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Custom.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomFieldVisibility
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FieldGuid { get; set; } 

    [JsonProperty("lookup_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupFieldId { get; set; } 

    [JsonProperty("lookup_field_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? LookupFieldGuid { get; set; } 

    [JsonProperty("lookup_value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LookupValueId { get; set; } 

    [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupValue { get; set; } 

    [JsonProperty("field_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldValue { get; set; } 

    [JsonProperty("dynamic_SQL_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DynamicSqlField { get; set; } 

    [JsonProperty("value_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValueModified { get; set; } 

    [JsonProperty("conditiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Conditiontype { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}