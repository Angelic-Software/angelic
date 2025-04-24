using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NPR_Result
{
    [JsonProperty("windows_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Windows_user { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_address { get; set; } 

    [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Activedirectory_dn { get; set; } 

    [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Onpremise_activedirectory_dn { get; set; } 

    [JsonProperty("enrolled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enrolled { get; set; } 

    [JsonProperty("questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SecurityQuestion>? Questions { get; set; } 

    [JsonProperty("hide_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_answers { get; set; } 

    [JsonProperty("validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Validated { get; set; } 

}