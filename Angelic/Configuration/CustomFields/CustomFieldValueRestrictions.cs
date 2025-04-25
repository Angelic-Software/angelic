using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomFieldValueRestrictions
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueId { get; set; } 

    [JsonProperty("value_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ValueGuid { get; set; } 

    [JsonProperty("value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}