using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomFieldValidation
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FiId { get; set; } 

    [JsonProperty("filinktoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filinktoid { get; set; } 

    [JsonProperty("validationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Validationtype { get; set; } 

    [JsonProperty("askforreason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Askforreason { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Hours { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}