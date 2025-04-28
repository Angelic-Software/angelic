using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.EventManagement;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EventMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EventRuleId { get; set; } 

    [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? EventRuleGuid { get; set; } 

    [JsonProperty("integration_method_value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationMethodValueId { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationMethodValueName { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}