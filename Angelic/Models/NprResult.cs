using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record NprResult
{
    [JsonProperty("windows_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WindowsUser { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActiveDirectoryDn { get; set; } 

    [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OnPremiseActiveDirectoryDn { get; set; } 

    [JsonProperty("enrolled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enrolled { get; set; } 

    [JsonProperty("questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SecurityQuestion>? Questions { get; set; } 

    [JsonProperty("hide_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAnswers { get; set; } 

    [JsonProperty("validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Validated { get; set; } 

}