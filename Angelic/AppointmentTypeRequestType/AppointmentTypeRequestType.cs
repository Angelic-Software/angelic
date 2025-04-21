using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AppointmentTypeRequestType;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AppointmentTypeRequestType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("appointment_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentTypeId { get; set; }
    
    [JsonProperty("request_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestTypeId { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
